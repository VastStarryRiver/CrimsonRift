using System;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using System.Text;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.ResourceManagement.ResourceProviders;
using System.Collections.Generic;
using UnityEngine.U2D;



public class AddressablesManager : Singleton<AddressablesManager>
{
    private Dictionary<string, AsyncOperationHandle<SceneInstance>> m_sceneHandles;
    private Dictionary<string, AsyncOperationHandle<GameObject>> m_gameObjectHandles;
    private Dictionary<string, AsyncOperationHandle<Sprite>> m_spriteHandles;
    private Dictionary<string, AsyncOperationHandle<SpriteAtlas>> m_spriteAtlasHandles;
    private Dictionary<string, AsyncOperationHandle<BinAsset>> m_binAssetHandles;
    private Dictionary<string, AsyncOperationHandle<TextAsset>> m_textAssetHandles;
    private Dictionary<string, AsyncOperationHandle<AudioClip>> m_audioClipHandles;
    private Dictionary<string, AsyncOperationHandle<Material>> m_materialHandles;

    private class BypassCertificate : CertificateHandler
    {
        protected override bool ValidateCertificate(byte[] certificateData)
        {
            return true; // 始终返回 true 以忽略证书验证
        }
    }



    public void SetWebQuestData()
    {
        // 设置全局认证头
        Addressables.WebRequestOverride = (UnityWebRequest requestHandler) =>
        {
            string username = ConfigUtils.Username;
            string password = ConfigUtils.Password;
            string encodedAuth = Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password));

            requestHandler.SetRequestHeader("Authorization", "Basic " + encodedAuth);

