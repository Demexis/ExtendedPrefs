using UnityEngine;

namespace ExtendedPrefs.Editor {
    public static partial class ExtendedEditorPrefs {
        private const string RESOLUTION_WIDTH_PREF_NAME_POSTFIX = "_width";
        private const string RESOLUTION_HEIGHT_PREF_NAME_POSTFIX = "_height";
        private const string RESOLUTION_REFRESH_RATE_RATIO_PREF_NAME_POSTFIX = "_refreshRateRatio";
        
        private const string REFRESH_RATE_DENOMINATOR_PREF_NAME_POSTFIX = "_denominator";
        private const string REFRESH_RATE_NUMERATOR_PREF_NAME_POSTFIX = "_numerator";
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Name of key to read value from.</param>
        /// <param name="defaultValue">Value to return if the key is not in the storage.</param>
        /// <returns>The value stored in the preference file or the defaultValue if the
        /// requested key does not exist.</returns>
        public static Resolution GetResolution(string key, Resolution defaultValue) {
            var width = GetInt(key + RESOLUTION_WIDTH_PREF_NAME_POSTFIX, defaultValue.width);
            var height = GetInt(key + RESOLUTION_HEIGHT_PREF_NAME_POSTFIX, defaultValue.height);
            var refreshRateRatio = GetRefreshRate(key + RESOLUTION_REFRESH_RATE_RATIO_PREF_NAME_POSTFIX,
                defaultValue.refreshRateRatio);
            return new Resolution() {
                width = width,
                height = height,
                refreshRateRatio = refreshRateRatio
            };
        }

        /// <summary>
        /// Sets the value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Name of key to write value into.</param>
        /// <param name="value">Value to write into the storage.</param>
        public static void SetResolution(string key, Resolution value) {
            SetInt(key + RESOLUTION_WIDTH_PREF_NAME_POSTFIX, value.width);
            SetInt(key + RESOLUTION_HEIGHT_PREF_NAME_POSTFIX, value.height);
            SetRefreshRate(key + RESOLUTION_REFRESH_RATE_RATIO_PREF_NAME_POSTFIX, value.refreshRateRatio);
        }

        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Name of key to read value from.</param>
        /// <param name="defaultValue">Value to return if the key is not in the storage.</param>
        /// <returns>The value stored in the preference file or the defaultValue if the
        /// requested key does not exist.</returns>
        private static RefreshRate GetRefreshRate(string key, RefreshRate defaultValue) {
            var denominator = (uint)GetInt(key + REFRESH_RATE_DENOMINATOR_PREF_NAME_POSTFIX, (int)defaultValue.denominator);
            var numerator = (uint)GetInt(key + REFRESH_RATE_NUMERATOR_PREF_NAME_POSTFIX, (int)defaultValue.numerator);

            return new RefreshRate() {
                denominator = denominator,
                numerator = numerator
            };
        }
        
        /// <summary>
        /// Sets the value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Name of key to write value into.</param>
        /// <param name="value">Value to write into the storage.</param>
        private static void SetRefreshRate(string key, RefreshRate value) {
            SetInt(key + REFRESH_RATE_DENOMINATOR_PREF_NAME_POSTFIX, (int)value.denominator);
            SetInt(key + REFRESH_RATE_NUMERATOR_PREF_NAME_POSTFIX, (int)value.numerator);
        }
    }
}