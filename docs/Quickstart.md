# Quickstart
This is the quickstart guide for getting up and running as quickly as possible.
# Install the Plugin
You can install the plugin from [Fab](https://www.fab.com/) which is unreal engine's official marketplace. New versions of the plugin will be released shortly after each official engine with pre-releases available with proof of purchase in our company's discord. We're generally working off of the latest engine version so expect speedy updates.
# Install Blender
Install [blender](https://www.blender.org/download/) on your computer if you haven't already. You need installed on your blender to import blend files.

This plugin was designed for the newest version of blender (4.3 at time of writing) and will be updated for all new version of blender. It is backwards compatible to some extent and is likely forwards compatible. See note at end.
# Importing
You can now import blend files just like any other file. As you can see it's as simple as dragging the file you want. No more fiddling with nobs. Just drag and drop and continue making your game.
![[UnrealEditor_IBYj70lrvc.gif]]


The full list of features can be found [[Features|here]]. If you would like to see the files we are using to test this plugin and compare setups you can view our [sample repository](https://github.com/Timeless-Tower/blender-interchange-samples).


# Older Versions of Blender
This plugin has been backported back to 3.0 and can actually be used for versions as far back as 2.80 if you change the translator settings to use fbx as the intermediate file type to extract information from blender.

If you use an older version of blender you may see discrepancies not present with the latest version of blender. Older versions of blender have less advanced exporters for fbx and usd which is used to extract information from unreal engine. It's worth upgrading to the newest version of blender if you are able to. 

You can set unreal to use a specific version of blender under Edit > Project Settings > Engine > Interchange (Blender). If no path is specified it will search a set of specified paths where blender is usually installed and try to use the latest version of blender found. You can modify the paths that are searched for in the settings.