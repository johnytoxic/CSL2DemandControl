# Cities: Skylines 2 - Demand Control
Manage the demand in your city.

**WORK IN PROGRESS**

## Installation
Since there is no official mod support yet[^1], this mod relis on the thirdparty modding framework [MelonLoader](https://melonwiki.xyz/#/). MelonLoader is an universal mod framework and toolset for Unity games.

Steps to setup MelonLoder with Cities: Skylines 2:
1. Download the automatic installer: https://github.com/HerpDerpinstine/MelonLoader/releases/latest/download/MelonLoader.Installer.exe
2. Run the installer and select your game directory/exe.
    - by default it is located at `C:\Program Files (x86)\Steam\steamapps\common\Cities Skylines II`
    - you can also right-click the game in your Steam library, then click "Manage" > "Browse local file" to show the installed path.
3. Now click on the "Install" button in the installer.
    - This should have put some files and folders into your game directory. Most importantly the `Mods` folder.

Steps to install this mod:
1. Download the latest `InfiniteDemand.dll` from the [releases](https://github.com/johnytoxic/CSL2DemandControl/releases) (e.g. [`pre-beta0`](https://github.com/johnytoxic/CSL2DemandControl/releases/download/pre-beta0/InfiniteDemand.dll)).
2. Copy the file into the `Mods` folder inside your game folder.

Now start Cities: Skylines 2. The game might crash on first try, but you can simply try again. It always worked the second or third time for me. The mod should automatically been loaded.

## Uninstallation
If you want to disable/uninstall this mod, just delete the file in the `Mods` folder and restart the game.

If you want to uninstall the MelonLoader:
1. Run the automatic installer again.
2. Select your game directory.
3. Now you should be presented with two buttons: "Uninstall" and "Repair". Click "Uninstall"
    - There might still be some files left in the game directory, however MelonLoader no longer interferes with your game files.

## Troubleshooting
This mod is in early development. There might be some bugs or edge-cases which haven't been handled, yet. The demand "system" is much more sophisticated in Cities: Skylines 2 as it was in 1. If you found any bugs or missing features, please report them!

If the game does not start at all or the mod doesn't work (i.e. you don't notice any change in Demand), please check the `MelonLoader\Latest.log` file in your game directory for any errors.

[^1]: https://forum.paradoxplaza.com/forum/threads/updates-on-modding-and-performance-for-cities-skylines-ii.1601865/