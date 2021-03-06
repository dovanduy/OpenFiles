﻿using DotNetNuke.ExtensionPoints;
using System.ComponentModel.Composition;

namespace Satrabel.OpenFiles.Components.DigitalAssets
{
    [Export(typeof(IScriptItemExtensionPoint))]
    [ExportMetadata("Module", "DigitalAssets")]
    [ExportMetadata("Name", "DigitalAssetsScriptItemExtensionPoint")]
    [ExportMetadata("Group", "")]
    [ExportMetadata("Priority", 1)]
    public class DigitalAssetsScriptItemExtensionPoint : IScriptItemExtensionPoint
    {
        public string ScriptName
        {
            get {
                return "~/DesktopModules/OpenFiles/js/DigitalAssetsExtension.js";
            }
        }

        public string Icon
        {
            get { return ""; }
        }

        public int Order
        {
            get { return 1; }
        }

        public string Text
        {
            get { return ""; }
        }
    }
}