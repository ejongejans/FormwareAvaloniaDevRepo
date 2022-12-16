using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;

namespace FCore
{
    /// <summary>
    /// this is in intermediary class to handle the interaction with the UI. 
    /// it keeps track of all the links to the UI controls. 
    /// </summary>
    public class CommandControl
    {
        public Action<bool> SetVisible;
        public Action<bool> SetEnabled;
        public Action<bool> SetChecked;
        public Action<SKBitmap> SetImage;
        public Action SetImageType;
    }
}
