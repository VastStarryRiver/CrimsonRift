---@class UIManager
UIManager = {}

local m_allPanel = {}

function UIManager.AddUIPanel(name,panel)
    m_allPanel[name] = panel
end

function UIManager.RemoveUIPanel(name)
    m_allPanel[name] = nil
end

function UIManager.GetUIPanel(name)
    return m_allPanel[name]
end

function UIManager.GetAllUIPanel()
    return m_allPanel
end

function UIManager.CloseAllUIPanel()
    for k, v in pairs(m_allPanel) do
        LuaCallCS.CloseUIPrefabPanel(k)
    end
end