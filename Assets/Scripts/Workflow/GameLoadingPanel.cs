using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameLoadingPanel : MonoBehaviour
{
    private Slider m_sliProgress;
    private TextMeshProUGUI m_textDes;
    private TextMeshProUGUI m_textProgress;



    private void Awake()
    {
        m_sliProgress = gameObject.transform.Find("parent/Sli_Progress").GetComponent<Slider>();
        m_textDes = gameObject.transform.Find("parent/Text_Des").GetComponent<TextMeshProUGUI>();
        m_textProgress = gameObject.transform.Find("parent/Text_Progress").GetComponent<TextMeshProUGUI>();
    }



    public void SetProgress(float nowDownloadNum, float needDownloadNum)
    {
        m_sliProgress.value = nowDownloadNum / needDownloadNum;
        m_textProgress.text = nowDownloadNum + "/" + needDownloadNum;
    }

    public void SetProgress(Dictionary<string, long> currSizeList, long needDownloadSize)
    {
        long currSize = GetCurrDownloadSize(currSizeList);
        m_sliProgress.value = (currSize * 1.00f) / (needDownloadSize * 1.00f);
        m_textProgress.text = LuaCallCS.FormatFileByteSize(currSize) + "/" + LuaCallCS.FormatFileByteSize(needDownloadSize);
    }

    public long GetCurrDownloadSize(Dictionary<string, long> currSizeList)
    {
        long currSize = 0;

        foreach (var item in currSizeList)
        {
            currSize += item.Value;
        }

        return currSize;
    }

    public void SetDes(string text)
    {
        m_textDes.text = text;
    }
}