using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using System.Collections.Generic;

public class CheckCatalogUpdate : IStateNode
{
    private StateMachine m_machine;

    public void OnCreate(StateMachine machine)
    {
        m_machine = machine;
    }

    public void OnEnter()
    {
        SetRemoteCatalogUrl();
    }

    public void OnExit()
    {

    }

    public void OnUpdate()
    {

    }

    /// <summary>
    /// 设置远程目录文件的地址
    /// </summary>
    private void SetRemoteCatalogUrl()
    {
        var mainHandle = Addressables.LoadContentCatalogAsync(ConfigUtils.CatalogPath, true);

        GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "设置远程目录文件的地址");

        mainHandle.Completed += (handle) =>
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "设置远程目录文件的地址，成功！");
                m_machine.SetBlackboardValue("SetRemoteCatalogUrl", () => {
                    if (handle.IsValid())
                    {
                        handle.Release();
                    }
                });
                CheckForCatalogUpdate();
            }
            else
            {
                GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "设置远程目录文件的地址，失败！");
            }
        };
    }

    /// <summary>
    /// 检查本地目录文件是否有更新
    /// </summary>
    private void CheckForCatalogUpdate()
    {
        var mainHandle = Addressables.CheckForCatalogUpdates(false);

        GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "检查本地目录文件是否有更新");

        mainHandle.Completed += (handle) =>
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "检查本地目录文件是否有更新，成功！");

                m_machine.SetBlackboardValue("CheckForCatalogUpdate", () => {
                    if (handle.IsValid())
                    {
                        handle.Release();
                    }
                });

                List<string> updateList = handle.Result;

                if (updateList != null && updateList.Count > 0)
                {
                    CatalogUpdate(updateList);
                }
                else
                {
                    m_machine.ChangeState<CheckResourceUpdates>();
                }
            }
            else
            {
                GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "检查本地目录文件是否有更新，失败！");
            }
        };
    }

    /// <summary>
    /// 更新本地目录文件
    /// </summary>
    /// <param name="updateList"></param>
    private void CatalogUpdate(List<string> updateList)
    {
        var mainHandle = Addressables.UpdateCatalogs(updateList, false);

        GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "更新本地目录文件");

        mainHandle.Completed += (handle) =>
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "更新本地目录文件，成功！");
                m_machine.SetBlackboardValue("CatalogUpdate", () => {
                    if (handle.IsValid())
                    {
                        handle.Release();
                    }
                });
                m_machine.ChangeState<CheckResourceUpdates>();
            }
            else
            {
                GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "更新本地目录文件，失败！");
            }
        };
    }
}