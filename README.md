# RhinoCommon Visual Studio Extensions

Includes RhinoCommon and Grasshopper template wizards for Visual Studio on Windows and Mac.

Manual Install Instructions (Mac)
---------------------------------

1. As of this writing, update to **Visual Studio for Mac 2022 v17.3 or later**.
2. Download [the latest .mpack release](https://github.com/mcneel/RhinoVisualStudioExtensions/releases).
3. Launch **Visual Studio for Mac**.
4. Navigate to **Visual Studio** > **Extensions...**
5. Click on the **Installed** tab
6. **Uninstall** all previous versions of the **RhinoCommon Plugin Support**.  If none are installed, you can ignore the next two steps (skip to step 9).
7. **Quit** and **Restart** Visual Studio for Mac.
8. Navigate to **Visual Studio** > **Extensions...** again.
9. Click **Install from file...** button in the lower-left corner.
10. Navigate to the mpack file you downloaded in step 1, then click **Open**.
11. Click **Install**.  The plugin should install.
12. **Quit** and **Restart** Visual Studio for Mac.
13. Navigate to **Visual Studio** > **Extensions..** > **Installed** tab.  Verify that **RhinoCommon Plugin Support** is listed.  If it's there, you have successfully installed the extension and you are **DONE**.

Manual Install Instructions (Windows)
-------------------------------------

1. Download [the latest .vsix release](https://github.com/mcneel/RhinoVisualStudioExtensions/releases).
2. Close any instances of Visual Studio.
3. Double click the .vsix in File Explorer.
4. Run through the wizard to install the extension.
5. Start Visual Studio and create a new RhinoCommon or Grasshopper project.

Using dotnet new
----------------

1. Install the templates from nuget. This will show the list of all templates after a successful install.

    `dotnet new -i Rhino.Templates`

2. Create a new folder for your project:

    ```
    mkdir MyNewRhinoPlugin
    cd MyNewRhinoPlugin
    ```

3. Show options for the templates: 

    ```
    dotnet new rhino --help
    dotnet new grasshopper --help
    ```

4. Create the project

    `dotnet new rhino`

5. Build your project

    `dotnet build`


Debugging Rhino
---------------

1. Click the **Run** button in the upper left-hand corner of Visual Studio

For Developers (of this Extension)
--------------

## Mac
Building this project requires the **Addin Maker Extension**.  You can install this from within Visual Studio by navigating to **Visual Studio** > **Extensions...** > **Gallery** > **Extension Development** > **AddinMaker**.  Click the **Install** button.  **Quit** and **relaunch** Visual Studio for Mac.

