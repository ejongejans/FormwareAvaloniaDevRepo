﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// command sample. This is usually bind to a menu item and short cut at well. 
    /// </summary>
    public class OpenFileCommand : Command
    {

        public OpenFileCommand() : base("OpenFile")
        {
            Category ="file";
        }

        public override string Title
        {
            get
            {
                return "Open file";
            }
        }

        public override string ToolTip
        {
            get
            {
                return "Openfile tooltip";
            }
        }

        protected override void OnExecuted(EventArgs e)
        {
            Open(); 
        }


        public void Open()
        {
            using (IOpenFileView d = FApp.viewsFactory.OpenView())
            {
                if (d.ShowDialog())
                {

                    Document.OpenFile(d.FileName);
                }
            }

        }
    }
}
