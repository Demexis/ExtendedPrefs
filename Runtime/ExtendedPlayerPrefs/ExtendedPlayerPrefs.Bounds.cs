using UnityEngine;

namespace ExtendedPrefs {
    public static partial class ExtendedPlayerPrefs {
        private const string BOUNDS_CENTER_PREF_NAME_POSTFIX = "_center";
        private const string BOUNDS_POSITION_PREF_NAME_POSTFIX = "_position";
        private const string BOUNDS_SIZE_PREF_NAME_POSTFIX = "_size";
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetBounds will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        public static Bounds GetBounds(string key, Bounds defaultValue) {
            var center = GetVector3(key + BOUNDS_CENTER_PREF_NAME_POSTFIX, defaultValue.center);
            var size = GetVector3(key + BOUNDS_SIZE_PREF_NAME_POSTFIX, defaultValue.size);
            return new Bounds(center, size);
        }

        /// <summary>
        /// Sets a single bounds value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Bounds value to set.</param>
        public static void SetBounds(string key, Bounds value) {
            SetVector3(key + BOUNDS_CENTER_PREF_NAME_POSTFIX, value.center);
            SetVector3(key + BOUNDS_SIZE_PREF_NAME_POSTFIX, value.size);
        }
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetBoundsInt will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        public static BoundsInt GetBoundsInt(string key, BoundsInt defaultValue) {
            var position = GetVector3Int(key + BOUNDS_POSITION_PREF_NAME_POSTFIX, defaultValue.position);
            var size = GetVector3Int(key + BOUNDS_SIZE_PREF_NAME_POSTFIX, defaultValue.size);
            return new BoundsInt(position, size);
        }

        /// <summary>
        /// Sets a single integer-bounds value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">BoundsInt value to set.</param>
        public static void SetBoundsInt(string key, BoundsInt value) {
            SetVector3Int(key + BOUNDS_POSITION_PREF_NAME_POSTFIX, value.position);
            SetVector3Int(key + BOUNDS_SIZE_PREF_NAME_POSTFIX, value.size);
        }
    }
}