using System;
using UnityEngine;
using XLua;



public static partial class LuaCallCS
{
    public static Camera MainUICamera
    {
        get
        {
            return GameObject.Find("UI_Root/Canvas_0/UI_Camera").GetComponent<Camera>();
        }
    }

    public static RectTransform MainUIRoot
    {
        get
        {
            return GameObject.Find("UI_Root").GetComponent<RectTransform>();
        }
    }

    public static Camera MainSceneCamera
    {
        get
        {
            return GameObject.Find("SceneGameObject/Main Camera").GetComponent<Camera>();
        }
    }

    public static GameObject GetGameObject(UnityEngine.Object obj, string childPath = "")
    {
        GameObject gameObject = null;

        if (obj is GameObject)
        {
            gameObject = obj as GameObject;
        }
        else if (obj is Component)
        {
            var component = obj as Component;
            gameObject = component.gameObject;
        }

        if (!string.IsNullOrEmpty(childPath))
        {
            Transform trans = gameObject.transform.Find(childPath);

            if (trans != null)
            {
                return trans.gameObject;
            }

            return null;
        }

        return gameObject;
    }

    public static GameObject GetGameObject(string childPath)
    {
        GameObject gameObject = GameObject.Find(childPath);
        return gameObject;
    }

    public static Transform GetTransform(UnityEngine.Object obj, string childPath = "")
    {
        var gameObject = GetGameObject(obj, childPath);

        if (gameObject != null)
        {
            return gameObject.transform;
        }

        return null;
    }

    public static void OpenUIPrefabPanel(string prefabPath, string luaPath, int layer)
    {
        int startIndex = prefabPath.LastIndexOf("/") + 1;
        string prefabName = prefabPath.Substring(startIndex, prefabPath.Length - startIndex);

        LuaFunction getFunc = LuaManager.Instance.UIManager.Get<LuaFunction>("GetUIPanel");
        LuaTable luaClass = getFunc?.Call(prefabName)[0] as LuaTable;

        if (luaClass == null)
        {
            LuaManager.Instance.m_luaEnv.DoString("require('" + luaPath + "')");

            GameObject obj = CreateUIGameObject(prefabPath, prefabName, layer);

            AddComponent(obj, "", "PrefabInstance");
        }

        getFunc?.Dispose();
    }

    public static void OpenUIPrefabPanel(GameObject prefab, string luaPath)
    {
        string prefabName = prefab.name;

        LuaFunction getFunc = LuaManager.Instance.UIManager.Get<LuaFunction>("GetUIPanel");
        LuaTable luaClass = getFunc?.Call(prefabName)[0] as LuaTable;

        if (luaClass == null)
        {
            LuaManager.Instance.m_luaEnv.DoString("require('" + luaPath + "')");
            AddComponent(prefab, "", "PrefabInstance");
        }

        getFunc?.Dispose();
    }

    public static void CloseUIPrefabPanel(string prefabName)
    {
        LuaFunction getFunc = LuaManager.Instance.UIManager.Get<LuaFunction>("GetUIPanel");
        LuaTable luaClass = getFunc?.Call(prefabName)[0] as LuaTable;

        if (luaClass != null)
        {
            GameObject.Destroy((GameObject)luaClass["gameObject"]);
        }

        getFunc?.Dispose();
    }

    public static GameObject CreateUIGameObject(string prefabPath, string prefabName, int layer = -1, UnityEngine.Object parent = null)
    {
        GameObject gameObject = null;
        Transform parentTrans = null;

        if (layer != -1)
        {
            parentTrans = GameObject.Find("UI_Root/Canvas_" + layer + "/Ts_Panel").transform;
        }
        else if (parent != null)
        {
            parentTrans = GetTransform(parent);
        }

        if (!string.IsNullOrEmpty(prefabPath))
        {
            string[] assetNames = new string[] { prefabName + ".prefab" };

            AssetBundleManager.LoadAssetBundle(DataUtilityManager.m_localRootPath + "AssetBundles/" + DataUtilityManager.m_platform + "/prefabs/" + prefabPath.ToLower() + ".prefab_ab", assetNames, (name, asset) => {
                if (name == assetNames[0])
                {
                    gameObject = GameObject.Instantiate((GameObject)asset, parentTrans);

                    gameObject.name = prefabName;
                }
            });
        }
        else
        {
            gameObject = new GameObject(prefabName);

            if(parentTrans != null)
            {
                gameObject.transform.SetParent(parentTrans);
            }
        }

        return gameObject;
    }

    public static Component GetComponent(UnityEngine.Object obj, string childPath, string componentName)
    {
        GameObject gameObject = GetGameObject(obj);
        Transform trans = null;

        if (gameObject != null)
        {
            trans = gameObject.transform;
        }
        else
        {
            return null;
        }

        if (!string.IsNullOrEmpty(childPath))
        {
            trans = trans.Find(childPath);
        }

        if (trans != null)
        {
            return trans.GetComponent(componentName);
        }

        return null;
    }

    public static Component AddComponent(UnityEngine.Object obj, string childPath, string componentName)
    {
        GameObject gameObject = GetGameObject(obj);

        if (gameObject == null)
        {
            return null;
        }

        if (!string.IsNullOrEmpty(childPath))
        {
            Transform trans = gameObject.transform.Find(childPath);

            if (trans == null)
            {
                return null;
            }

            gameObject = trans.gameObject;
        }

        Component component = gameObject.GetComponent(componentName);

        if (component == null)
        {
            Type type = Type.GetType(componentName);

            if (type == null)
            {
                type = FindTypeTool.GetComponentType(componentName);
            }

            if (type != null)
            {
                component = gameObject.AddComponent(type);
            }
        }

        return component;
    }

    public static GameObject Clone(UnityEngine.Object obj, string name = "cloneName", UnityEngine.Object parent = null)
    {
        GameObject item = GetGameObject(obj);
        GameObject clone;

        if (parent != null)
        {
            Transform parentTrans = GetTransform(parent);
            clone = GameObject.Instantiate<GameObject>(item, Vector3.zero, Quaternion.identity, parentTrans);
        }
        else
        {
            clone = GameObject.Instantiate<GameObject>(item, Vector3.zero, Quaternion.identity);
        }

        clone.name = name;

        return clone;
    }

    public static void SetActive(UnityEngine.Object obj, bool isActive = false)
    {
        GameObject item = GetGameObject(obj);
        item.SetActive(isActive);
    }

    public static void SetActive(UnityEngine.Object obj, string childPath, bool isActive = false)
    {
        GameObject item = GetGameObject(obj);

        if (!string.IsNullOrEmpty(childPath))
        {
            item = item.transform.Find(childPath).gameObject;
        }

        item.SetActive(isActive);
    }
}