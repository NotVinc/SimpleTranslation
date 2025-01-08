using SimpleTranslation;
using UnityEngine;

namespace SimpleTranslation
{
    public class SimpleTranslationButton : MonoBehaviour
    {
        //Language that should get set on Button press.
        [Tooltip("The Language that should get set on Button press.")]
        public Language.languageEnum Language;


        public void OnClick()
        {
            PlayerPrefs.SetString("lang", Language.ToString());
        }
    }
}