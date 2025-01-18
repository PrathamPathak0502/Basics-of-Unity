# Basics of Unity

## 1. Install Unity and Unity Hub

### Download Unity Hub:
- Go to the Unity official website and download Unity Hub.

### Install Unity:
1. Open Unity Hub, go to the **Installs** tab, and click **Add**.
2. Choose the latest version of Unity or a specific version compatible with your needs.
3. Install additional modules (e.g., Android, iOS, WebGL) if you're targeting specific platforms.

## 2. Create a New Project

### Open Unity Hub:
1. Click on the **Projects** tab and select **New Project**.

### Select a Template:
- Choose a template based on your project type:
  - **3D Core**: For 3D games or applications.
  - **2D**: For 2D games or flat designs.
  - **VR**: If you're developing virtual reality experiences.
- Provide a project name and specify a save location.

### Create:
Click **Create Project** to open the Unity editor.

### Unity Interface Overview:
- **Scene View**:
  - Drag and drop objects (like cubes or spheres) into the scene.
  - Use the tools on the top-left (Move, Rotate, Scale) to adjust objects.
- **Game View**:
  - Press **Play** on the toolbar to test how your scene looks and behaves.
- **Hierarchy Window**:
  - Add objects by right-clicking in the **Hierarchy** and selecting options like **3D Object > Cube**.
- **Inspector Window**:
  - Select an object in the Scene or Hierarchy.
  - Adjust its properties (e.g., position, material, script).

---

## Basic Functions of Unity

### Creating Objects:
1. Go to **GameObject** in the top menu.
2. Select **2D Object** or **3D Object**.
   - Examples of 3D objects: Cube, Sphere, Plane, etc.

### Adding Material:
1. In the **Project** window, right-click and select **Create > Material**.
2. Customize the material's color or texture in the **Inspector**.
3. Drag the material onto an object to apply it.

### Transform Tools:
- Use the following shortcuts to manipulate objects in the **Scene View**:
  - **W**: Move (Translate).
  - **E**: Rotate.
  - **R**: Scale.

### Scene View Interaction:
- Use the Mouse to navigate:
  - Right-click to look around.
  - Middle-click to pan.
  - Scroll to zoom in/out.

### Play Mode:
- Press the **Play** button in the Toolbar to test your game.
- Press **Stop** to return to the editor.

### Inspector:
- Use the **Inspector** window to adjust properties of selected objects:
  - **Position**: Adjust the object's location.
  - **Rotation**: Rotate the object.
  - **Scale**: Change the size of the object.

### Hierarchy:
- Shows all objects in the scene.
- You can parent objects (nest one object under another) for organization.

### Scripting:
- Use C# scripts to add behavior to objects.
- Example: Create a script to make an object move or interact.

### Saving the Scene:
- Go to **File > Save As** to save your current scene.

### Building the Game:
- Go to **File > Build Settings**.
- Select a platform and click **Build** to export your project.

---

## Steps to Create a Simple Ping Ball Setup in Unity

### 1. Create the Ball (Sphere):
1. Go to **GameObject > 3D Object > Sphere**.
2. Rename it to **Ball** (optional).
3. Adjust the **Position** in the **Inspector**:
   - Example: Set **X = 0, Y = 1, Z = 0** (place it slightly above the ground).

### 2. Create the Slopes:
1. Add Cubes:
   - Go to **GameObject > 3D Object > Cube**. Add 3 cubes for the slopes.
2. Position the Cubes:
   - Arrange them in a triangular pattern around the ball.
   - Adjust each cube's **Rotation** on the **Z Axis** to form slopes. For example:
     - **Cube 1**: Z = 45 degrees
     - **Cube 2**: Z = -45 degrees
     - **Cube 3**: Z = 0 degrees (horizontal).
3. Ensure Alignment:
   - Verify that all cubes have the same **Z Position** to align them properly in the same plane (e.g., Z = 0).

### 3. Make the Ball Roll (Physics Setup):
1. Add a Rigidbody to the Ball:
   - Select the **Ball** in the **Hierarchy**.
   - Go to the **Inspector** and click **Add Component > Rigidbody**.
   - This adds physics to the ball, allowing it to roll and interact with slopes.
2. Keep Slopes Static:
   - Ensure the cubes remain static by not adding a Rigidbody to them.

### 4. Fine-Tune the Slopes:
1. Adjust Size:
   - Scale each cube to make them look like ramps. Example:
     - Scale (X, Y, Z): Set X = 1, Y = 0.5, Z = 4 for each slope to make them narrow and long.
2. Place the Ball on Top:
   - Adjust the Ball's position to rest on top of the slopes (slightly above their intersection).

### 5. Test the Setup:
1. Press **Play** to see the ball roll down the slopes.
2. If the ball doesn't roll:
   - Check the slopes' rotation and adjust the angle.
   - Ensure gravity is enabled in the Rigidbody (default setting).

### 6. Save Your Scene:
- Go to **File > Save As** and name your scene (e.g., "PingBallSetup").

---

## Adding Assets from Unity Asset Store
1. Open the Unity Asset Store:
   - In Unity, go to **Window > Asset Store**.
2. Search for Assets:
   - Use the search bar to find free or paid assets.
3. Import Assets:
   - Click **Download** (if not downloaded already).
   - Once downloaded, click **Import** to add the asset to your project.
4. Use Assets:
   - Drag and drop the imported assets from the **Project** window into the **Scene View** or **Hierarchy**.

---

## How to Remove Rendering of an Object
1. Select the Object:
   - In the **Hierarchy**, select the object you want to hide.
2. Disable the Mesh Renderer:
   - In the **Inspector**, find the **Mesh Renderer** component.
   - Uncheck the box next to **Enabled** to make the object invisible.
3. Alternative - Set Object as Inactive:
   - In the **Hierarchy**, right-click the object and select **Deactivate**.
4. Optional - Layers for Rendering:
   - Move the object to a different layer and configure the **Camera Culling Mask** to exclude that layer.
  

#For more info you can read my blog :- https://medium.com/@prathampathak0502     


