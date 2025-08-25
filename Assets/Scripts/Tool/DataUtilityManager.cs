using System;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

public static class DataUtilityManager
{
#if UNITY_EDITOR
    public static string m_platform = "Windows";
    public static string m_localRootPath = Application.streamingAssetsPath.Replace("Assets/StreamingAssets", "");//本地数据根目录
#else
    public static string m_platform = "Android";
    public static string m_localRootPath = Application.persistentDataPath + "/";
#endif

    public static string m_binPath = m_localRootPath + "Bin";//存放bin文件的路径

    private static string[] m_webData = null;

    public static string WebRootPath//热更新根目录
    {
        get
        {
            return LoadWebData(0);
        }
    }

    public static string WebIpv4Str//服务器的公网地址
    {
        get
        {
            string[] list = LoadWebData(1).Split(":");
            return list[0];
        }
    }

    public static int WebPortInt//服务器用于连接客户端的端口号
    {
        get
        {
            string[] list = LoadWebData(1).Split(":");
            return int.Parse(list[1]);
        }
    }



    private class BypassCertificate : CertificateHandler
    {
        protected override bool ValidateCertificate(byte[] certificateData)
        {
            return true; // 始终返回 true 以忽略证书验证
        }
    }

    public static void InitDirectory(string path)
    {
        path = path.Replace("\\", "/");

        string extension = Path.GetExtension(path);

        string directoryPath = "";

        if(string.IsNullOrEmpty(extension))
        {
            directoryPath = path;
        }
        else
        {
            directoryPath = Path.GetDirectoryName(path);
        }

        if (!Directory.Exists(directoryPath))
        {
            //确保路径中的所有文件夹都存在
            Directory.CreateDirectory(directoryPath);
        }
    }

    public static void SetWebQuestData(ref UnityWebRequest requestHandler)
    {
        string username = LoadWebData(2);
        string password = LoadWebData(3);
        string encodedAuth = Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password));

        requestHandler.SetRequestHeader("Authorization", "Basic " + encodedAuth);

        requestHandler.certificateHandler = new BypassCertificate();
    }

    private static string LoadWebData(int index)
    {
        if (m_webData == null)
        {
            using (UnityWebRequest requestHandler = UnityWebRequest.Get(Application.streamingAssetsPath + "/WebData.bin"))
            {
                requestHandler.SendWebRequest();

                while (!requestHandler.isDone)
                {
                    // 等待请求完成
                }

                m_webData = LuaCallCS.ReadSafeFile<string>(requestHandler.downloadHandler.data).Split('\n');
            }
        }

        string text = m_webData[index].Replace("\r", "");

        return text;
    }
}