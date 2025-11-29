using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using System.Collections;
using System.Collections.Generic;

public class CheckResourceUpdates : IStateNode
{
    private StateMachine m_machine;

    public void OnCreate(StateMachine machine)
    {
        m_machine = machine;
    }

    public void OnEnter()
    {
        CheckForResourceUpdates();
    }

    public void OnExit()
    {

    }

    public void OnUpdate()
    {

    }

    /// <summary>
    /// 检查资源更新
    /// </summary>
    private void CheckForResourceUpdates()
    {
        // 获取需要更新的资源大小
        var mainHandle = Addressables.GetDownloadSizeAsync("Preload");

        GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "检查资源更新");

        mainHandle.Completed += (handle) =>
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "检查资源更新，成功！");

                m_machine.SetBlackboardValue("CheckForResourceUpdates", () => {
                    if (handle.IsValid())
                    {
                        handle.Release();
                    }
                });

                if (handle.Result > 0)
                {
                    GameManager.Instance.StartCoroutine(DownloadUpdates());
                }
                else
                {
                    m_machine.ChangeState<StartGame>();
                }
            }
            else
            {
                GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "检查资源更新，失败！");
            }
        };
    }

    /// <summary>
    /// 下载资源
    /// </summary>
    private IEnumerator DownloadUpdates()
    {
        var handle = Addressables.DownloadDependenciesAsync("Preload");

        GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "下载资源中");

        List<long> progress = new List<long>() { 0, handle.GetDownloadStatus().TotalBytes };

        // 监听下载进度
        while (!handle.IsDone)
        {
            progress[0] = handle.GetDownloadStatus().DownloadedBytes;
            GameManager.Instance.InvokeEventCallBack("Launcher_ShowProgress", progress);
            yield return null;
        }

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "下载资源，成功！");
            m_machine.SetBlackboardValue("DownloadUpdates", () => {
                if (handle.IsValid())
                {
                    handle.Release();
                }
            });
            m_machine.ChangeState<StartGame>();
        }
        else
        {
            GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "下载资源，失败！");
        }
    }
}