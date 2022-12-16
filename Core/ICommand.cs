using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore
{
    public interface ICommand
    {
        string ID { get; set; }

        List<CommandControl> LinkedUIControls { get; set; }

        SKBitmap Image { get; set; }

        SKBitmap Icon(int size);

        // string ToolTipKey { get; set; }

        // string MenuTextKey { get; set; }

        string ToolTip { get; }

        string Title { get; }

        string Category { get; }

        bool Enabled { get; set; }

        bool Checked { get; set; }
        void Execute();

        void Execute(EventArgs e);

        /*
       // FKey FShortCut { get; set; }

        bool ShortcutIn3DViewOnly { get; set; }

        bool Visible { get; set; }

      //  List<FSubmenuItem> GetSubmenuItems();

        

        bool AddToMenu { get; set; }

        bool AddMenuSeperator { get; set; }

        bool IsCategoryHeader { get; set; }

        void UpdateOnSetting();

        */
    }
}
