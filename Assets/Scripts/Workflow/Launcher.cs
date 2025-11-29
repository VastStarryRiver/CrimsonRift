using System;
using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;



public class Launcher : MonoBehaviour
{
    private GameLoadingPanel m_hotUpdatePanel;



    private void Awake()
    {
        DebugLogTool.InitDebugErrorLog();
        GameObject gameManager = GameObject.Find("GameManager");
        if (gameManager == null)
        {
            gameManager = new GameObject("GameManager");
            gameManager.AddComponent<GameManager>();
        }
        DontDestroyOnLoad(gameManager);
    }

    private void OnEnable()
    {
        GameManager.Instance.AddEventListener("Launcher_ShowTips", ShowTips);
        GameManager.Instance.AddEventListener("Launcher_ShowProgress", ShowProgress);
        GameManager.Instance.AddEventListener("Launcher_StartGame", StartGame);
    }

    private void Start()
    {
        StateMachine stateMachine = new StateMachine(this);
        stateMachine.AddNode<InitializeAddressable>();
        stateMachine.AddNode<CheckCatalogUpdate>();
        stateMachine.AddNode<CheckResourceUpdates>();
        stateMachine.AddNode<StartGame>();

        AsyncCreateStartGameObject(() =>
        {
            if (ConfigUtils.m_isUpdate)
            {
                stateMachine.Play<InitializeAddressable>();
            }
            else
            {
                List<long> progress = new List<long>() { 0, 3000000 };
                GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "演示动画播放中");
                DOVirtual.Float(0, 3000000, 3, (value) =>
                {
                    progress[0] = (long)value;
                    GameManager.Instance.InvokeEventCallBack("Launcher_ShowProgress", progress);
                }).OnComplete(() =>
                {
                    stateMachine.Play<InitializeAddressable>();
                });
            }
        });
    }

    private void OnDisable()
    {
        GameManager.Instance.RemoveEventListener("Launcher_ShowTips", ShowTips);
        GameManager.Instance.RemoveEventListener("Launcher_ShowProgress", ShowProgress);
        GameManager.Instance.RemoveEventListener("Launcher_StartGame", StartGame);
    }



    private void AsyncCreateStartGameObject(Action callBack = null)
    {
        AddressablesManager.Instance.AsyncLoadGameObject("UI_Root.prefab", (asset1) =>
        {
            GameObject go = GameObject.Instantiate<GameObject>(asset1, Vector3.zero, Quaternion.identity);
            go.name = "UI_Root";
            DontDestroyOnLoad(go);
            AddressablesManager.Instance.AsyncLoadGameObject("HotUpdatePanel.prefab", (asset2) =>
            {
                Transform parent = go.transform.Find("Canvas_0/Ts_Panel");
                GameObject go2 = GameObject.Instantiate<GameObject>(asset2, Vector3.zero, Quaternion.identity, parent);
                m_hotUpdatePanel = go2.GetComponent<GameLoadingPanel>();
                AddressablesManager.Instance.AsyncLoadGameObject("SceneGameObject.prefab", (asset3) =>
                {
                    GameObject go = GameObject.Instantiate<GameObject>(asset3, Vector3.zero, Quaternion.identity);
                    go.name = "SceneGameObject";
                    DontDestroyOnLoad(go);
                    callBack?.Invoke();
                });
            });
        });
    }

    private void ShowTips(object arg)
    {
        string tips = arg as string;
        m_hotUpdatePanel.SetDes(tips);
    }

    private void ShowProgress(object arg)
    {
        List<long> progress = arg as List<long>;
        m_hotUpdatePanel.SetProgress(progress[0], progress[1], $"{Utils.FormatFileByteSize(progress[0])}/{Utils.FormatFileByteSize(progress[1])}");
    }

    private void StartGame(object arg)
    {
        GameObject.Destroy(m_hotUpdatePanel.gameObject);
        GameObject.Destroy(gameObject);
    }
}