using UnityEngine;

namespace ExtendedPrefs {
    public static partial class ExtendedPlayerPrefs {
        private const string VECTOR_X_PREF_NAME_POSTFIX = "_x";
        private const string VECTOR_Y_PREF_NAME_POSTFIX = "_y";
        private const string VECTOR_Z_PREF_NAME_POSTFIX = "_z";
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetVector2 will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        public static Vector2 GetVector2(string key, Vector2 defaultValue) {
            var x = GetFloat(key + VECTOR_X_PREF_NAME_POSTFIX, defaultValue.x);
            var y = GetFloat(key + VECTOR_Y_PREF_NAME_POSTFIX, defaultValue.y);
            return new Vector2(x, y);
        }

        /// <summary>
        /// Sets a single Vector2 value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Vector2 value to set.</param>
        public static void SetVector2(string key, Vector2 value) {
            SetFloat(key + VECTOR_X_PREF_NAME_POSTFIX, value.x);
            SetFloat(key + VECTOR_Y_PREF_NAME_POSTFIX, value.y);
        }
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetVector3 will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        public static Vector3 GetVector3(string key, Vector3 defaultValue) {
            var x = GetFloat(key + VECTOR_X_PREF_NAME_POSTFIX, defaultValue.x);
            var y = GetFloat(key + VECTOR_Y_PREF_NAME_POSTFIX, defaultValue.y);
            var z = GetFloat(key + VECTOR_Z_PREF_NAME_POSTFIX, defaultValue.z);
            return new Vector3(x, y, z);
        }

        /// <summary>
        /// Sets a single Vector3 value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Vector3 value to set.</param>
        public static void SetVector3(string key, Vector3 value) {
            SetFloat(key + VECTOR_X_PREF_NAME_POSTFIX, value.x);
            SetFloat(key + VECTOR_Y_PREF_NAME_POSTFIX, value.y);
            SetFloat(key + VECTOR_Z_PREF_NAME_POSTFIX, value.z);
        }
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetVector2Int will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        public static Vector2Int GetVector2Int(string key, Vector2Int defaultValue) {
            var x = GetInt(key + VECTOR_X_PREF_NAME_POSTFIX, defaultValue.x);
            var y = GetInt(key + VECTOR_Y_PREF_NAME_POSTFIX, defaultValue.y);
            return new Vector2Int(x, y);
        }

        /// <summary>
        /// Sets a single Vector2Int value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Vector2Int value to set.</param>
        public static void SetVector2Int(string key, Vector2Int value) {
            SetInt(key + VECTOR_X_PREF_NAME_POSTFIX, value.x);
            SetInt(key + VECTOR_Y_PREF_NAME_POSTFIX, value.y);
        }
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetVector3Int will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        public static Vector3Int GetVector3Int(string key, Vector3Int defaultValue) {
            var x = GetInt(key + VECTOR_X_PREF_NAME_POSTFIX, defaultValue.x);
            var y = GetInt(key + VECTOR_Y_PREF_NAME_POSTFIX, defaultValue.y);
            var z = GetInt(key + VECTOR_Z_PREF_NAME_POSTFIX, defaultValue.z);
            return new Vector3Int(x, y, z);
        }

        /// <summary>
        /// Sets a single Vector3Int value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Vector3Int value to set.</param>
        public static void SetVector3Int(string key, Vector3Int value) {
            SetInt(key + VECTOR_X_PREF_NAME_POSTFIX, value.x);
            SetInt(key + VECTOR_Y_PREF_NAME_POSTFIX, value.y);
            SetInt(key + VECTOR_Z_PREF_NAME_POSTFIX, value.z);
        }
    }
}