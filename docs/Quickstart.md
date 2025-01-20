# Installing the plugin
You can install the plugin off of the epic game's marketplace. New versions of the plugin will be released shortly after the release of each engine with pre-releases available with proof of purchase.

# Install Blender
Install [blender](https://www.blender.org/download/) on your computer if you haven't already. You need installed on your blender to import blend files.
# Project Setup
Once you've installed the plugin you are almost there. In order to fully utilize the plugin there is one more step to carry out. 

Open up Engine Settings > Engine > Interchange (Blender)

Hit the button to add blender interchange's pipelines to your projects interchange settings.

After that you're done and ready to import blend files. Drag a blend file into the content browser and see for yourself.

Optional: Explicitly the blender executable file path. If you don't set it the default install directory will be searched for blender installations. The latest version of blender will be used if you have multiple versions installed.

You can view and edit which paths will be searched by looking at 

# Extra Step - Studio Setup
Interchange settings are PerUserProjectSettings. What that means is that they are not checked in version control and each user can have their own individual settings. If you would like every user to use the same default settings you can apply your local settings by clicking the button in the top-right corner. This will let one person set up the plugin and everyone else use it assuming they have blender installed.