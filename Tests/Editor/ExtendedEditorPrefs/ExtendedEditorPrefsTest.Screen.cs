using ExtendedPrefs.Editor;
using NUnit.Framework;
using UnityEngine;

namespace ExtendedPrefs.Test {
    public partial class ExtendedEditorPrefsTest {
        [Test]
        public void TestEditorPrefsGetSetResolution() {
            const string RESOLUTION_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_RESOLUTION";
            var defaultValue = new Resolution() {
                height = 640,
                width = 480,
            };
            var setValue = new Resolution() {
                height = 1920,
                width = 1080,
            };

            try {
                var f = ExtendedEditorPrefs.GetResolution(RESOLUTION_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedEditorPrefs.SetResolution(RESOLUTION_TEST_PREF_NAME, setValue);

                f = ExtendedEditorPrefs.GetResolution(RESOLUTION_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedEditorPrefs.DeleteKey(RESOLUTION_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(RESOLUTION_TEST_PREF_NAME);
        }
    }
}