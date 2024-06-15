using ExtendedPrefs.Editor;
using NUnit.Framework;
using UnityEngine;

namespace ExtendedPrefs.Test {
    public partial class ExtendedEditorPrefsTest {
        [Test]
        public void TestEditorPrefsGetSetVector2() {
            const string VECTOR2_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_VECTOR2";
            var defaultValue = Vector2.left;
            var setValue = Vector2.right;

            try {
                var f = ExtendedEditorPrefs.GetVector2(VECTOR2_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedEditorPrefs.SetVector2(VECTOR2_TEST_PREF_NAME, setValue);

                f = ExtendedEditorPrefs.GetVector2(VECTOR2_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedEditorPrefs.DeleteKey(VECTOR2_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(VECTOR2_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestEditorPrefsGetSetVector3() {
            const string VECTOR3_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_VECTOR3";
            var defaultValue = Vector3.left;
            var setValue = Vector3.right;

            try {
                var f = ExtendedEditorPrefs.GetVector3(VECTOR3_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedEditorPrefs.SetVector3(VECTOR3_TEST_PREF_NAME, setValue);

                f = ExtendedEditorPrefs.GetVector3(VECTOR3_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedEditorPrefs.DeleteKey(VECTOR3_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(VECTOR3_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestEditorPrefsGetSetVector2Int() {
            const string VECTOR2_INT_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_VECTOR2_INT";
            var defaultValue = Vector2Int.left;
            var setValue = Vector2Int.right;

            try {
                var f = ExtendedEditorPrefs.GetVector2Int(VECTOR2_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedEditorPrefs.SetVector2Int(VECTOR2_INT_TEST_PREF_NAME, setValue);

                f = ExtendedEditorPrefs.GetVector2Int(VECTOR2_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedEditorPrefs.DeleteKey(VECTOR2_INT_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(VECTOR2_INT_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestEditorPrefsGetSetVector3Int() {
            const string VECTOR3_INT_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_VECTOR3_INT";
            var defaultValue = Vector3Int.left;
            var setValue = Vector3Int.right;

            try {
                var f = ExtendedEditorPrefs.GetVector3Int(VECTOR3_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedEditorPrefs.SetVector3Int(VECTOR3_INT_TEST_PREF_NAME, setValue);

                f = ExtendedEditorPrefs.GetVector3Int(VECTOR3_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedEditorPrefs.DeleteKey(VECTOR3_INT_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(VECTOR3_INT_TEST_PREF_NAME);
        }
    }
}