using NUnit.Framework;
using UnityEngine;

namespace ExtendedPrefs.Test {
    public partial class ExtendedPlayerPrefsTest {
        [Test]
        public void TestPlayerPrefsGetSetColor() {
            const string COLOR_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_COLOR";
            var defaultValue = Color.red;
            var setValue = Color.green;

            try {
                var f = ExtendedPlayerPrefs.GetColor(COLOR_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedPlayerPrefs.SetColor(COLOR_TEST_PREF_NAME, setValue);

                f = ExtendedPlayerPrefs.GetColor(COLOR_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(COLOR_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(COLOR_TEST_PREF_NAME);
        }
    }
}