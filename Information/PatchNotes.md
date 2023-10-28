<p align="center">
    <a href="#"><img src="https://raw.githubusercontent.com/Deaadman/EternalWeather/release/Images/PatchNotesHeading.png"></a>

---

Welcome to the patch notes for this modification. This document provides a detailed insight into the history of every update made to this project. These patch notes keep you informed about the latest additions, bug fixes, and enhancements with each release. Along with current information, it also brings you insights into upcoming possible ideas.

So please note that the upcoming ideas provided within these patch notes aren't final and are subject to change. They should not be interpreted as a guarantee of implementation, and production may be halted at any time due to reasons such as life and loss of interest.

| Versions: |
| - |
| [vX.X.X](#vxxx) |
| [v1.1.0 - Rebranded Update](#v100---rebranded-update) |
| [v1.0.0 - Initial Launch](#v100---initial-launch) |

---

## vX.X.X:

>**Note:** A bundle of ideas, with no guarantee of implementation.

- Full Weather Control? - Suggested by **Tortuosit**.

---

## v1.1.0 - Rebranded Update:

> Released on the **28th of October 2023**.

### Highlights / Key Changes:
- Rebranded this mod from `Eternal Blizzard` to `Eternal Weather`.
	- Fits in with the changes made below.
- Players can now choose what weather they want to be infinite - Suggested by **FarcryBliss**.
	- They may also choose `Default` to essentially disable the mod.
- Now requires `ModSettings` as a dependant mod.

### Added:
- Added a `Settings.cs` script to the `Utils` folder.
	- Added two methods `OnLoad()` and `OnConfirm()` - each do exactly what the name suggests.
- Added the `OnLoad()` method to the `OnInitializeMelon()` method in the `Main.cs` script.
- Added a new `SetWeatherStage.cs` script.
	- This script contains three methods `WeatherStageChange()`, `ForceDefaultWeather()` and `WeatherStageEnumMapping()`.
	- `WeatherStageChange()` allows for the weather to be changed infinitely, but as a check for the `Default` option.
	- `ForceDefaultWeather()` overrides the current weather with that regions `WeatherSet`.
	- `WeatherStageEnumMapping()` maps the original enum values from `WeatherStage` to our custom one.
- Added a new `WeatherStageSettings.cs` script.
	- This script contains the enum for the weather options which can be chosen in-game.

### Changed / Updated:
- Changed the file and folder structure of the workspace.
	- Renamed the `Miscellaneous` folder to `Utils`.
	- Moved `Main.cs` and `BuildInfo.cs` scripts into the `Utils` folder.
<br></br>
- Updated all the namespaces of the scripts within the `Utils` folder to `namespace EternalWeather.Utils`.

### Removed:
- Removed the previous `PlayerManager.TeleportPlayerAfterSceneLoad()` harmony patch as it was no longer required.

---

## v1.0.0 - Initial Launch:

> Released on the **27th of October 2023**.

### Highlights / Key Changes:
- Blizzards are now persistent across all scenes and saves.

### Added:
- Added a `PlayerManager.TeleportPlayerAfterSceneLoad()` harmony patch under `Main.cs`.
	- This patch is called everytime a new scene is loaded
	- It has `GameManager.GetWeatherTransitionComponent().ForceUnmanagedWeatherStage(WeatherStage.Blizzard, 0f);` in the `Postfix()` to force the weather to change to `Blizzard.`