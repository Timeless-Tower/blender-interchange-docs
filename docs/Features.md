# Features

Blender Interchange takes blend files and converts the blend file contents into individual assets. 
The following asset types are supported from blender to unreal engine.

| Feature                 | USD         | FBX         |
| ----------------------- | ----------- | ----------- |
| Static Meshes           | YES         | YES         |
| Skeletal Meshes         | YES         | YES         |
| Materials               | Limited*    | Limited     |
| Morph Targets           | YES**       | YES**       |
| Skeletal Animations     | YES         | YES         |
| Morph Target Animations | YES         | YES         |
| Static Mesh Animations  | YES         | YES         |
| Levels                  | Planned\*\* | Planned\*\* |
| Reimport                | YES         | YES         |
\*Materials are created and assigned but will not match any complex material graph created in blender. It is recommended to create materials in unreal separately using unreal's material graph. USD supports MaterialX which is a generic way of exporting material graph information. As of time of writing unreal and blender seem to have limitted support for materialX but supporting material transfer is planned in the future

\*\* Level import is planned for a future release. The current focus is on individual assets in the content browser. In the meantime you can sync your blend scene using something like unreal's USD stage actor. In the future we will support creating level instances from blend files.

# Notes
When reimporting it's recommended that you right click on the asset(s) you want to reimport and select reimport. You may also drag the asset into unreal again and override it, but this may cause issues with overriding materials and other work done in unreal since it's overriding and not reimporting.