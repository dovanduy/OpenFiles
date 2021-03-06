﻿using DotNetNuke.Services.FileSystem;
using System;

namespace Satrabel.OpenFiles.DigitalAssets
{
    public partial class PreviewPanelControl : DotNetNuke.Modules.DigitalAssets.PreviewPanelControl
    {
        public string ImageUrl
        {
            get
            {
                var fm = DotNetNuke.Services.FileSystem.FileManager.Instance;
                if (fm.IsImageFile(File))
                {
                    return fm.GetUrl(File);
                }
                else
                {
                    return PreviewImageUrl;
                }
            }
        }


        protected IFileInfo File { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int fileid = int.Parse(Page.Request.QueryString["fileId"]);
            var fm = DotNetNuke.Services.FileSystem.FileManager.Instance;
            File = fm.GetFile(fileid);
        }


    }
}