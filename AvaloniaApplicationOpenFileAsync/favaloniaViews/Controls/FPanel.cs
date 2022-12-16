using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Styling;
using FAvalonia.favaloniaViews.Helpers;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAvalonia.favaloniaViews.Controls
{
    public partial class FPanel : Panel, IFPanel, IStyleable
    {

        Type IStyleable.StyleKey => typeof(Panel);

        public SKBitmap FBackgroundImage {
            get
            {
                if (this.Background is ImageBrush b)
                {
                    return b.Source.ToSKBitmap();
                }
                return null;
            }
            set
            {
                this.Background = new ImageBrush(value.ToBitmap());
            }
        }
        public SKColor FBackColor
        { 
            get
            {
                return this.Background.ToSKColor();
            }
            set
            {
                this.Background = value.ToSolidBrush();
            }
        }

        public bool FScroll { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IFControl> FControls { get; set; } = new List<IFControl>();

        public FPanel() 
        {
            //this.FName = Guid.NewGuid().ToString();
            //this.FColspan = 1;
            this.Height = 50; //small initial setup

            FControls = new List<IFControl>();

            
            this.Height = 600;

        }

        public event EventHandler FOnClick
        { 
            add
            {
                AddHandler(PointerReleasedEvent, value);
            }
            remove
            {
                RemoveHandler(PointerReleasedEvent, value);
            }
        }


        public void AddContent(IFControl control)
        {
            if (control is FTableLayout)
            {
            //todo close tablelayout?? 
                FTableLayout l = (FTableLayout)control;
                l.AddClosingRow();
            }
            this.Children.Add((Control)control);
            this.FControls.Add(control);
        }

        public void AddContent(IProgrammaticView view)
        {
            this.Children.Add((Control)view); //why not add the other way around here?? 
        }

        public void FClear()
        {
            this.Children.Clear();
            FControls.Clear();
        }
    }
}
