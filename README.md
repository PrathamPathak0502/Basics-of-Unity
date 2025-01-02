# Basics-of-Utility
1. Install Unity and Unity Hub
Download Unity Hub:
Go to the Unity official website and download Unity Hub.
Install Unity:
Open Unity Hub, go to the Installs tab, and click Add.
Choose the latest version of Unity or a specific version compatible with your needs.
Install additional modules (e.g., Android, iOS, WebGL) if you're targeting specific platforms.

2. Create a New Project
Open Unity Hub:
Click on the Projects tab and select New Project.
Select a Template:
Choose a template based on your project type:
3D Core: For 3D games or applications.
2D: For 2D games or flat designs.
VR: If you're developing virtual reality experiences.
Provide a project name and specify a save location.
Create:
Click Create Project to open the Unity editor.


Once your project is open, you’ll see the main Unity interface:

Scene View:

Drag and drop objects (like cubes or spheres) into the scene.
Use the tools on the top-left (Move, Rotate, Scale) to adjust objects.
Game View:

Press Play on the toolbar to test how your scene looks and behaves.
Hierarchy Window:

Add objects by right-clicking in the Hierarchy and selecting options like 3D Object > Cube.
Inspector Window:

Select an object in the Scene or Hierarchy.
Adjust its properties (e.g., position, material, script).

Basic Functions of Unity
Creating Objects:

Go to GameObject in the top menu.
Select 2D Object or 3D Object.
Examples of 3D objects: Cube, Sphere, Plane, etc.
Adding Material:

In the Project window, right-click and select Create > Material.
Customize the material's color or texture in the Inspector.
Drag the material onto an object to apply it.
Transform Tools:

Use the following shortcuts to manipulate objects in the Scene View:
W: Move (Translate).
E: Rotate.
R: Scale.
Scene View Interaction:

Use the Mouse to navigate:
Right-click to look around.
Middle-click to pan.
Scroll to zoom in/out.
Play Mode:

Press the Play button in the Toolbar to test your game.
Press Stop to return to the editor.
Inspector:

Use the Inspector window to adjust properties of selected objects:
Position: Adjust the object's location.
Rotation: Rotate the object.
Scale: Change the size of the object.
Hierarchy:

Shows all objects in the scene.
You can parent objects (nest one object under another) for organization.
Scripting:

Use C# scripts to add behavior to objects.
Example: Create a script to make an object move or interact.
Saving the Scene:

Go to File > Save As to save your current scene.
Building the Game:

Go to File > Build Settings.
Select a platform and click Build to export your project.

Steps to Create a Simple Ping Ball Setup in Unity
1. Create the Ball (Sphere)
Go to GameObject > 3D Object > Sphere.
Rename it to Ball (optional).
Adjust the Position in the Inspector:
Example: Set X = 0, Y = 1, Z = 0 (place it slightly above the ground).
2. Create the Slopes
Add Cubes:
Go to GameObject > 3D Object > Cube. Add 3 cubes for the slopes.
Position the Cubes:
Arrange them in a triangular pattern around the ball.
Adjust each cube's Rotation on the Z Axis to form slopes. For example:
Cube 1: Z = 45 degrees
Cube 2: Z = -45 degrees
Cube 3: Z = 0 degrees (horizontal).
Ensure Alignment:
Verify that all cubes have the same Z Position to align them properly in the same plane (e.g., Z = 0).
3. Make the Ball Roll (Physics Setup)
Add a Rigidbody to the Ball:

Select the Ball in the Hierarchy.
Go to the Inspector and click Add Component > Rigidbody.
This adds physics to the ball, allowing it to roll and interact with slopes.
Keep Slopes Static:

Ensure the cubes remain static by not adding a Rigidbody to them.
4. Fine-Tune the Slopes
Adjust Size:
Scale each cube to make them look like ramps. Example:
Scale (X, Y, Z): Set X = 1, Y = 0.5, Z = 4 for each slope to make them narrow and long.
Place the Ball on Top:
Adjust the Ball's position to rest on top of the slopes (slightly above their intersection).
5. Test the Setup
Press Play to see the ball roll down the slopes.
If the ball doesn't roll:
Check the slopes' rotation and adjust the angle.
Ensure gravity is enabled in the Rigidbody (default setting).
6. Save Your Scene
Go to File > Save As and name your scene (e.g., "PingBallSetup").
Corrections and Notes
Cube Alignment on Z-Axis: All cubes must share the same Z Position (e.g., Z = 0) to ensure proper alignment.
Rotation Axis for Slopes: Rotate the cubes on the Z-Axis to create slopes, not on the X or Y axis.
Physics for Ball: Only the ball needs a Rigidbody for rolling, while slopes stay static.
Gravity Check: The ball requires gravity enabled in its Rigidbody to roll down the slopes.
