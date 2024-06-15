using UnityEngine;

namespace ExtendedPrefs {
    /// <summary>
    /// Contains an extended list of PlayerPrefs methods for storing values of other types.
    /// </summary>
    public static partial class ExtendedPlayerPrefs {
        /// <summary>
        /// Saves all modified preferences.
        /// Unity saves preferences automatically during OnApplicationQuit().
        /// Note: Since writing the PlayerPrefs can cause hiccups, it is recommended to not call this function during gameplay.
        /// </summary>
        public static void Save() {
            PlayerPrefs.Save();
        }

        /// <summary>
        /// Removes the given key from the PlayerPrefs. If the key does not exist, DeleteKey has no impact.
        /// </summary>
        /// <param name="key">Key.</param>
        public static void DeleteKey(string key) {
            PlayerPrefs.DeleteKey(key);
        }

        /// <summary>
        /// Removes all keys and values from the preferences. Use with caution.
        /// </summary>
        public static void DeleteAll() {
            PlayerPrefs.DeleteAll();
        }

        /// <summary>
        /// Returns true if the given key exists in PlayerPrefs, otherwise returns false.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <returns>If the given key exists in PlayerPrefs.</returns>
        public static bool HasKey(string key) {
            return PlayerPrefs.HasKey(key);
        }

        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetFloat will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        public static float GetFloat(string key, float defaultValue) {
            return PlayerPrefs.GetFloat(key, defaultValue);
        }
        
        /// <summary>
        /// Sets the float value of the preference identified by the given key. 
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Float value to set.</param>
        public static void SetFloat(string key, float value) {
            PlayerPrefs.SetFloat(key, value);
        }

        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetInt will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        public static int GetInt(string key, int defaultValue) {
            return PlayerPrefs.GetInt(key, defaultValue);
        }
        
        /// <summary>
        /// Sets a single integer value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Integer value to set.</param>
        public static void SetInt(string key, int value) {
            PlayerPrefs.SetInt(key, value);
        }

        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetBool will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        public static bool GetBool(string key, bool defaultValue) {
            return GetInt(key, defaultValue ? 1 : 0) != 0;
        }
        
        /// <summary>
        /// Sets a single boolean value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Boolean value to set.</param>
        public static void SetBool(string key, bool value) {
            SetInt(key, value ? 1 : 0);
        }
        
        /// <summary>
        /// Returns the value corresponding to key in the preference file if it exists.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="defaultValue">If key doesn't exist, GetString will return defaultValue.</param>
        /// <returns>Key value or default value.</returns>
        public static string GetString(string key, string defaultValue) {
            return PlayerPrefs.GetString(key, defaultValue);
        }
        
        /// <summary>
        /// Sets a single string value for the preference identified by the given key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">String value to set.</param>
        public static void SetString(string key, string value) {
            PlayerPrefs.SetString(key, value);
        }
    }
}