using UnityEngine;
using XLua;
using System.Collections.Generic;
using System.IO;



public class LuaManager : Singleton<LuaManager>
{
    public LuaEnv m_luaEnv = null;//Lua的虚拟机

    public LuaTable UIManager
    {
        get
        {
            if(m_luaEnv != null)
            {
                return m_luaEnv.Global.Get<LuaTable>("UIManager");
            }
            
            return null;
        }
    }



    public void Play()
    {
        if (m_luaEnv != null)
        {
            return;
        }

        m_luaEnv = new LuaEnv();//虚拟机初始化

        m_luaEnv.AddLoader((ref string path1) => {
            string path2 = $"{DataUtilityManager.m_localRootPath}Lua/{path1}.lua";
            return File.Exists(path2) ? File.ReadAllBytes(path2) : null;
        });

        m_luaEnv.DoString("require('Workflow/Main')");//任意已经添加的搜索路径下的完整lua路径
    }

    public void Stop()
    {
        if (m_luaEnv != null)
        {
            m_luaEnv.Dispose();
            m_luaEnv = null;
        }
    }

    public void Reset()
    {
        Stop();
        Play();
    }
}