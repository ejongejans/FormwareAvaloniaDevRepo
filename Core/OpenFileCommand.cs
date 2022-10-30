using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// command. 
    /// </summary>
    public class OpenFileCommand : Command
    {
        public string Title { get; set; } = "Click me to open a file";

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
