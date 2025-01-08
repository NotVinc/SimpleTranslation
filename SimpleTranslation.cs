using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace SimpleTranslation
{
    [Serializable]
    public class TranslationString
    {
        public List<Language> languages = new List<Language> { new Language {language = Language.languageEnum.English, text = " " }};

        //Get the correct translated Text
        public string GetLangString()
        {
            string lang = GetLang();
            string foundLangString = string.Empty;
            foreach (Language _language in languages)
            {
                if(_language.language.ToString() == lang)
                {
                    foundLangString = _language.text;
                    return foundLangString;
                }
            }

            if (SimpleTranslationManager.instance.showDebugLogs) Debug.LogWarning($"{lang} wasnt set!");
            foreach (Language _language in languages)
            {
                if (_language.language == SimpleTranslationManager.instance.defaultLang) {
                    foundLangString = _language.text;
                    return foundLangString;
                }
            }

            if (SimpleTranslationManager.instance.showDebugLogs) Debug.LogWarning($"Default Language and {lang} wasnt set!");
            if (languages.Count > 0)
            {
                foundLangString = languages[0].text;
            }
            else
            {
                if (SimpleTranslationManager.instance.showDebugLogs) Debug.LogWarning($"You didnt set any Language.");
            }

            return foundLangString;
        }


        //Set the Current Language
        public void SetLang(string lang)
        {
            PlayerPrefs.SetString("lang", lang);
        }

        //Get the current Language
        public string GetLang()
        {
            string lang = String.Empty;
            if (PlayerPrefs.HasKey("lang"))
            {
                lang = PlayerPrefs.GetString("lang");
            }
            else
            {
                lang = SimpleTranslationManager.instance.defaultLang.ToString();
                PlayerPrefs.SetString("lang", lang);
            }

            return lang;
        }
    }

    [Serializable]
    public class Language
    {
        // Defines all Languages
        public enum languageEnum
        {
            English,
            Spanish,
            Hindi,
            French,
            Arabic,
            Bengali,
            Portuguese,
            Russian,
            Japanese,
            Korean,
            Italian,
            Turkish,
            Swahili,
            Vietnamese,
            Urdu,
            Thau,
            Dutch,
            Polish,
            Greek,
            Hebrew
            
        }

        // Defines the current Language
        public languageEnum language;
        // Defines the translation in the Chosen Language
        [Tooltip("This Text is gonna get displayed when the Language above got selected")][TextArea(3, 20)] public string text;
    }
}