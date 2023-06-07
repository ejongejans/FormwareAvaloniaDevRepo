using FCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// command sample. This is usually bind to a menu item and short cut at well. 
    /// </summary>
    public class ExampleCommand : Command
    {
        private int exNr;



        public ExampleCommand(int exampleNr) : base("example"+exampleNr)
        {
            exNr = exampleNr;
            Category = "categoryHeader";
            Image = FUtilSkia.RandomBitmap(24, 24);
        }


        public override string Title
        {
            get
            {
                return "Example command "+exNr;
            }
        }

        public override string ToolTip
        {
            get
            {
                return "Tooltip for example command "+exNr;
            }
        }

        protected override void OnExecuted(EventArgs e)
        {
            Trace.WriteLine("Fired from example command: " + exNr);
            
        }


        
    }
}
