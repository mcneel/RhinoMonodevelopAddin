﻿using MonoDevelop.Components;
using MonoDevelop.Ide.Gui.Dialogs;
using MonoDevelop.Projects;


namespace Rhino.VisualStudio.Mac
{
    internal class RhinoRunConfigurationEditor : MonoDevelop.Ide.Projects.OptionPanels.RunConfigurationPanel
    {
        public override Control CreatePanelWidget()
        {
            return base.CreatePanelWidget();
        }
    }

    internal class RhinoRunConfiguration : AssemblyRunConfiguration
    {
        public override bool CanRunLibrary => true;

        public RhinoRunConfiguration(string name) : base(name)
        {
        }
    }
}

