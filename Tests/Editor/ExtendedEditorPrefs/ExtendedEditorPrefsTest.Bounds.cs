using ExtendedPrefs.Editor;
using NUnit.Framework;
using UnityEngine;

namespace ExtendedPrefs.Test {
    public partial class ExtendedEditorPrefsTest {
        [Test]
        public void TestEditorPrefsGetSetBounds() {
            const string BOUNDS_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_BOUNDS";
            var defaultValue = new Bounds(Vector3.zero, Vector3.one);
            var setValue = new Bounds(Vector3.right, new Vector3(5, 4, 3));

            try {
                var f = ExtendedEditorPrefs.GetBounds(BOUNDS_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedEditorPrefs.SetBounds(BOUNDS_TEST_PREF_NAME, setValue);

                f = ExtendedEditorPrefs.GetBounds(BOUNDS_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedEditorPrefs.DeleteKey(BOUNDS_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(BOUNDS_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestEditorPrefsGetSetBoundsInt() {
            const string BOUNDS_INT_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_BOUNDS_INT";
            var defaultValue = new BoundsInt(Vector3Int.zero, Vector3Int.one);
            var setValue = new BoundsInt(Vector3Int.right, new Vector3Int(5, 4, 3));

            try {
                var f = ExtendedEditorPrefs.GetBoundsInt(BOUNDS_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedEditorPrefs.SetBoundsInt(BOUNDS_INT_TEST_PREF_NAME, setValue);

                f = ExtendedEditorPrefs.GetBoundsInt(BOUNDS_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedEditorPrefs.DeleteKey(BOUNDS_INT_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(BOUNDS_INT_TEST_PREF_NAME);
        }
    }
}