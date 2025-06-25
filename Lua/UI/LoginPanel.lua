---@class LoginPanel
local LoginPanel = PrefabClass("LoginPanel")

local gameObject = nil

function LoginPanel.Awake(instance)
    gameObject = instance.gameObject

    LuaCallCS.SetActive(gameObject, "parent/Text_Des", false)
    LuaCallCS.SetActive(gameObject, "parent/Text_Progress", false)
    LuaCallCS.SetActive(gameObject, "parent/Sli_Progress", false)

    LuaCallCS.PlayAnimation(gameObject, nil, "Play", WrapMode.Once, function()
        LuaCallCS.SetSpriteImage(gameObject, "parent/Img_State1", "Atlas02/02_bb_DH6_FunOpen10", true)
        LuaCallCS.SetSpriteImage(gameObject, "parent/Img_State2", "Atlas02/02_bb_DH6_FunOpen11", true)

        LuaCallCS.SetGray(gameObject, "parent/Img_State2")

        LuaCallCS.SetText(gameObject, "parent/Text_Name", LuaCallCS.GetStringByKey(2, "#1BB25F", "？？？"))

        LuaCallCS.AddClickListener(gameObject, "parent/Btn_Login", LoginPanel.Login)

        LuaCallCS.AddClickListener(gameObject, "parent/Img_State1", function()
            LanguageManager.SetLanguage(1)
        end)

        LuaCallCS.AddClickListener(gameObject, "parent/Img_State2", function()
            LanguageManager.SetLanguage(2)
        end)
    end)
end

function LoginPanel.Login()
    SdkMsgManager:Login(function(name)
        LuaCallCS.SetText(gameObject, "parent/Text_Name", name)
    end)
end

return LoginPanel