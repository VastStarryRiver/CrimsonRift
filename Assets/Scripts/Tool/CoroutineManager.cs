using UnityEngine;
using XLua;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;



public class CoroutineManager : MonoBehaviour
{
    public static CoroutineManager Instance = null;



    private void Awake()
    {
        Instance = this;
    }



    public void InvokeLoadAssetAsync(AssetBundle assetBundle, string assetName, LoadAssetBundleCallBack callBack)
    {
        StartCoroutine(LoadAssetAsync(assetBundle, assetName, callBack));
    }

    private IEnumerator LoadAssetAsync(AssetBundle assetBundle, string assetName, LoadAssetBundleCallBack callBack)
    {
        AssetBundleRequest assetRequest = assetBundle.LoadAssetAsync(assetName);

        yield return assetRequest;

        callBack(assetName,assetRequest.asset);
    }

    public void InvokePlayAnimation(UnityEngine.Object obj, string childPath = "", string animName = "", WrapMode wrapMode = WrapMode.Once, LuaFunction callBack = null)
    {
        StartCoroutine(PlayAnimation(obj, childPath, animName, wrapMode, callBack));
    }

    private IEnumerator PlayAnimation(UnityEngine.Object obj, string childPath = "", string animName = "", WrapMode wrapMode = WrapMode.Once, LuaFunction callBack = null)
    {
        if (string.IsNullOrEmpty(animName))
        {
            yield break;
        }

        Transform trans = LuaCallCS.GetTransform(obj);

        if (trans == null)
        {
            yield break;
        }

        if (!string.IsNullOrEmpty(childPath))
        {
            trans = trans.Find(childPath);
        }

        if (trans == null)
        {
            yield break;
        }

        Animation animation = trans.GetComponent<Animation>();

        if (animation == null)
        {
            yield break;
        }

        animation.wrapMode = wrapMode;

        animation.Play(animName);

        if (wrapMode == WrapMode.Once)
        {
            yield return new WaitWhile(() => animation.isPlaying);

            if (callBack != null)
            {
                callBack.Call();
            }
        }
    }

    public void InvokeRestartGame()
    {
        StartCoroutine(RestartGame());
    }

    private IEnumerator RestartGame()
    {
        LuaCallCS.MainSceneCamera.clearFlags = CameraClearFlags.SolidColor;
        LuaCallCS.MainSceneCamera.backgroundColor = Color.black;

        List<string> list = new List<string>();

        foreach (var item in LuaManager.Instance.m_luaClassList)
        {
            list.Add(item.Key);
        }

        if (list.Count > 0)
        {
            for (int i = 0; i < list.Count; i++)
            {
                LuaCallCS.CloseUIPrefabPanel(list[i]);
            }
        }

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);

        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            Debug.Log("加载进度: " + (progress * 100) + "%");
            yield return null;
        }
    }
}