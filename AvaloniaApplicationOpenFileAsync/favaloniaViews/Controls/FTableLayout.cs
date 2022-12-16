using Avalonia;
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
    public partial class FTableLayout : Grid, IStyleable
    {

        Type IStyleable.StyleKey => typeof(Grid);

        public FTableLayout(List<IFControl> controls = null)
        {
            FName = Guid.NewGuid().ToString();
            if (controls != null)
                FControls = controls;
            else
                FControls = new List<IFControl>();

            this.Margin = new Thickness(0);
            this.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Stretch;
        }


        public List<IFControl> FControls { get; set; }

        private string fcolumndefs = "";
        private string frowdefs = "Auto";
        private int ColumnCount = 0;
        private int rowAddedCnt = 0;
        internal int tablePadding = 5;
        internal Avalonia.Layout.VerticalAlignment verticalControlAlignment =  Avalonia.Layout.VerticalAlignment.Top;
        internal Avalonia.Layout.HorizontalAlignment horizontalControlAlignment = Avalonia.Layout.HorizontalAlignment.Stretch;

        public void AddColumn(int totalcolumns, bool absolute, float pixelOrPct)
        {
            ColumnCount = totalcolumns;
            if (absolute)
            {
                fcolumndefs += "," + pixelOrPct.ToString("F0"); //px sizes.
            }
            else
            {
                if (pixelOrPct > 100 || pixelOrPct < 0)
                    throw new ArgumentOutOfRangeException();
                fcolumndefs += "," + pixelOrPct.ToString("F0")+"*"; //% sizes.
            }

            fcolumndefs = fcolumndefs.TrimStart(',');

            this.ColumnDefinitions = new ColumnDefinitions(fcolumndefs);
        }

        public void AddColumnsRelative(params float[] pctsWidths)
        {
            ColumnCount = pctsWidths.Length;
            foreach (float w in pctsWidths)
            {
                if (w > 100 || w < 0)
                    throw new ArgumentOutOfRangeException();
                fcolumndefs += "," + w.ToString("F0")+"*"; //% sizes.
            }
            fcolumndefs = fcolumndefs.TrimStart(',');

            this.ColumnDefinitions = new ColumnDefinitions(fcolumndefs);
        }


        

        public void AddRow(params object[] controls)
        {


            int colCnt = 0;
            int colsSpanned = 0;

            foreach (object obj in controls)
            {
                IFControl c = null;
                bool isLast = obj == controls[controls.Length - 1];

                if (obj == null)
                {
                    colCnt++; //is this correct? 
                    continue;
                }
                if (obj is string)
                    c = new FLabel((string)obj);
                else
                    c = (IFControl)obj;

                if (c.FColspan == 0)
                    c.FColspan = 1;


                //if we are in the last control. We should check the amount of added columns. 
                if (isLast && colsSpanned < this.ColumnCount - 1) //only last object needs to be set.
                {
                    c.FColspan = (this.ColumnCount - controls.Length) + 1; //what is left, plus the contorl itself. 
                }

                FControls.Add(c); //so we have at least our own reference.. 
                
                Control ct = (Control)c;


                ct.VerticalAlignment = verticalControlAlignment;
                ct.HorizontalAlignment = horizontalControlAlignment;
                
                

                SetColumn(ct, colCnt);
                SetRow(ct, rowAddedCnt);
                this.Children.Add(ct);

                colCnt++;
                colsSpanned += c.FColspan;

                if (c.FColspan > 1)
                    SetColumnSpan(ct, c.FColspan);

               ct.Margin = new Thickness(c.FIndent, 0, isLast ? 0 : tablePadding, tablePadding);


                //maxHeight = Math.Max(maxHeight, c.FHeight);
            }

            rowAddedCnt++;
            if (rowAddedCnt > 1)
                frowdefs += ",Auto"; 
            this.RowDefinitions = new RowDefinitions(frowdefs);
        }


        public void AddClosingRow()
        {

            for (int i = 0; i < this.ColumnCount; i++)
            {
                FLabel spacer = new FLabel(" ");
                AddRow(spacer);
            }


        }

        public SKColor FBgColor
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

        public int FPadding
        {
            set
            {
                this.Margin = new Avalonia.Thickness(value);
                
            }


        }


        public bool FScroll
        {
            get
            {
                return false;
                //return this.AutoScroll; //todo test scroll in gridview.. 
            }
            set
            {
                //this.AutoScroll = false;
               // this.HorizontalScroll.Visible = false;
               // this.HorizontalScroll.Enabled = false;
                //this.AutoScroll = true;
            }
        }

        public int FMaxHeight
        {
            get
            {
                return (int)this.MaxHeight;
            }
            set
            {
                this.MaxHeight = value;
            }
        }
    }
}
