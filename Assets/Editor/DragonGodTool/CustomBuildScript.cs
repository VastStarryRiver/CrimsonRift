using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;



public class CustomBuildScript
{
    private static List<string> m_excludedFolders = new List<string> { "Assets/GameAssets" };// 设置需要排除的文件夹
    private static HashSet<string> m_excludedAssets = new HashSet<string>();// 收集所有需要排除的资源路径
    private static string m_rootPath = Application.streamingAssetsPath.Replace("Assets/StreamingAssets", "");
    private static Dictionary<string, string> m_filesContent = null;



    [MenuItem("GodDragonTool/打包流程/一键导出所有热更新资源", false, -2)]
    public static void OneKeyExportAllAssets_Android()
    {
        BuildWebBinFile();
        ExcludedAssets();

        AtlasBuilder.PackSpriteAtlas();

        ExportExcelTool.ExportExcelToDictionary();

        foreach (var assetPath in m_excludedAssets)
        {
            AssetImporter importer = AssetImporter.GetAtPath(assetPath);

            if (importer != null)
            {
                importer.SetAssetBundleNameAndVariant("", "");
            }
        }

        ExportAssetBundle.BuildAssetBundles_WeixinMiniGame();
        ExportAssetBundle.BuildAssetBundles_Windows();

        CreateCatalogueFile();

        foreach (var assetPath in m_excludedAssets)
        {
            AssetImporter importer = AssetImporter.GetAtPath(assetPath);

            if (importer != null)
            {
                importer.SetAssetBundleNameAndVariant("tempExcludedAssetBundle", "");
            }
        }
    }



    private static void BuildWebBinFile()
    {
        using (FileStream fileStream = new FileStream(DataUtilityManager.m_localRootPath + "WebData.txt", FileMode.Open))
        {
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                LuaCallCS.SaveSafeFile(streamReader.ReadToEnd(), Application.streamingAssetsPath + "/WebData.bin");
            }
        }

        AssetDatabase.Refresh();
    }

    private static void ExcludedAssets()
    {
        m_excludedAssets.Clear();

        foreach (string folder in m_excludedFolders)
        {
            string[] assetPaths = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);

            foreach (string assetPath in assetPaths)
            {
                if (Path.GetExtension(assetPath) == ".meta")// 忽略.meta文件
                {
                    continue;
                }

                string relativePath = assetPath.Replace(Application.dataPath, "Assets");
                m_excludedAssets.Add(relativePath);
            }
        }
    }

    private static void CreateCatalogueFile()
    {
        string dir = m_rootPath + "CatalogueFiles";

        if (Directory.Exists(dir))
        {
            Directory.Delete(dir, true);
        }

        DataUtilityManager.InitDirectory(dir);

        using (FileStream fs = new FileStream(dir + "/CatalogueFile.txt", FileMode.Create))
        {
            using (StreamWriter sw = new StreamWriter(fs))
            {
                SetMd5Files(DataUtilityManager.m_binPath + "/Config/Client");
                SetMd5Files(DataUtilityManager.m_binPath + "/Atlas");
                SetMd5Files(m_rootPath + "Lua");
                SetMd5Files(dir.Replace("CatalogueFiles", "AssetBundles"));

                if (m_filesContent != null && m_filesContent.Count > 0)
                {
                    sw.Write(JsonConvert.SerializeObject(m_filesContent));
                    m_filesContent.Clear();
                }

                m_filesContent = null;
            }
        }
    }

    private static void SetMd5Files(string directoryPath)
    {
        DirectoryInfo folder = new DirectoryInfo(directoryPath);

        //遍历文件
        foreach (FileInfo nextFile in folder.GetFiles())
        {
            string suffix = Path.GetExtension(nextFile.Name);

            if (suffix == ".meta" || nextFile.Name == ".emmyrc.json")
            {
                goto A;
            }

            string fullPath = directoryPath + "/" + nextFile.Name;
            string savePath = fullPath.Replace(m_rootPath, "");

            if (m_filesContent == null)
            {
                m_filesContent = new Dictionary<string, string>();
            }

            m_filesContent.Add(savePath, Get32MD5(nextFile.OpenText().ReadToEnd()));

        A:;
        }

        //遍历文件夹
        foreach (DirectoryInfo nextFolder in folder.GetDirectories())
        {
            if (nextFolder.Name == ".idea")
            {
                goto B;
            }

            SetMd5Files(directoryPath + "/" + nextFolder.Name);

        B:;
        }
    }

    private static string Get32MD5(string content)
    {
        MD5 md5 = MD5.Create();

        StringBuilder stringBuilder = new StringBuilder();

        byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(content)); //该方法的参数也可以传入Stream

        for (int i = 0; i < bytes.Length; i++)
        {
            stringBuilder.Append(bytes[i].ToString("X2"));
        }

        string md5Str = stringBuilder.ToString();

        return md5Str;
    }
}