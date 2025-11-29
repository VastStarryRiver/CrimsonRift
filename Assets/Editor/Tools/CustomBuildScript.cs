using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEditor.Build;



public class CustomBuildScript : IActiveBuildTargetChanged
{
    // 有多个监听类的时候，返回值越小，执行顺序越靠前
    public int callbackOrder { get { return 0; } }

    private static bool m_isChange = false;



    [MenuItem("Tools/打包流程/Android/导出Config和Bundle", false, -7)]
    public static void OneKeyExportAllAssets_Android()
    {
        m_isChange = true;

        if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.Android)
        {
            OnActiveBuildTargetChanged(BuildTarget.Android);
            return;
        }
        
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
    }

    [MenuItem("Tools/打包流程/Android/打包成APK文件", false, -6)]
    public static void PackageProject_Android()
    {
        SetAndroidKeystore();
        PackageProject(BuildTarget.Android, Environment.GetFolderPath(Environment.SpecialFolder.Desktop).Replace("\\", "/") + "/CrimsonRift.apk");
    }

    [MenuItem("Tools/打包流程/Windows/导出Config和Bundle", false, -5)]
    public static void OneKeyExportAllAssets_Windows()
    {
        m_isChange = true;

        if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.StandaloneWindows64)
        {
            OnActiveBuildTargetChanged(BuildTarget.StandaloneWindows64);
            return;
        }

        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Standalone, BuildTarget.StandaloneWindows64);
    }



    private static void SetAndroidKeystore()
    {
        string keystorePath = ConfigUtils.m_keystorePath; // Keystore 文件路径

        // 确保 keystore 文件存在
        if (!File.Exists(keystorePath))
        {
            Debug.LogError("Keystore文件不存在: " + keystorePath);
            return;
        }

        // 设置 keystore 信息
        PlayerSettings.Android.keystoreName = keystorePath;
        PlayerSettings.Android.keystorePass = "149630764"; // Keystore 密码
        PlayerSettings.Android.keyaliasName = "crimsonrift"; // Alias 名称
        PlayerSettings.Android.keyaliasPass = "149630764"; // Alias 密码
    }

    private static void PackageProject(BuildTarget target, string locationPathName)
    {
        // 获取所有场景
        string[] scenes = EditorBuildSettingsScene.GetActiveSceneList(EditorBuildSettings.scenes);

        // 设置构建选项
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = locationPathName,//打包的输出路径
            target = target,
            options = BuildOptions.None
        };

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }

    public void OnActiveBuildTargetChanged(BuildTarget previousTarget, BuildTarget newTarget)
    {
        if (!m_isChange)
        {
            return;
        }

        m_isChange = false;

        ConfigTool.BuildWebBinFile();
        ConfigTool.ExportConfig();

        if (newTarget == BuildTarget.Android)
        {
            AddressablesTool.BuildAddressables_Android();
        }
        else if (newTarget == BuildTarget.StandaloneWindows64)
        {
            AddressablesTool.BuildAddressables_Windows();
        }
    }

    private static void OnActiveBuildTargetChanged(BuildTarget newTarget)
    {
        if (!m_isChange)
        {
            return;
        }

        m_isChange = false;

        ConfigTool.BuildWebBinFile();
        ConfigTool.ExportConfig();

        if (newTarget == BuildTarget.Android)
        {
            AddressablesTool.BuildAddressables_Android();
        }
        else if (newTarget == BuildTarget.StandaloneWindows64)
        {
            AddressablesTool.BuildAddressables_Windows();
        }
    }
}