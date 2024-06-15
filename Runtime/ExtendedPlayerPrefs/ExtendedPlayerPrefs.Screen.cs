using UnityEngine;

namespace ExtendedPrefs {
    public static partial class ExtendedPlayerPrefs {
        private const string RESOLUTION_WIDTH_PREF_NAME_POSTFIX = "_width";
        private const string RESOLUTION_HEIGHT_PREF_NAME_POSTFIX = "_height";
        private const string RESOLUTION_REFRESH_RATE_RATIO_PREF_NAME_POSTFIX = "_refreshRateRatio";
        
        private const string REFRESH_RATE_DENOMINATOR_PREF_NAME_POSTFIX = "_denominator";
        private const string REFRESH_RATE_NUMERATOR_PREF_NAME_POSTFIX = "_numerator";
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetResolution will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
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
        /// Sets a single resolution value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Resolution value to set.</param>
        public static void SetResolution(string key, Resolution value) {
            SetInt(key + RESOLUTION_WIDTH_PREF_NAME_POSTFIX, value.width);
            SetInt(key + RESOLUTION_HEIGHT_PREF_NAME_POSTFIX, value.height);
            SetRefreshRate(key + RESOLUTION_REFRESH_RATE_RATIO_PREF_NAME_POSTFIX, value.refreshRateRatio);
        }

        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetRefreshRate will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        private static RefreshRate GetRefreshRate(string key, RefreshRate defaultValue) {
            var denominator = (uint)GetInt(key + REFRESH_RATE_DENOMINATOR_PREF_NAME_POSTFIX, (int)defaultValue.denominator);
            var numerator = (uint)GetInt(key + REFRESH_RATE_NUMERATOR_PREF_NAME_POSTFIX, (int)defaultValue.numerator);

            return new RefreshRate() {
                denominator = denominator,
                numerator = numerator
            };
        }
        
        /// <summary>
        /// Sets a single refresh-rate value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">RefreshRate value to set.</param>
        private static void SetRefreshRate(string key, RefreshRate value) {
            SetInt(key + REFRESH_RATE_DENOMINATOR_PREF_NAME_POSTFIX, (int)value.denominator);
            SetInt(key + REFRESH_RATE_NUMERATOR_PREF_NAME_POSTFIX, (int)value.numerator);
        }
    }
}