# ONI-Modloader Mods
Javisar's Oxygen Not Included Mods for [**ONI-Modloader**](https://github.com/javisar/ONI-Modloader)

[**Forums in Klei**](https://forums.kleientertainment.com/forums/topic/97444-mods-trevices-mods-lair/)


Disclaimers
-----------
* Please DON'T REPORT BUGS you encounter to Klei while mods are active.
* BE AWARE that many of the mods are still a WIP and may fail. If you are having problems use a clean ONI installation and try to test the mods one by one to narrow the error. Then post a issue in github.
* We do not take any responsibility for broken saves or any other damage. Use this software at your own risk.
* If you load a savegame, it requires that you have exactly the same mods when you saved it.

This project uses source code of and is based on:
* https://github.com/zeobviouslyfakeacc/ModLoaderInstaller
* https://github.com/spaar/besiege-modloader
* https://github.com/pardeike/Harmony
* https://forums.kleientertainment.com/topic/81296-mod159-materialcolor-onionpatcher/


**NOTE**: Compiled for **Q1-299745** and ONI-Modloader v0.5.1

**[Report Mod Bugs](https://github.com/javisar/ONI-Modloader-Mods/issues/new/choose)**

**Contribute**: ANY PULL REQUEST IS WELCOME. Check the contributors [here](https://github.com/javisar/ONI-Modloader-Mods/graphs/contributors). 

There are a list of ideas and requested mods [here](https://github.com/javisar/ONI-Modloader/issues).


Mods Installation
-----------------
0. Prerequisites:
   * This mod installation guide ONLY applies to the mods below.
   * Make SURE you're using the latest version from Github main branch.
   * **[ONI-Modloader](https://github.com/javisar/ONI-Modloader#installation) must be installed**
   * Make sure you deleted all previous mod files and its config:
     * Windows: \OxygenNotIncluded\Mods\
	 * Mac: /OxygenNotIncluded/Mods
1. Select the mod you want to install from [HERE](https://github.com/javisar/ONI-Modloader-Mods/tree/master/Mods).
2. Click "Clone or Download" and "Download ZIP" for the current version as the releases may not be up to date.
3. Copy the desired **mod dll file OR mod folder [WITH THE SAME FOLDER STRUCTURE](https://github.com/javisar/ONI-Modloader-Mods/tree/master/.github/folders.png)** into the folder:
   * Windows: \OxygenNotIncluded\Mods\
   * Mac: /OxygenNotIncluded/Mods
4. The main mod config files must be located in:
   * \Mods\\[MOD_NAME]\Config\\[MOD_NAME]State.json
5. **Copy also ONI-Common folder** since many mods use it as a support library.
6. Run the game.
7. **Check for error logs in**:
   * Windows: %USERPROFILE%\AppData\LocalLow\Klei\Oxygen Not Included\\**output_log.txt** 
   * Linux: ~/.config/unity3d/Klei/Oxygen Not Included/**Player.log**
   * MacOS: ~/Library/Logs/Unity/**Player.log**
   * \OxygenNotIncluded\Mods\Mod_Log.txt
   * \OxygenNotIncluded\Mods\\_Logs\
   
Howto Debug
--------------------
* https://github.com/0xd4d/dnSpy/wiki/Debugging-Unity-Games
* https://gist.github.com/jbevain/ba23149da8369e4a966f


ONI-Common
--------------------
| Name  | Description | ONI-Common | Contributors |
| ----- | ----------- | ---------- | ------- |
| **ONI-Common** | **Requieres Mono.Cecil.dll** Common code. Provides config load/save functionality, logger, help tools. | Y | [@fistak](https://github.com/fistak) [@Killface1980](https://github.com/Killface1980) [@javisar](https://github.com/javisar) |


Mods - New Buildings
--------------------
| Name  | Description | ONI-Common | Contributors |
| ----- | ----------- | ---------- | ------- |
| BuildableAETN | Makes the AETN buildable and researchable. 20k Refined Metal. There is no preprint sprite. | N | [@javisar](https://github.com/javisar) |
| FluidWarp | Teleports liquids and gases between places. More at: [HowTo](https://github.com/javisar/ONI-Modloader-Mods/blob/master/Mods/FluidWarp/FluidWarpModHowto.txt) | N | [@javisar](https://github.com/javisar) [@Blindfold](https://github.com/Blindfold) |
| InverseElectrolyzer | Combines hydrogen and oxygen into steam. Gets oxygen from the environment. | N | [@javisar](https://github.com/javisar) |
| InverseElectrolyzerAlt | Combines hydrogen and oxygen into steam. Uses two input conduits instead of getting oxygen from the environment. | N | [@javisar](https://github.com/javisar) |
| ZeroPointModule | A battery that gets unlimited energy from the vacuum. | N | [@javisar](https://github.com/javisar) |


Mods - GUI
--------------------
| Name  | Description | ONI-Common | Contributors |
| ----- | ----------- | ---------- | ------- |
| CameraController | Enable further zoom-outs in play and dev mode. Allows camera to be moved out of world boundaries. | Y | [@Moonkis](https://github.com/Moonkis) [@Killface1980](https://github.com/Killface1980) [@fistak](https://github.com/fistak) [@javisar](https://github.com/javisar)|
| CustomWorld | Enables the player to use custom world sizes. | N | [@Moonkis](https://github.com/Moonkis) [@javisar](https://github.com/javisar) |
| ImprovedGasOverlay | Replaces the oxygen overlay with gas overlay. Also visualizes the density. | Y | [@fistak](https://github.com/fistak) [@Killface1980](https://github.com/Killface1980) [@javisar](https://github.com/javisar) |
| MaterialColor | Adds an overlay option to visualize what a building is made of. Modifies temperature overlay ranges and colors.  More at: [HowTo](https://github.com/javisar/ONI-Modloader-Mods/blob/master/Mods/MaterialColor/MaterialColorHowto.txt) | Y | [@fistak](https://github.com/fistak) [@Killface1980](https://github.com/Killface1980) [@javisar](https://github.com/javisar) |
| SpeedControl | Overwrites the method SpeedControlScreen.OnChange. Fast Speed set to behave like Ultra Speed in debug mode. | N | [@javisar](https://github.com/javisar) |


Mods - Mechanics
--------------------
| Name  | Description | ONI-Common | Contributors |
| ----- | ----------- | ---------- | ------- |
| AllBuildingsDestroyable | Allows to construct on top of Gravitas furniture. | N | [@javisar](https://github.com/javisar) |
| BuildingModifier | Allows to modify building attributes. EXPERIMENTAL. More at: [HowTo](https://github.com/javisar/ONI-Modloader-Mods/blob/master/Mods/BuildingModifier/BuildingModifierHowto.txt) | Y | [@javisar](https://github.com/javisar) |
| FastMode | Duplicants will build and dig very fast. | N | [@javisar](https://github.com/javisar) |
| FluidPhysics | Overwrite some fluids molar mass to make them equal, this produces more mixing. EXPERIMENTAL. (Oxygen, Hydrogen, ChlorineGas, ContaminatedOxygen, Propane, Helium, Methane, CarbonDioxide, Water, DirtyWater, CrudeOil, Petroleum). | N | [@javisar](https://github.com/javisar) |
| InstantResearch | Forces instant research without Debug mode. | N | [@javisar](https://github.com/javisar) |
| NoDamage | Disables various damages in game. Overload, Overheat, boiling, cold, buildings. | Y | [@javisar](https://github.com/javisar) |
| NoFixedTemps | The output fluid temperatures of the machinery depends on the input (Except AirFilter, AlgaeTerraium and PacuCleaner). | N | [@javisar](https://github.com/javisar) |
| RoomSize | Recognizes rooms (count cells) to a room size maximum of 1024. Configures maximum room sizes. | Y | [@javisar](https://github.com/javisar) |
| SuperMiner | Digging drops the complete mass of the cell. | N | [@javisar](https://github.com/javisar) |
| WorldGenReloaded | Changes geysers properties, frequency and allowed zones. EXPERIMENTAL. Don't use small world sizes! More at: [HowTo](https://github.com/javisar/ONI-Modloader-Mods/blob/master/Mods/WorldGenReloaded/WorldGenReloadedHowto.txt) | Y | [@javisar](https://github.com/javisar) |


[Outdated/Deprecated Mods](https://github.com/javisar/ONI-Modloader-Mods/blob/master/Outdated.md)


Downloads
---------
* Choose 'Download or Clone'.
* Put the desired mods into the Mods folder "OxygenNotIncluded\Mods".
* BE SURE to also copy **ALL** required config and icons folders.


