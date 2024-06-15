using NUnit.Framework;
using UnityEngine;

namespace ExtendedPrefs.Test {
    public partial class ExtendedPlayerPrefsTest{
        [Test]
        public void TestPlayerPrefsGetSetVector2() {
            const string VECTOR2_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_VECTOR2";
            var defaultValue = Vector2.left;
            var setValue = Vector2.right;

            try {
                var f = ExtendedPlayerPrefs.GetVector2(VECTOR2_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedPlayerPrefs.SetVector2(VECTOR2_TEST_PREF_NAME, setValue);

                f = ExtendedPlayerPrefs.GetVector2(VECTOR2_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(VECTOR2_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(VECTOR2_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestPlayerPrefsGetSetVector3() {
            const string VECTOR3_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_VECTOR3";
            var defaultValue = Vector3.left;
            var setValue = Vector3.right;

            try {
                var f = ExtendedPlayerPrefs.GetVector3(VECTOR3_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedPlayerPrefs.SetVector3(VECTOR3_TEST_PREF_NAME, setValue);

                f = ExtendedPlayerPrefs.GetVector3(VECTOR3_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(VECTOR3_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(VECTOR3_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestPlayerPrefsGetSetVector2Int() {
            const string VECTOR2_INT_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_VECTOR2_INT";
            var defaultValue = Vector2Int.left;
            var setValue = Vector2Int.right;

            try {
                var f = ExtendedPlayerPrefs.GetVector2Int(VECTOR2_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedPlayerPrefs.SetVector2Int(VECTOR2_INT_TEST_PREF_NAME, setValue);

                f = ExtendedPlayerPrefs.GetVector2Int(VECTOR2_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(VECTOR2_INT_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(VECTOR2_INT_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestPlayerPrefsGetSetVector3Int() {
            const string VECTOR3_INT_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_VECTOR3_INT";
            var defaultValue = Vector3Int.left;
            var setValue = Vector3Int.right;

            try {
                var f = ExtendedPlayerPrefs.GetVector3Int(VECTOR3_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedPlayerPrefs.SetVector3Int(VECTOR3_INT_TEST_PREF_NAME, setValue);

                f = ExtendedPlayerPrefs.GetVector3Int(VECTOR3_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(VECTOR3_INT_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(VECTOR3_INT_TEST_PREF_NAME);
        }
    }
}