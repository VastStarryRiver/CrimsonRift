---@class PrefabClass
PrefabClass = {}

local class = {}

local componentList = {
    Button = typeof(CS.UnityEngine.UI.Button),
    Image = typeof(CS.UnityEngine.UI.Image),
    RawImage = typeof(CS.UnityEngine.UI.RawImage),
    Slider = typeof(CS.UnityEngine.UI.Slider),
    Toggle = typeof(CS.UnityEngine.UI.Toggle),
    TextMeshProUGUI = typeof(CS.TMPro.TextMeshProUGUI),
}

function class:Init(name)
    self.name = name

    rawset(self,"Close",function ()
        LuaCallCS.CloseUIPrefabPanel(self.name)
    end)
end

local metatable = {
    __call = function(prefabClass,name,parentTable)
        parentTable = parentTable or {}

        parentTable.__index = function(self, key)
            local componentType = componentList[key]

            if componentType then
                local component = self.transform:GetComponent(componentType)
                rawset(self, key, component)
                return component
            end

            return rawget(class,key)
        end

        local table = setmetatable({}, parentTable)

        table:Init(name)

        return table
    end
}

setmetatable(PrefabClass, metatable)