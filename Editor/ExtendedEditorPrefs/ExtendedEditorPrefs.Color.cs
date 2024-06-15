using UnityEngine;

namespace ExtendedPrefs.Editor {
    public static partial class ExtendedEditorPrefs {
        private const string COLOR_RED_PREF_NAME_POSTFIX = "_r";
        private const string COLOR_GREEN_PREF_NAME_POSTFIX = "_g";
        private const string COLOR_BLUE_PREF_NAME_POSTFIX = "_b";
        private const string COLOR_ALPHA_PREF_NAME_POSTFIX = "_a";
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Name of key to read value from.</param>
        /// <param name="defaultValue">Value to return if the key is not in the storage.</param>
        /// <returns>The value stored in the preference file or the defaultValue if the
        /// requested key does not exist.</returns>
        public static Color GetColor(string key, Color defaultValue) {
            var r = GetFloat(key + COLOR_RED_PREF_NAME_POSTFIX, defaultValue.r);
            var g = GetFloat(key + COLOR_GREEN_PREF_NAME_POSTFIX, defaultValue.g);
            var b = GetFloat(key + COLOR_BLUE_PREF_NAME_POSTFIX, defaultValue.b);
            var a = GetFloat(key + COLOR_ALPHA_PREF_NAME_POSTFIX, defaultValue.a);
            
            return new Color(r, g, b, a);
        }

        /// <summary>
        /// Sets the value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Name of key to write value into.</param>
        /// <param name="value">Value to write into the storage.</param>
        public static void SetColor(string key, Color value) {
            SetFloat(key + COLOR_RED_PREF_NAME_POSTFIX, value.r);
            SetFloat(key + COLOR_GREEN_PREF_NAME_POSTFIX, value.g);
            SetFloat(key + COLOR_BLUE_PREF_NAME_POSTFIX, value.b);
            SetFloat(key + COLOR_ALPHA_PREF_NAME_POSTFIX, value.a);
        }
    }
}