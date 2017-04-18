using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Localization{
    public static class LocalizationEditorContext {

        #if UNITY_EDITOR
        [MenuItem("GameObject/UI/Localization/LocalizedText")]
        public static GameObject CreateButton(){
            Debug.Log("Create localized");
            GameObject go = new GameObject("LocalizedText");
            go.AddComponent<LocalizedText>();
            go.AddComponent<Text>();
            return go;
        }
        #endif
    }
}
