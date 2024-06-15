# ExtendedPrefs

## Overview
Extended methods for `PlayerPrefs` and `EditorPrefs` in Unity.

This package uses the original `PlayerPrefs` and `EditorPrefs` methods to __support other types__.

**Additional supported types:**
* `Boolean`
* `Vector2` / `Vector3` / `Vector2Int` / `Vector3Int`
* `Bounds` / `BoundsInt`
* `Resolution`
* `Color`

## Install
You can download a unity package from [the latest release](../../releases).

## Usage
To access `PlayerPrefs` extended methods, use the `ExtendedPlayerPrefs` class. For `EditorPrefs`, respectively, use `ExtendedEditorPrefs`.

```cs
public class ScreenResolutionPreference : MonoBehaviour {
    private const string SCREEN_RESOLUTION_PLAYER_PREF_NAME = "SCREEN_RES_PREF";
    
    // Start is called before the first frame update
    private void Start() {
        SetSavedResolution();
    }

    private void SetSavedResolution() {
        var screenResolution = ExtendedPlayerPrefs.GetVector2Int(SCREEN_RESOLUTION_PLAYER_PREF_NAME, GetCurrentResolution());
        Screen.SetResolution(screenResolution.x, screenResolution.y, Screen.fullScreenMode);
    }

    [UsedImplicitly]
    public void SaveCurrentResolution() {
        ExtendedPlayerPrefs.SetVector2Int(SCREEN_RESOLUTION_PLAYER_PREF_NAME, GetCurrentResolution());
    }
    
    private static Vector2Int GetCurrentResolution() {
        return new Vector2Int(Screen.width, Screen.height);
    }
}
```
