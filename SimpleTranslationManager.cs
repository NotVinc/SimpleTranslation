using System.Collections.Generic;
using UnityEngine;
namespace SimpleTranslation
{
    public class SimpleTranslationManager : MonoBehaviour
    {
        public static SimpleTranslationManager instance;

        [Header("Settings")]

        [Tooltip("This Language is gonna get set if the Player doesnt changed it and if an Translation is missing.")]
        public Language.languageEnum defaultLang = Language.languageEnum.English;
        [Header("Debug")]
        public bool showDebugLogs = false;

        private void Awake()
        {
            if (instance == null){
                instance = this;
            }else{
                Destroy(this);
            }
            DontDestroyOnLoad(this.gameObject);
            Debug.Log(defaultLang.ToString());
        }

    }
}
