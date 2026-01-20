using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks.Linq;
using Cysharp.Threading.Tasks;
using UnityEngine;
using XLua;



public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private Dictionary<string, List<Action<object>>> m_csEvent = null;
    private Dictionary<string, List<LuaFunction>> m_luaEvent = null;
    private Dictionary<string, CancellationTokenSource> m_cancellationTokenSources = null;



    private void Awake()
    {
        m_csEvent = new Dictionary<string, List<Action<object>>>();
        m_luaEvent = new Dictionary<string, List<LuaFunction>>();
        m_cancellationTokenSources = new Dictionary<string, CancellationTokenSource>();
        Instance = this;
    }



    public void AddCSEventListener(string key, Action<object> callBack)
    {
        if (!m_csEvent.ContainsKey(key))
        {
            m_csEvent.Add(key, new List<Action<object>>());
        }

        if (!m_csEvent[key].Contains(callBack))
        {
            m_csEvent[key].Add(callBack);
        }
    }

    public void RemoveCSEventListener(string key, Action<object> callBack)
    {
        if (!m_csEvent.ContainsKey(key) || !m_csEvent[key].Contains(callBack))
        {
            return;
        }

        m_csEvent[key].Remove(callBack);

        if (m_csEvent[key].Count <= 0)
        {
            m_csEvent.Remove(key);
        }
    }

    public void InvokeCSEventCallBack(string key, object arg = null)
    {
        if (!m_csEvent.ContainsKey(key) || m_csEvent[key].Count <= 0)
        {
            return;
        }

        int count = m_csEvent[key].Count;

        for (int i = 0; i < count; i++)
        {
            m_csEvent[key][i].Invoke(arg);
        }
    }

    public async void DelayCSCallFrames(string key, Action callBack, int frame)
    {
        if (m_cancellationTokenSources.ContainsKey(key))
        {
            return;
        }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        m_cancellationTokenSources.Add(key, cancellationTokenSource);

        await UniTask.DelayFrame(frame, cancellationToken: m_cancellationTokenSources[key].Token);

        if (cancellationTokenSource.IsCancellationRequested)
        {
            return;
        }

        callBack.Invoke();
    }

    public async void DelayCSCallSeconds(string key, Action callBack, float time)
    {
        if (m_cancellationTokenSources.ContainsKey(key))
        {
            return;
        }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        m_cancellationTokenSources.Add(key, cancellationTokenSource);

        await UniTask.Delay(TimeSpan.FromSeconds(time), cancellationToken: m_cancellationTokenSources[key].Token);

        if (cancellationTokenSource.IsCancellationRequested)
        {
            return;
        }

        callBack.Invoke();
    }

    public async void RepeatingCSCallFrames(string key, Action callBack, int frame = 1)
    {
        if (m_cancellationTokenSources.ContainsKey(key))
        {
            return;
        }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        m_cancellationTokenSources.Add(key, cancellationTokenSource);

        var list = UniTaskAsyncEnumerable.EveryUpdate().WithCancellation(m_cancellationTokenSources[key].Token);
        int frames = frame;

        await foreach (AsyncUnit _ in list)
        {
            frames++;
            if (frames >= frame)
            {
                frames = 0;
                callBack.Invoke();
            }
        }
    }

    public async void RepeatingCSCallSeconds(string key, Action callBack, float time = 1)
    {
        if (m_cancellationTokenSources.ContainsKey(key))
        {
            return;
        }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        m_cancellationTokenSources.Add(key, cancellationTokenSource);

        var list = UniTaskAsyncEnumerable.EveryUpdate().WithCancellation(m_cancellationTokenSources[key].Token);
        float times = time;

        await foreach (AsyncUnit _ in list)
        {
            times += Time.deltaTime;
            if (times >= time)
            {
                times = 0;
                callBack.Invoke();
            }
        }
    }

    public void AddLuaEventListener(string key, LuaFunction callBack)
    {
        if (!m_luaEvent.ContainsKey(key))
        {
            m_luaEvent.Add(key, new List<LuaFunction>());
        }

        if (!m_luaEvent[key].Contains(callBack))
        {
            m_luaEvent[key].Add(callBack);
        }
    }

    public void RemoveLuaEventListener(string key, LuaFunction callBack)
    {
        if (!m_luaEvent.ContainsKey(key) || !m_luaEvent[key].Contains(callBack))
        {
            return;
        }

        m_luaEvent[key].Remove(callBack);

        if (m_luaEvent[key].Count <= 0)
        {
            m_luaEvent.Remove(key);
        }
    }

    public void InvokeLuaEventCallBack(string key, params object[] param)
    {
        if (!m_luaEvent.ContainsKey(key) || m_luaEvent[key].Count <= 0)
        {
            return;
        }

        int count = m_luaEvent[key].Count;

        for (int i = 0; i < count; i++)
        {
            m_luaEvent[key][i].Call(param);
        }
    }

    public async void DelayLuaCallFrames(string key, LuaFunction callBack, int frame)
    {
        if (m_cancellationTokenSources.ContainsKey(key))
        {
            return;
        }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        m_cancellationTokenSources.Add(key, cancellationTokenSource);

        await UniTask.DelayFrame(frame, cancellationToken: m_cancellationTokenSources[key].Token);

        if (cancellationTokenSource.IsCancellationRequested)
        {
            return;
        }

        callBack.Call();
    }

    public async void DelayLuaCallSeconds(string key, LuaFunction callBack, float time)
    {
        if (m_cancellationTokenSources.ContainsKey(key))
        {
            return;
        }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        m_cancellationTokenSources.Add(key, cancellationTokenSource);

        await UniTask.Delay(TimeSpan.FromSeconds(time), cancellationToken: m_cancellationTokenSources[key].Token);

        if (cancellationTokenSource.IsCancellationRequested)
        {
            return;
        }

        callBack.Call();
    }

    public async void RepeatingLuaCallFrames(string key, LuaFunction callBack, int frame = 1)
    {
        if (m_cancellationTokenSources.ContainsKey(key))
        {
            return;
        }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        m_cancellationTokenSources.Add(key, cancellationTokenSource);

        var list = UniTaskAsyncEnumerable.EveryUpdate().WithCancellation(m_cancellationTokenSources[key].Token);
        int frames = frame;

        await foreach (AsyncUnit _ in list)
        {
            frames++;
            if (frames >= frame)
            {
                frames = 0;
                callBack.Call();
            }
        }
    }

    public async void RepeatingLuaCallSeconds(string key, LuaFunction callBack, float time = 1)
    {
        if (m_cancellationTokenSources.ContainsKey(key))
        {
            return;
        }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        m_cancellationTokenSources.Add(key, cancellationTokenSource);

        var list = UniTaskAsyncEnumerable.EveryUpdate().WithCancellation(m_cancellationTokenSources[key].Token);
        float times = time;

        await foreach (AsyncUnit _ in list)
        {
            times += Time.deltaTime;
            if (times >= time)
            {
                times = 0;
                callBack.Call();
            }
        }
    }

    public void CancelInvokeByKey(string key)
    {
        if (!m_cancellationTokenSources.ContainsKey(key))
        {
            return;
        }

        m_cancellationTokenSources[key].Cancel();
        m_cancellationTokenSources[key].Dispose();
        m_cancellationTokenSources.Remove(key);
        Debug.Log(key + "取消调用");
    }
}