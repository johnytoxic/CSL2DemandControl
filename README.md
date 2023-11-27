# Cities: Skylines 2 - Demand Control
Manage the demand in your city.

**WORK IN PROGRESS**

This repository contains the following mods:
- [Infinite Demand](./InfiniteDemand/)

## Installation

### Thunderstore App (recommended)
This mod is available on the [Thunderstore](https://thunderstore.io/c/cities-skylines-ii/) mod database. You can use their app to automatically install and update this mod.
1. Download the Thunderstore app: https://www.overwolf.com/app/Thunderstore-Thunderstore_Mod_Manager
    - Follow the installation instructions and launch the app.
    - Select Cities: Skylines 2.
    - Select the default profile.
    - In the settings (bottom left) ensure, all paths to your game files are correct.
2. Next you need to install the [BepInExPack mod](https://thunderstore.io/c/cities-skylines-ii/p/BepInEx/BepInExPack/). On the mod page, click "Install with Mod Manager".
3. Now you can install this mod through the marketplace as well: https://thunderstore.io/c/cities-skylines-ii/p/johnytoxic/Infinite_Demand_Mod/

### Manual
If you don't want to use the Thunderstore app, you can also manually install this mod. Since there is no official mod support yet[^1], this mod relies on the thirdparty modding framework [BepInEx](https://github.com/BepInEx/BepInEx).

Please follow the installation instructions over at https://docs.bepinex.dev/articles/user_guide/installation/index.html to setup BepInEx for Cities: Skylines 2. You need to use version 5 of BepInEx.

Steps to install this mod:
1. Download the latest `InfiniteDemand.dll` from the [releases](https://github.com/johnytoxic/CSL2DemandControl/releases) (e.g. [`pre-beta1`](https://github.com/johnytoxic/CSL2DemandControl/releases/download/pre-beta1/InfiniteDemand.dll)).
2. Copy the file into the `BepInEx\plugins` folder inside your game folder.

## Troubleshooting
This mod is in early development. There might be some bugs or edge-cases which haven't been handled, yet. The demand "system" is much more sophisticated in Cities: Skylines 2 as it was in 1. If you found any bugs or missing features, please report them here: https://github.com/johnytoxic/CSL2DemandControl/issues.

If the game does not start at all or the mod doesn't work (i.e. you don't notice any change in Demand), please check the `BepInEx\LogOutput.log` file in your game directory for any errors.
