using UnityEngine;

namespace ExtendedPrefs {
    public static partial class ExtendedPlayerPrefs {
        private const string COLOR_RED_PREF_NAME_POSTFIX = "_r";
        private const string COLOR_GREEN_PREF_NAME_POSTFIX = "_g";
        private const string COLOR_BLUE_PREF_NAME_POSTFIX = "_b";
        private const string COLOR_ALPHA_PREF_NAME_POSTFIX = "_a";
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetColor will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        public static Color GetColor(string key, Color defaultValue) {
            var r = GetFloat(key + COLOR_RED_PREF_NAME_POSTFIX, defaultValue.r);
            var g = GetFloat(key + COLOR_GREEN_PREF_NAME_POSTFIX, defaultValue.g);
            var b = GetFloat(key + COLOR_BLUE_PREF_NAME_POSTFIX, defaultValue.b);
            var a = GetFloat(key + COLOR_ALPHA_PREF_NAME_POSTFIX, defaultValue.a);
            
            return new Color(r, g, b, a);
        }

        /// <summary>
        /// Sets a single color value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Color value to set.</param>
        public static void SetColor(string key, Color value) {
            SetFloat(key + COLOR_RED_PREF_NAME_POSTFIX, value.r);
            SetFloat(key + COLOR_GREEN_PREF_NAME_POSTFIX, value.g);
            SetFloat(key + COLOR_BLUE_PREF_NAME_POSTFIX, value.b);
            SetFloat(key + COLOR_ALPHA_PREF_NAME_POSTFIX, value.a);
        }
    }
}