            requestHandler.certificateHandler = new BypassCertificate();
        };
    }

    /// <summary>
    /// 预加载LuaBytes
    /// </summary>
    /// <param name="callBack"></param>
    public void PreLoadLuaBytes(Action callBack = null)
    {
        var mainLocations = Addressables.LoadResourceLocationsAsync("LuaBytes");

        mainLocations.Completed += (locations) =>
        {
            List<string> addressList = new List<string>();

            for (int i = 0; i < locations.Result.Count; i++)
            {
                addressList.Add(locations.Result[i].PrimaryKey);
            }

            LuaManager.Instance.m_luaDataList ??= new Dictionary<string, byte[]>();

            var mainHandle = Addressables.LoadAssetsAsync<TextAsset>(addressList, (asset) =>
            {
                LuaManager.Instance.m_luaDataList[$"{asset.name}.lua"] = asset.bytes;
            }, Addressables.MergeMode.Union, false);

            mainHandle.Completed += (handle) =>
            {
                callBack?.Invoke();
            };
        };
    }

    /// <summary>
    /// 异步加载GameObject
    /// </summary>
    /// <param name="address"></param>
    /// <param name="callBack"></param>
    public void AsyncLoadGameObject(string address, Action<GameObject> callBack)
    {
        m_gameObjectHandles ??= new Dictionary<string, AsyncOperationHandle<GameObject>>();

        if (m_gameObjectHandles.ContainsKey(address))
        {
            callBack(m_gameObjectHandles[address].Result);
        }
        else
        {
            AsyncOperationHandle<GameObject> handle = Addressables.LoadAssetAsync<GameObject>(address);

            handle.Completed += (operation) =>
            {
                if (operation.Status == AsyncOperationStatus.Succeeded)
                {
                    m_gameObjectHandles[address] = operation;
                    callBack(operation.Result);
                }
                else
                {
                    Debug.LogError($"异步加载资源失败！address:{address}");
                }
            };
        }
    }

    /// <summary>
    /// 异步加载Sprite
    /// </summary>
    /// <param name="address"></param>
    /// <param name="callBack"></param>
    public void AsyncLoadSprite(string address, Action<Sprite> callBack)
    {
        m_spriteHandles ??= new Dictionary<string, AsyncOperationHandle<Sprite>>();

        if (m_spriteHandles.ContainsKey(address))
        {
            callBack(m_spriteHandles[address].Result);
        }
        else
        {
            AsyncOperationHandle<Sprite> handle = Addressables.LoadAssetAsync<Sprite>(address);

            handle.Completed += (operation) =>
            {
                if (operation.Status == AsyncOperationStatus.Succeeded)
                {
                    m_spriteHandles[address] = operation;
                    callBack(operation.Result);
                }
                else
                {
                    Debug.LogError($"异步加载资源失败！address:{address}");
                }
            };
        }
    }

    /// <summary>
    /// 异步加载SpriteAtlas
    /// </summary>
    /// <param name="address"></param>
    /// <param name="callBack"></param>
    public void AsyncLoadSpriteAtlas(string address, Action<SpriteAtlas> callBack)
    {
        m_spriteAtlasHandles ??= new Dictionary<string, AsyncOperationHandle<SpriteAtlas>>();

        if (m_spriteAtlasHandles.ContainsKey(address))
        {
            callBack(m_spriteAtlasHandles[address].Result);
        }
        else
        {
            AsyncOperationHandle<SpriteAtlas> handle = Addressables.LoadAssetAsync<SpriteAtlas>(address);

            handle.Completed += (operation) =>
            {
                if (operation.Status == AsyncOperationStatus.Succeeded)
                {
                    m_spriteAtlasHandles[address] = operation;
                    callBack(operation.Result);
                }
                else
                {
                    Debug.LogError($"异步加载资源失败！address:{address}");
                }
            };
        }
    }

    /// <summary>
    /// 异步加载BinAsset
    /// </summary>
    /// <param name="address"></param>
    /// <param name="callBack"></param>
    public void AsyncLoadBinAsset(string address, Action<BinAsset> callBack)
    {
        m_binAssetHandles ??= new Dictionary<string, AsyncOperationHandle<BinAsset>>();

        if (m_binAssetHandles.ContainsKey(address))
        {
            callBack(m_binAssetHandles[address].Result);
        }
        else
        {
            AsyncOperationHandle<BinAsset> handle = Addressables.LoadAssetAsync<BinAsset>(address);

            handle.Completed += (operation) =>
            {
                if (operation.Status == AsyncOperationStatus.Succeeded)
                {
                    m_binAssetHandles[address] = operation;
                    callBack(operation.Result);
                }
                else
                {
                    Debug.LogError($"异步加载资源失败！address:{address}");
                }
            };
        }
    }

    /// <summary>
    /// 异步加载TextAsset
    /// </summary>
    /// <param name="address"></param>
    /// <param name="callBack"></param>
    public void AsyncLoadTextAsset(string address, Action<TextAsset> callBack)
    {
        m_textAssetHandles ??= new Dictionary<string, AsyncOperationHandle<TextAsset>>();
        if (m_textAssetHandles.ContainsKey(address))
        {
            callBack(m_textAssetHandles[address].Result);
        }
        else
        {
            AsyncOperationHandle<TextAsset> handle = Addressables.LoadAssetAsync<TextAsset>(address);

            handle.Completed += (operation) =>
            {
                if (operation.Status == AsyncOperationStatus.Succeeded)
                {
                    m_textAssetHandles[address] = operation;
                    callBack(operation.Result);
                }
                else
                {
                    Debug.LogError($"异步加载资源失败！address:{address}");
                }
            };
        }
    }

    /// <summary>
    /// 异步加载AudioClip
    /// </summary>
    /// <param name="address"></param>
    /// <param name="callBack"></param>
    public void AsyncLoadAudioClip(string address, Action<AudioClip> callBack)
    {
        m_audioClipHandles ??= new Dictionary<string, AsyncOperationHandle<AudioClip>>();

        if (m_audioClipHandles.ContainsKey(address))
        {
            callBack(m_audioClipHandles[address].Result);
        }
        else
        {
            AsyncOperationHandle<AudioClip> handle = Addressables.LoadAssetAsync<AudioClip>(address);

            handle.Completed += (operation) =>
            {
                if (operation.Status == AsyncOperationStatus.Succeeded)
                {
                    m_audioClipHandles[address] = operation;
                    callBack(operation.Result);
                }
                else
                {
                    Debug.LogError($"异步加载资源失败！address:{address}");
                }
            };
        }
    }

    /// <summary>
    /// 异步加载Material
    /// </summary>
    /// <param name="address"></param>
    /// <param name="callBack"></param>
    public void AsyncLoadMaterial(string address, Action<Material> callBack)
    {
        m_materialHandles ??= new Dictionary<string, AsyncOperationHandle<Material>>();

        if (m_materialHandles.ContainsKey(address))
        {
            callBack(m_materialHandles[address].Result);
        }
        else
        {
            AsyncOperationHandle<Material> handle = Addressables.LoadAssetAsync<Material>(address);

            handle.Completed += (operation) =>
            {
                if (operation.Status == AsyncOperationStatus.Succeeded)
                {
                    m_materialHandles[address] = operation;
                    callBack(operation.Result);
                }
                else
                {
                    Debug.LogError($"异步加载资源失败！address:{address}");
                }
            };
        }
    }

    /// <summary>
    /// 异步加载场景
    /// </summary>
    /// <param name="address"></param>
    /// <param name="loadSceneMode"></param>
    /// <param name="callBack"></param>
    public void AsyncLoadScene(string address, LoadSceneMode loadSceneMode, Action<Scene> callBack)
    {
        m_sceneHandles ??= new Dictionary<string, AsyncOperationHandle<SceneInstance>>();

        if (m_sceneHandles.ContainsKey(address))
        {
            AsyncOperationHandle<SceneInstance> handle = m_sceneHandles[address];
            callBack(handle.Result.Scene);
        }
        else
        {
            AsyncOperationHandle<SceneInstance> handle = Addressables.LoadSceneAsync(address, loadSceneMode);

            handle.Completed += (operation) =>
            {
                if (operation.Status == AsyncOperationStatus.Succeeded)
                {
                    m_sceneHandles[address] = operation;
                    callBack(operation.Result.Scene);
                }
                else
                {
                    Debug.LogError($"异步加载场景失败！address:{address}");
                }
            };
        }
    }

    /// <summary>
    /// 卸载资源
    /// </summary>
    public void UnLoadAsset()
    {
        if (m_gameObjectHandles != null && m_gameObjectHandles.Count > 0)
        {
            foreach (var item in m_gameObjectHandles)
            {
                item.Value.Release();
            }

            m_gameObjectHandles.Clear();
        }

        if (m_spriteHandles != null && m_spriteHandles.Count > 0)
        {
            foreach (var item in m_spriteHandles)
            {
                item.Value.Release();
            }

            m_spriteHandles.Clear();
        }

        if (m_spriteAtlasHandles != null && m_spriteAtlasHandles.Count > 0)
        {
            foreach (var item in m_spriteAtlasHandles)
            {
                item.Value.Release();
            }

            m_spriteAtlasHandles.Clear();
        }

        if (m_binAssetHandles != null && m_binAssetHandles.Count > 0)
        {
            foreach (var item in m_binAssetHandles)
            {
                item.Value.Release();
            }

            m_binAssetHandles.Clear();
        }

        if (m_textAssetHandles != null && m_textAssetHandles.Count > 0)
        {
            foreach (var item in m_textAssetHandles)
            {
                item.Value.Release();
            }

            m_textAssetHandles.Clear();
        }

        if (m_audioClipHandles != null && m_audioClipHandles.Count > 0)
        {
            foreach (var item in m_audioClipHandles)
            {
                item.Value.Release();
            }

            m_audioClipHandles.Clear();
        }

        if (m_materialHandles != null && m_materialHandles.Count > 0)
        {
            foreach (var item in m_materialHandles)
            {
                item.Value.Release();
            }

            m_materialHandles.Clear();
        }
    }

    /// <summary>
    /// 卸载场景
    /// </summary>
    public void UnLoadScene(string address)
    {
        UnLoadAsset();

        if (m_sceneHandles == null || m_sceneHandles.Count <= 0 || !m_sceneHandles.ContainsKey(address))
        {
            return;
        }

        var handle1 = SceneManager.UnloadSceneAsync(m_sceneHandles[address].Result.Scene);

        handle1.completed += (operation) =>
        {
            if (!operation.isDone)
            {
                return;
            }

            var handle2 = Addressables.UnloadSceneAsync(m_sceneHandles[address]);

            handle2.Completed += (operation) =>
            {
                if (operation.Status != AsyncOperationStatus.Succeeded)
                {
                    return;
                }

                m_sceneHandles[address].Release();
                m_sceneHandles.Remove(address);
            };
        };
    }
}