# Overview
The settings for your import are laid out into 2 independent sections. Both settings affect how the file is processed.

Pipeline Settings - What unreal does with the exported blend file information
Translator Settings - How the blend file is exported from blender and how unreal translates the scene into file agnostic nodes 
# Pipeline Settings
This plugin ships with custom pipelines exposing more settings than unreal does out of the box. Pipelines allow you to control things like if meshes are merged into a single asset or imported as multiple separate assets. Each value can be reset to the pipeline default to by clicking the arrow on the left.

![[Pasted image 20250123180538.png]]

Each pipeline has it's own settings block which can be selected and configured separately. This plugin ships with folder creator pipeline that lets you separate assets in to folders based on their type.
![[UnrealEditor_IMLIXxA0U8.png]]

Pipelines can be saved to assets in your content browser and will appear as a  dropdown after you add the pipeline as an option to the project settings. Project Settings > Engine > Interchange. Make sure you add the settings under the per-translator setting for the Blender Translator.  
![[UnrealEditor_G5XE1uXZvR.png]]
Once you do you should see an option appear under stack presets in the top-left corner of the import dialog.
![[UnrealEditor_6Q2pVYfgEd.png]]

# Translator Settings

This plugin works by exporting either fbx or usd files from blender containing all of the information needed by unreal to create any assets. This is all done through blender's python API and some settings to control that process are exposed under translator settings.

The settings can be opened by hitting the 3 dots in the top right. These settings are slightly hidden and likely to move post unreal engine 5.5. 

![[Pasted image 20250123181506.png]]


The translator settings are laid out by section with some settings being applied regardless of file format and some being file format specific. The default settings are meant to work out of the box but if you find that assets are not being created to your liking feel free to poke around in translator settings

The most important setting you can change is Intermediate File Format. This plugin supports either fbx or usd files. You will see different results for each format because the structure of these files is very different. If you are having issues with USD or FBX try switching to the other format. 

If you have persistent issues hit up our discord for support. https://discord.gg/Zf8xSgg5
# Import Preview
Interchange comes with a preview panel that can be show by hitting preview. This shows you what will be imported if you hit import. In the image I posted a skeletal mesh is being imported with 2 materials and 2 animations.
![[Pasted image 20250123181004.png]]

The preview panel updates whenever translator or pipeline settings are changed and can be a fast way to see what will be imported. Clicking on any item will show more details about the item - some of which are human readable.
# Warnings
- Translator settings persist between imports. Make sure you reset any settings you change as it is possible to break blender export under some configurations. 
- Translator settings cannot be saved to pipelines as of 5.5 like other settings
- Pipeline assets are not blueprints. You cannot create them through the new blueprint menu. You must create them as an asset by right clicking > Misc > Interchange Pipeline Asset
- Assets will be imported with the same pipeline settings on re-import. This is usually desired but something to keep in mind