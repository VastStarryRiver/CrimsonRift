using UnityEngine;
using XLua;



public class PrefabInstance : MonoBehaviour
{
    private LuaTable m_luaTable = null;
    private LuaFunction m_awakeFunc = null;
    private LuaFunction m_onEnableFunc = null;
    private LuaFunction m_startFunc = null;
    private LuaFunction m_updateFunc = null;
    private LuaFunction m_onDisableFunc = null;
    private LuaFunction m_onDestroyFunc = null;
    private float m_time = 0;



    private void Awake()
    {
        LuaFunction getFunc = LuaManager.Instance.UIManager.Get<LuaFunction>("GetUIPanel");
        LuaTable luaClass = getFunc?.Call(gameObject.name)[0] as LuaTable;

        if (luaClass != null)
        {
            m_luaTable = luaClass;
            m_awakeFunc = (LuaFunction)m_luaTable["Awake"];
            m_onEnableFunc = (LuaFunction)m_luaTable["OnEnable"];
            m_startFunc = (LuaFunction)m_luaTable["Start"];
            m_updateFunc = (LuaFunction)m_luaTable["Update"];
            m_onDisableFunc = (LuaFunction)m_luaTable["OnDisable"];
            m_onDestroyFunc = (LuaFunction)m_luaTable["OnDestroy"];
            m_luaTable["gameObject"] = gameObject;
        }

        if (m_awakeFunc != null)
        {
            m_awakeFunc.Call(this);
        }
    }

    private void OnEnable()
    {
        if (m_onEnableFunc != null)
        {
            m_onEnableFunc.Call();
        }
    }

    private void Start()
    {
        if (m_startFunc != null)
        {
            m_startFunc.Call();
        }
    }

    private void Update()
    {
        m_time += Time.deltaTime;

        if (m_updateFunc != null)
        {
            m_updateFunc.Call(m_time);
        }
    }

    private void OnDisable()
    {
        if (m_luaTable == null)
        {
            return;
        }

        if (m_onDisableFunc != null)
        {
            m_onDisableFunc.Call();
        }
    }

    private void OnDestroy()
    {
        if (m_luaTable == null)
        {
            return;
        }

        if (m_onDestroyFunc != null)
        {
            m_onDestroyFunc.Call();
        }

        LuaFunction removeFunc = LuaManager.Instance.UIManager?.Get<LuaFunction>("RemoveUIPanel");
        removeFunc?.Call(gameObject.name);
    }



    public LuaTable GetLuaTable()
    {
        return m_luaTable;
    }

    public float GetTime()
    {
        return m_time;
    }
}