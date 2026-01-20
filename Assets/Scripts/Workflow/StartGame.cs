using UnityEngine.Localization.Settings;

public class StartGame : IStateNode
{
    private StateMachine m_machine;

    public void OnCreate(StateMachine machine)
    {
        m_machine = machine;
    }

    public void OnEnter()
    {
        ClearHandle();
        Play();
    }

    public void OnExit()
    {

    }

    public void OnUpdate()
    {

    }

    /// <summary>
    /// 释放所有句柄
    /// </summary>
    private void ClearHandle()
    {
        var handleList = m_machine.GetAllBlackboardValue();
        if (handleList.Count > 0)
        {
            foreach (var item in handleList)
            {
                item.Value.Invoke();
            }
        }
    }

    /// <summary>
    /// 开始游戏
    /// </summary>
    private async void Play()
    {
        GameManager.Instance.InvokeCSEventCallBack("Launcher_ShowTips", "初始化本地化系统");

        await LocalizationSettings.InitializationOperation.Task;

        GameManager.Instance.InvokeCSEventCallBack("Launcher_ShowTips", "初始化本地化系统，成功！");

        LanguageManager.Instance.SetLanguageIndex(LanguageManager.Instance.LanguageIndex, false);
        SdkManager.Instance.InitTapTapSdkOptions();
        MessageNetManager.Instance.Reset();

        GameManager.Instance.InvokeCSEventCallBack("Launcher_ShowTips", "开始游戏");

        AddressablesManager.Instance.PreLoadLuaBytes(() =>
        {
            LuaManager.Instance.Reset();
            GameManager.Instance.InvokeCSEventCallBack("Launcher_StartGame");
        });
    }
}