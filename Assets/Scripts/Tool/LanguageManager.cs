using UnityEngine;

public static class LanguageManager
{
    public static string Language
    {
        get
        {
            string language = PlayerPrefs.GetString(Application.productName + "_LanguageName", Application.systemLanguage.ToString());

            if(language == "ChineseSimplified" || language ==  "ChineseTraditional")
            {
                return "Chinese";
            }

            return language;
        }
    }

    public static void SetLanguage(int index = 0)
    {
        if (index == 1)
        {
            PlayerPrefs.SetString(Application.productName + "_LanguageName", "Chinese");
        }
        else if (index == 2)
        {
            PlayerPrefs.SetString(Application.productName + "_LanguageName", "English");
        }
        else
        {
            PlayerPrefs.SetString(Application.productName + "_LanguageName", Application.systemLanguage.ToString());
        }

        CoroutineManager.Instance.InvokeRestartGame();
    }
}