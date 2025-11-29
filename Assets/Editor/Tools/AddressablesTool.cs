using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;
using System.Collections.Generic;
using System.Text.RegularExpressions;



public class AddressablesTool
{
    private static AddressableAssetSettings m_settings = AddressableAssetSettingsDefaultObject.Settings;



    [MenuItem("Tools/Addressables/BuildBundle_Android", false, -4)]
    public static void BuildAddressables_Android()
    {
        SetProfileValue("Android");
        BuildAddressables("Android");
    }

    [MenuItem("Tools/Addressables/BuildBundle_Windows", false, -3)]
    public static void BuildAddressables_Windows()
    {
        SetProfileValue("Windows");
        BuildAddressables("Windows");
    }



    private struct AssetInfo
    {
        public string guid;
        public string group;
        public string address;
        public List<string> labels;
    }

    public static void SetProfileValue(string platform)
    {
        AddressableAssetProfileSettings profileSettings = m_settings.profileSettings;

        string profileId = profileSettings.GetProfileId(platform);

        m_settings.activeProfileId = profileId;

        EditorUtility.SetDirty(m_settings);

        AssetDatabase.SaveAssets();

        AssetDatabase.Refresh();
    }

    private static void BuildAddressables(string platform)
    {
        string dir = ConfigUtils.m_bundlePath + "/" + platform;

        if (Directory.Exists(dir))
        {
            Directory.Delete(dir, true);
        }

        Directory.CreateDirectory(dir);

        List<AssetInfo> assetInfos = new List<AssetInfo>();
        GetAssetInfos(ConfigUtils.m_assetsPath, ref assetInfos);

        foreach (var group in m_settings.groups)
        {
            if (group.name.Contains("Localization") || group.name.Contains("Built"))
            {
                continue;
            }

            List<AddressableAssetEntry> entries = new List<AddressableAssetEntry>();

            foreach (var item in group.entries)
            {
                entries.Add(item);
            }

            if (entries.Count > 0)
            {
                for (int i = entries.Count - 1; i >= 0; i--)
                {
                    group.RemoveAssetEntry(entries[i]);
                }
            }
        }

        for (int i = 0; i < assetInfos.Count; i++)
        {
            AssetInfo assetInfo = assetInfos[i];
            SetAssetImportSettings(assetInfo.guid, assetInfo.group, assetInfo.address, assetInfo.labels);
        }

        AddressableAssetSettings.BuildPlayerContent();
    }

    private static void GetAssetInfos(string path, ref List<AssetInfo> assetInfos)
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(path);
        FileInfo[] files = directoryInfo.GetFiles();
        DirectoryInfo[] directorys = directoryInfo.GetDirectories();

        if (files.Length > 0)
        {
            // 遍历当前目录下的所有文件
            foreach (FileInfo file in files)
            {
                if (Path.GetExtension(file.FullName) == ".meta" || Path.GetFileName(file.FullName) == ".emmyrc.json")
                {
                    continue;
                }

                string path2 = file.FullName.Replace("\\", "/").Replace(ConfigUtils.m_localRootPath, "");
                string guid = AssetDatabase.AssetPathToGUID(path2);

                if (string.IsNullOrEmpty(guid))
                {
                    continue;
                }

                string group = "";
                string address = Path.GetFileName(path2);
                List<string> labels = new List<string>() { "Preload" };

                if (Regex.IsMatch(path2, @"Atlas\d{2}"))
                {
                    Match match = Regex.Match(path2, @"Atlas\d{2}");
                    group = match.Value;
                }
                else if (path2.Contains("/Animtion/"))
                {
                    group = "Animtion";
                }
                else if (path2.Contains("/Audios/"))
                {
                    group = "Audios";
                }
                else if (path2.Contains("/Config/"))
                {
                    group = "Config";
                }
                else if (path2.Contains("/Lua/"))
                {
                    group = "Lua";
                    labels.Add("LuaBytes");
                }
                else if (path2.Contains("/Materials/"))
                {
                    group = "Materials";
                }
                else if (path2.Contains("/Png/"))
                {
                    group = "Png";
                }
                else if (path2.Contains("/UI/"))
                {
                    group = "UI";
                }
                else if (path2.Contains("/Scenes/"))
                {
                    group = "Scenes";
                }
                else if (path2.Contains("/LocalAssets/"))
                {
                    group = "LocalAssets";
                }

                if (string.IsNullOrEmpty(group))
                {
                    continue;
                }

                assetInfos.Add(new AssetInfo { guid = guid, group = group, address = address, labels = labels });
            }
        }

        if (directorys.Length > 0)
        {
            // 递归遍历所有子文件夹
            foreach (DirectoryInfo subDir in directorys)
            {
                GetAssetInfos(subDir.FullName, ref assetInfos);
            }
        }
    }

    private static void SetAssetImportSettings(string guid, string group, string address, List<string> labels)
    {
        AddressableAssetGroup groupSetting = m_settings.FindGroup(group);

        if (groupSetting == null)
        {
            groupSetting = m_settings.CreateGroup(group, false, false, true, null);
        }

        BundledAssetGroupSchema schemaSetting = groupSetting.GetSchema<BundledAssetGroupSchema>();

        if (schemaSetting == null)
        {
            schemaSetting = groupSetting.AddSchema<BundledAssetGroupSchema>();
        }

        if (group == "LocalAssets")
        {
            schemaSetting.BuildPath.SetVariableByName(m_settings, AddressableAssetSettings.kLocalBuildPath);
            schemaSetting.LoadPath.SetVariableByName(m_settings, AddressableAssetSettings.kLocalLoadPath);
        }
        else
        {
            schemaSetting.BuildPath.SetVariableByName(m_settings, AddressableAssetSettings.kRemoteBuildPath);
            schemaSetting.LoadPath.SetVariableByName(m_settings, AddressableAssetSettings.kRemoteLoadPath);
        }

        schemaSetting.UseUnityWebRequestForLocalBundles = true;

        AddressableAssetEntry assetEntrySetting = m_settings.CreateOrMoveEntry(guid, groupSetting);

        assetEntrySetting.SetAddress(address);

        assetEntrySetting.labels.Clear();

        if (labels.Count > 0)
        {
            for (int i = 0; i < labels.Count; i++)
            {
                assetEntrySetting.SetLabel(labels[i], true, true);
            }
        }

        AssetDatabase.SaveAssets();

        AssetDatabase.Refresh();
    }
}