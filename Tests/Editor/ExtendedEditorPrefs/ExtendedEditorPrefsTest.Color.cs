using ExtendedPrefs.Editor;
using NUnit.Framework;
using UnityEngine;

namespace ExtendedPrefs.Test {
    public partial class ExtendedEditorPrefsTest {
        [Test]
        public void TestEditorPrefsGetSetColor() {
            const string COLOR_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_COLOR";
            var defaultValue = Color.red;
            var setValue = Color.green;

            try {
                var f = ExtendedEditorPrefs.GetColor(COLOR_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedEditorPrefs.SetColor(COLOR_TEST_PREF_NAME, setValue);

                f = ExtendedEditorPrefs.GetColor(COLOR_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedEditorPrefs.DeleteKey(COLOR_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(COLOR_TEST_PREF_NAME);
        }
    }
}