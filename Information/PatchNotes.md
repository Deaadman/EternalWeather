<p align="center">
    <a href="#"><img src="https://raw.githubusercontent.com/Deaadman/EternalBlizzard/release/Images/PatchNotesHeading.png"></a>

---

Welcome to the patch notes for this modification. This document provides a detailed insight into the history of every update made to this project. These patch notes keep you informed about the latest additions, bug fixes, and enhancements with each release. Along with current information, it also brings you insights into upcoming possible ideas.

So please note that the upcoming ideas provided within these patch notes aren't final and are subject to change. They should not be interpreted as a guarantee of implementation, and production may be halted at any time due to reasons such as life and loss of interest.

| Versions: |
| - |
| [vX.X.X](#vxxx) |
| [v1.0.0 - Initial Launch](#v100---initial-launch) |

---

## vX.X.X:

>**Note:** A bundle of ideas, with no guarantee of implementation.

- No further plans as of currently.

---

## v1.0.0 - Initial Launch:

> Released on the **27th of October 2023**.

### Highlights / Key Changes:
- Blizzards are now persistent across all scenes and saves.

### Added:
- Added a `PlayerManager.TeleportPlayerAfterSceneLoad()` harmony patch under `Main.cs`.
	- This patch is called everytime a new scene is loaded
	- It has `GameManager.GetWeatherTransitionComponent().ForceUnmanagedWeatherStage(WeatherStage.Blizzard, 0f);` in the `Postfix()` to force the weather to change to `Blizzard.`