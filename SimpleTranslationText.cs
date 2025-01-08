using System;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

namespace SimpleTranslation
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class SimpleTranslationText : MonoBehaviour
    {
        [Header("Settings")]
        [Tooltip("If true its always Updating the Text and checks if the Language got changed")] public bool checkForChanges = false;
        [Header("Translation strings")]
        public TranslationString TMPText;

        string _lastLang;
        private TextMeshProUGUI _mytext;

        private void Awake()
        {
            _mytext = GetComponent<TextMeshProUGUI>();
            _mytext.text = TMPText.GetLangString();
        }

        private void Update()
        {
            if (checkForChanges && TMPText.GetLang() != _lastLang)
            {
                _mytext.text = TMPText.GetLangString();
            }
        }
    }
}