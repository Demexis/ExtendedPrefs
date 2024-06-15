using ExtendedPrefs.Editor;
using NUnit.Framework;

namespace ExtendedPrefs.Test {
    [TestFixture]
    public partial class ExtendedEditorPrefsTest {
        [Test]
        public void TestEditorPrefsGetSetFloat() {
            const string FLOAT_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_FLOAT";
            const float DEFAULT_VALUE = 47.5f;
            const float SET_VALUE = 34.5f;

            try {
                var f = ExtendedEditorPrefs.GetFloat(FLOAT_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, DEFAULT_VALUE);

                ExtendedEditorPrefs.SetFloat(FLOAT_TEST_PREF_NAME, SET_VALUE);

                f = ExtendedEditorPrefs.GetFloat(FLOAT_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, SET_VALUE);
            } catch {
                ExtendedEditorPrefs.DeleteKey(FLOAT_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(FLOAT_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestEditorPrefsGetSetInt() {
            const string INT_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_INT";
            const int DEFAULT_VALUE = 34;
            const int SET_VALUE = 999;

            try {
                var f = ExtendedEditorPrefs.GetInt(INT_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, DEFAULT_VALUE);

                ExtendedEditorPrefs.SetInt(INT_TEST_PREF_NAME, SET_VALUE);

                f = ExtendedEditorPrefs.GetInt(INT_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, SET_VALUE);
            } catch {
                ExtendedEditorPrefs.DeleteKey(INT_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(INT_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestEditorPrefsGetSetBool() {
            const string BOOL_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_BOOL";
            const bool DEFAULT_VALUE = false;
            const bool SET_VALUE = true;

            try {
                var f = ExtendedEditorPrefs.GetBool(BOOL_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, DEFAULT_VALUE);

                ExtendedEditorPrefs.SetBool(BOOL_TEST_PREF_NAME, SET_VALUE);

                f = ExtendedEditorPrefs.GetBool(BOOL_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, SET_VALUE);
            } catch {
                ExtendedEditorPrefs.DeleteKey(BOOL_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(BOOL_TEST_PREF_NAME);
        }
        
        [Test]
        public void TestEditorPrefsGetSetString() {
            const string STRING_TEST_PREF_NAME = "EXTENDED_EDITOR_PREFS_TEST_GET_SET_STRING";
            const string DEFAULT_VALUE = "Sus";
            const string SET_VALUE = "Sas";

            try {
                var f = ExtendedEditorPrefs.GetString(STRING_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, DEFAULT_VALUE);

                ExtendedEditorPrefs.SetString(STRING_TEST_PREF_NAME, SET_VALUE);

                f = ExtendedEditorPrefs.GetString(STRING_TEST_PREF_NAME, DEFAULT_VALUE);

                Assert.AreEqual(f, SET_VALUE);
            } catch {
                ExtendedEditorPrefs.DeleteKey(STRING_TEST_PREF_NAME);
                throw;
            }
            
            ExtendedEditorPrefs.DeleteKey(STRING_TEST_PREF_NAME);
        }
    }
}