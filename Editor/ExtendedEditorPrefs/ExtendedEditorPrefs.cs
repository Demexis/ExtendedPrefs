using UnityEditor;

namespace ExtendedPrefs.Editor {
    /// <summary>
    /// Contains an extended list of EditorPrefs methods for storing values of other types.
    /// </summary>
    public static partial class ExtendedEditorPrefs {
        /// <summary>
        /// Removes the given key from the EditorPrefs. If it doesnt exists it prints a message.
        /// </summary>
        /// <param name="key">Key.</param>
        public static void DeleteKey(string key) {
            EditorPrefs.DeleteKey(key);
        }

        /// <summary>
        /// Removes all keys and values from the preferences. Use with caution.
        /// </summary>
        public static void DeleteAll() {
            EditorPrefs.DeleteAll();
        }

        /// <summary>
        /// Returns true if the given key exists in EditorPrefs, otherwise returns false.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <returns>If the given key exists in EditorPrefs.</returns>
        public static bool HasKey(string key) {
            return EditorPrefs.HasKey(key);
        }

        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Name of key to read value from.</param>
        /// <param name="defaultValue">Value to return if the key is not in the storage.</param>
        /// <returns>The value stored in the preference file or the defaultValue if the
        /// requested key does not exist.</returns>
        public static float GetFloat(string key, float defaultValue) {
            return EditorPrefs.GetFloat(key, defaultValue);
        }
        
        /// <summary>
        /// Sets the value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Name of key to write value into.</param>
        /// <param name="value">Value to write into the storage.</param>
        public static void SetFloat(string key, float value) {
            EditorPrefs.SetFloat(key, value);
        }

        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Name of key to read value from.</param>
        /// <param name="defaultValue">Value to return if the key is not in the storage.</param>
        /// <returns>The value stored in the preference file or the defaultValue if the
        /// requested key does not exist.</returns>
        public static int GetInt(string key, int defaultValue) {
            return EditorPrefs.GetInt(key, defaultValue);
        }
        
        /// <summary>
        /// Sets the value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Name of key to write value into.</param>
        /// <param name="value">Value to write into the storage.</param>
        public static void SetInt(string key, int value) {
            EditorPrefs.SetInt(key, value);
        }

        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Name of key to read value from.</param>
        /// <param name="defaultValue">Value to return if the key is not in the storage.</param>
        /// <returns>The value stored in the preference file or the defaultValue if the
        /// requested key does not exist.</returns>
        public static bool GetBool(string key, bool defaultValue) {
            return GetInt(key, defaultValue ? 1 : 0) != 0;
        }
        
        /// <summary>
        /// Sets the value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Name of key to write value into.</param>
        /// <param name="value">Value to write into the storage.</param>
        public static void SetBool(string key, bool value) {
            SetInt(key, value ? 1 : 0);
        }
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Name of key to read value from.</param>
        /// <param name="defaultValue">Value to return if the key is not in the storage.</param>
        /// <returns>The value stored in the preference file or the defaultValue if the
        /// requested key does not exist.</returns>
        public static string GetString(string key, string defaultValue) {
            return EditorPrefs.GetString(key, defaultValue);
        }
        
        /// <summary>
        /// Sets the value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Name of key to write value into.</param>
        /// <param name="value">Value to write into the storage.</param>
        public static void SetString(string key, string value) {
            EditorPrefs.SetString(key, value);
        }
    }
}