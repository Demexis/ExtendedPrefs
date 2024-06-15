using NUnit.Framework;
using UnityEngine;

namespace ExtendedPrefs.Test {
    public partial class ExtendedPlayerPrefsTest {
        [Test]
        public void TestPlayerPrefsGetSetBounds() {
            const string BOUNDS_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_BOUNDS";
            var defaultValue = new Bounds(Vector3.zero, Vector3.one);
            var setValue = new Bounds(Vector3.right, new Vector3(5, 4, 3));

            try {
                var f = ExtendedPlayerPrefs.GetBounds(BOUNDS_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedPlayerPrefs.SetBounds(BOUNDS_TEST_PREF_NAME, setValue);

                f = ExtendedPlayerPrefs.GetBounds(BOUNDS_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(BOUNDS_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(BOUNDS_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestPlayerPrefsGetSetBoundsInt() {
            const string BOUNDS_INT_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_BOUNDS_INT";
            var defaultValue = new BoundsInt(Vector3Int.zero, Vector3Int.one);
            var setValue = new BoundsInt(Vector3Int.right, new Vector3Int(5, 4, 3));

            try {
                var f = ExtendedPlayerPrefs.GetBoundsInt(BOUNDS_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, defaultValue);

                ExtendedPlayerPrefs.SetBoundsInt(BOUNDS_INT_TEST_PREF_NAME, setValue);

                f = ExtendedPlayerPrefs.GetBoundsInt(BOUNDS_INT_TEST_PREF_NAME, defaultValue);

                Assert.AreEqual(f, setValue);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(BOUNDS_INT_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(BOUNDS_INT_TEST_PREF_NAME);
        }
    }
}