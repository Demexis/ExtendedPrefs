using NUnit.Framework;
using UnityEngine;

namespace ExtendedPrefs.Test {
    public partial class ExtendedPlayerPrefsTest {
        [Test]
        public void TestPlayerPrefsGetSetResolution() {
            const string RESOLUTION_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_RESOLUTION";
            var defaultValue = new Resolution() {
                height = 640,
                width = 480,
            };
            var setValue = new Resolution() {
                height = 1920,
                width = 1080,
            };

            try {
                var f = ExtendedPlayerPrefs.GetResolution(RESOLUTION_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedPlayerPrefs.SetResolution(RESOLUTION_TEST_PREF_NAME, setValue);

                f = ExtendedPlayerPrefs.GetResolution(RESOLUTION_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(RESOLUTION_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(RESOLUTION_TEST_PREF_NAME);
        }
    }
}