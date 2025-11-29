---@class LoginPanel
local LoginPanel = UIClass("LoginPanel")

local gameObject = nil

function LoginPanel.Awake(instance)
    gameObject = instance.gameObject

    Utils.PlayAnimation(gameObject, nil, "Play", WrapMode.Once, function()
        Utils.SetImage(gameObject, "parent/Img_State1", "Atlas02/02_rwtx5")
        Utils.SetImage(gameObject, "parent/Img_State2", "Atlas02/02_rwtx6")

        Utils.SetGray(gameObject, "parent/Img_State2")

        Utils.SetText(gameObject, "parent/Text_Name", Utils.GetetTextByKey("scene_key8", "#1BB25F", "？？？"))--名字：<color={0}>{1}</color>

        Utils.AddClickListener(gameObject, "parent/Btn_Login", LoginPanel.Login)

        Utils.AddClickListener(gameObject, "parent/Img_State1", function()
            LanguageManager:SetLanguageIndex(0)
        end)

        Utils.AddClickListener(gameObject, "parent/Img_State2", function()
            LanguageManager:SetLanguageIndex(1)
        end)
    end)
end

function LoginPanel.Login()
    SdkManager:Login(function(name)
        Utils.SetText(gameObject, "parent/Text_Name", name)
    end)
end

return LoginPanel