using XLua;
using UnityEngine;
//using WeChatWASM;



public class SdkMsgManager : MonoBehaviour
{
    private void Awake()
    {
        if (DataUtilityManager.m_platform != "Windows")
        {
            // 初始化微信SDK
            //WX.InitSDK((state) => {
            //    if (state == 0)
            //    {
            //        Debug.Log("微信SDK初始化成功");
            //    }
            //    else
            //    {
            //        Debug.LogError("微信SDK初始化失败");
            //    }
            //});
        }
    }



    public void Login(LuaFunction loginCallBack)
    {
        //WX.Login(new LoginOption
        //{
        //    success = (res) => {
        //        Debug.Log($"获取登录code成功: {res.code}");
        //        MessageNetManager.Instance.Send($"Login|{res.code}");
        //    },

        //    fail = (res) => {
        //        Debug.LogError($"登录失败: {res.errMsg}");
        //    }
        //});
    }
}