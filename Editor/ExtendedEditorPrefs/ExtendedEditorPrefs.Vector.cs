using UnityEngine;

namespace ExtendedPrefs.Editor {
    public static partial class ExtendedEditorPrefs {
        private const string VECTOR_X_PREF_NAME_POSTFIX = "_x";
        private const string VECTOR_Y_PREF_NAME_POSTFIX = "_y";
        private const string VECTOR_Z_PREF_NAME_POSTFIX = "_z";
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Name of key to read value from.</param>
        /// <param name="defaultValue">Value to return if the key is not in the storage.</param>
        /// <returns>The value stored in the preference file or the defaultValue if the
        /// requested key does not exist.</returns>
        public static Vector2 GetVector2(string key, Vector2 defaultValue) {
            var x = GetFloat(key + VECTOR_X_PREF_NAME_POSTFIX, defaultValue.x);
            var y = GetFloat(key + VECTOR_Y_PREF_NAME_POSTFIX, defaultValue.y);
            return new Vector2(x, y);
        }

        /// <summary>
        /// Sets the value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Name of key to write value into.</param>
        /// <param name="value">Value to write into the storage.</param>
        public static void SetVector2(string key, Vector2 value) {
            SetFloat(key + VECTOR_X_PREF_NAME_POSTFIX, value.x);
            SetFloat(key + VECTOR_Y_PREF_NAME_POSTFIX, value.y);
        }
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Name of key to read value from.</param>
        /// <param name="defaultValue">Value to return if the key is not in the storage.</param>
        /// <returns>The value stored in the preference file or the defaultValue if the
        /// requested key does not exist.</returns>
        public static Vector3 GetVector3(string key, Vector3 defaultValue) {
            var x = GetFloat(key + VECTOR_X_PREF_NAME_POSTFIX, defaultValue.x);
            var y = GetFloat(key + VECTOR_Y_PREF_NAME_POSTFIX, defaultValue.y);
            var z = GetFloat(key + VECTOR_Z_PREF_NAME_POSTFIX, defaultValue.z);
            return new Vector3(x, y, z);
        }

        /// <summary>
        /// Sets the value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Name of key to write value into.</param>
        /// <param name="value">Value to write into the storage.</param>
        public static void SetVector3(string key, Vector3 value) {
            SetFloat(key + VECTOR_X_PREF_NAME_POSTFIX, value.x);
            SetFloat(key + VECTOR_Y_PREF_NAME_POSTFIX, value.y);
            SetFloat(key + VECTOR_Z_PREF_NAME_POSTFIX, value.z);
        }
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Name of key to read value from.</param>
        /// <param name="defaultValue">Value to return if the key is not in the storage.</param>
        /// <returns>The value stored in the preference file or the defaultValue if the
        /// requested key does not exist.</returns>
        public static Vector2Int GetVector2Int(string key, Vector2Int defaultValue) {
            var x = GetInt(key + VECTOR_X_PREF_NAME_POSTFIX, defaultValue.x);
            var y = GetInt(key + VECTOR_Y_PREF_NAME_POSTFIX, defaultValue.y);
            return new Vector2Int(x, y);
        }

        /// <summary>
        /// Sets the value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Name of key to write value into.</param>
        /// <param name="value">Value to write into the storage.</param>
        public static void SetVector2Int(string key, Vector2Int value) {
            SetInt(key + VECTOR_X_PREF_NAME_POSTFIX, value.x);
            SetInt(key + VECTOR_Y_PREF_NAME_POSTFIX, value.y);
        }
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Name of key to read value from.</param>
        /// <param name="defaultValue">Value to return if the key is not in the storage.</param>
        /// <returns>The value stored in the preference file or the defaultValue if the
        /// requested key does not exist.</returns>
        public static Vector3Int GetVector3Int(string key, Vector3Int defaultValue) {
            var x = GetInt(key + VECTOR_X_PREF_NAME_POSTFIX, defaultValue.x);
            var y = GetInt(key + VECTOR_Y_PREF_NAME_POSTFIX, defaultValue.y);
            var z = GetInt(key + VECTOR_Z_PREF_NAME_POSTFIX, defaultValue.z);
            return new Vector3Int(x, y, z);
        }

        /// <summary>
        /// Sets the value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Name of key to write value into.</param>
        /// <param name="value">Value to write into the storage.</param>
        public static void SetVector3Int(string key, Vector3Int value) {
            SetInt(key + VECTOR_X_PREF_NAME_POSTFIX, value.x);
            SetInt(key + VECTOR_Y_PREF_NAME_POSTFIX, value.y);
            SetInt(key + VECTOR_Z_PREF_NAME_POSTFIX, value.z);
        }
    }
}