using NUnit.Framework;

namespace ExtendedPrefs.Test {
    [TestFixture]
    public partial class ExtendedPlayerPrefsTest {
        [Test]
        public void TestPlayerPrefsGetSetFloat() {
            const string FLOAT_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_FLOAT";
            const float DEFAULT_VALUE = 47.5f;
            const float SET_VALUE = 34.5f;

            try {
                var f = ExtendedPlayerPrefs.GetFloat(FLOAT_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, DEFAULT_VALUE);

                ExtendedPlayerPrefs.SetFloat(FLOAT_TEST_PREF_NAME, SET_VALUE);

                f = ExtendedPlayerPrefs.GetFloat(FLOAT_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, SET_VALUE);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(FLOAT_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(FLOAT_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestPlayerPrefsGetSetInt() {
            const string INT_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_INT";
            const int DEFAULT_VALUE = 34;
            const int SET_VALUE = 999;

            try {
                var f = ExtendedPlayerPrefs.GetInt(INT_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, DEFAULT_VALUE);

                ExtendedPlayerPrefs.SetInt(INT_TEST_PREF_NAME, SET_VALUE);

                f = ExtendedPlayerPrefs.GetInt(INT_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, SET_VALUE);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(INT_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(INT_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestPlayerPrefsGetSetBool() {
            const string BOOL_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_BOOL";
            const bool DEFAULT_VALUE = false;
            const bool SET_VALUE = true;

            try {
                var f = ExtendedPlayerPrefs.GetBool(BOOL_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, DEFAULT_VALUE);

                ExtendedPlayerPrefs.SetBool(BOOL_TEST_PREF_NAME, SET_VALUE);

                f = ExtendedPlayerPrefs.GetBool(BOOL_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, SET_VALUE);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(BOOL_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(BOOL_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestPlayerPrefsGetSetString() {
            const string STRING_TEST_PREF_NAME = "EXTENDED_PLAYER_PREFS_TEST_GET_SET_STRING";
            const string DEFAULT_VALUE = "Sus";
            const string SET_VALUE = "Sas";

            try {
                var f = ExtendedPlayerPrefs.GetString(STRING_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, DEFAULT_VALUE);

                ExtendedPlayerPrefs.SetString(STRING_TEST_PREF_NAME, SET_VALUE);

                f = ExtendedPlayerPrefs.GetString(STRING_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, SET_VALUE);
            } catch {
                ExtendedPlayerPrefs.DeleteKey(STRING_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedPlayerPrefs.DeleteKey(STRING_TEST_PREF_NAME);
        }
    }
}