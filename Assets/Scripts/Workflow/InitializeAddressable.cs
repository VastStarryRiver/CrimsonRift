using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class InitializeAddressable : IStateNode
{
    private StateMachine m_machine;

    public void OnCreate(StateMachine machine)
    {
        m_machine = machine;
    }

    public void OnEnter()
    {
        InitializeAsync();
    }

    public void OnExit()
    {

    }

    public void OnUpdate()
    {

    }

    /// <summary>
    /// 初始化Addressable资源管理系统
    /// </summary>
    private void InitializeAsync()
    {
        var mainHandle = Addressables.InitializeAsync();

        GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "初始化资源管理");

        mainHandle.Completed += (handle) =>
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "初始化资源管理，成功！");

                m_machine.SetBlackboardValue("InitializeAsync", () => {
                    if (handle.IsValid())
                    {
                        handle.Release();
                    }
                });

                AddressablesManager.Instance.AsyncLoadBinAsset("WebData.bin", (data) =>
                {
                    string[] webData = ConfigUtils.ReadSafeFile<string>(data.bytes).Split('\n');
                    ConfigUtils.SetWebData(webData);
                    AddressablesManager.Instance.SetWebQuestData();

                    if (ConfigUtils.m_isUpdate)
                    {
                        m_machine.ChangeState<CheckCatalogUpdate>();
                    }
                    else
                    {
                        m_machine.ChangeState<StartGame>();
                    }
                });
            }
            else
            {
                GameManager.Instance.InvokeEventCallBack("Launcher_ShowTips", "初始化资源管理，失败！");
            }
        };
    }
}