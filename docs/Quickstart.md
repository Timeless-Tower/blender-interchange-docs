# Installing the plugin
You can install the plugin from [Fab](https://www.fab.com/) which is unreal engine's official marketplace. New versions of the plugin will be released shortly after each official engine with pre-releases available with proof of purchase in our company's discord. We're generally working off of the latest engine version so expect speedy updates.
# Install Blender
Install [blender](https://www.blender.org/download/) on your computer if you haven't already. You need installed on your blender to import blend files.
# Project Setup
Once you've installed the plugin you're nearly done but there is one more important step that you should not skip. This step only needs to be done once per project

Open up Engine Settings > Engine > Interchange (Blender)
Hit the button to add blender interchange's pipelines to your projects interchange settings. This button modifies your project settings in one click to use the plugin's settings.
After that you're done and ready to import blend files. 



After you apply the settings you can verify they were applied by going to Engine Settings > Engine > Interchange. The project settings should now include blender specific pipelines giving the plugin better control than the out of the box settings allow. This step is necessary to get support for some blender features such as morph targets and static mesh animations.


# Extra Step - Blender Path
If you don't explicitly set a path for your computers blender installation, the path will be deduced and the latest version found will be used. If you are experiencing issues or would like a specific version of blender used you can set the path to blender here.

You can also view and edit which paths are being searched for blend files. These paths vary per operating systems.

# Extra Step - Studio Setup
Interchange settings are PerUserProjectSettings. What that means is that they are not checked in version control and each user can have their own individual settings. If you would like every user to use the same default settings you can apply your local settings by clicking the button in the top-right corner. This will let one person set up the plugin and everyone else use it assuming they have blender installed.