# Welcome
This is the user guide for blender interchange - a tool for importing data from blender into Unreal Engine 5 as simply as possible. With this tool you can import .blend files by simply dragging and dropping them into the content browser. No more fiddling with export settings and manual export processes. 

![[UnrealEditor_IBYj70lrvc.gif]]

Our goal is to support a seamless transfer of assets from blender to unreal while still offering fine control. We have implemented support for a wide variety of different [[Importing Animations|meshes types and animations]]. If you're ready to get started check out our [[Quickstart|quickstart guide]]

# Why Interchange?
Blender Interchange is built on top of Unreal Engine's Interchange framework - which is becoming the new standard for importing content in the engine as of the 5.5 release. 

Interchange is a fully redesigned import flow that allows users to:
- Save pipeline configuration settings as preset pipeline stacks for different workflows
- Apply custom logic at any stage of the import process through blueprint, python or c++
- Tweak the export process to their current game's needs
- Assign imported content to folders

You can learn more about interchange by watching epic's [video demonstration](https://www.youtube.com/watch?v=Oq6KbrqkGnw) or checking out the [interchange demo project](https://dev.epicgames.com/documentation/en-us/unreal-engine/interchange-framework-in-unreal-engine). In the demo they show off advanced features like using unreal's geometry script to apply mirror modifiers on import. You could also do things like generate and assign collision.