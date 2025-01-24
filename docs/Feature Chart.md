# Overview
Blender Interchange translator supports the following imports from blender to unreal engine.

| Feature                 | USD           | FBX           |
| ----------------------- | ------------- | ------------- |
| Static Meshses          | YES           | YES           |
| Skeletal Meshes         | YES           | YES           |
| Materials               | Limited*      | Limited       |
| Morph Targets           | YES**         | YES**         |
| Skeletal Animations     | YES           | YES           |
| Morph Target Animations | YES**         | YES**         |
| Static Mesh Animations  | YES**         | YES**         |
| Levels                  | Planned\*\*\* | Planned\*\*\* |
\*Materials are created and assigned but will not match any complex material graph created in blender. It is recommended to create materials in unreal separately using unreal's material graph. USD supports MaterialX which is a generic way of exporting material graph information. As of time of writing unreal and blender seem to have limitted support for materialX but supporting material transfer is planned in the future

\*\* Certain features require you to apply our plugin's settings to your project. If this feature is not working refer to QuickStart

\*\*\* Level import is planned for a future release. The current focus is on individual assets in the content browser. In the meantime you can sync your blend scene using something like unreal's USD stage actor. In the future we will support creating level instances from blend files.