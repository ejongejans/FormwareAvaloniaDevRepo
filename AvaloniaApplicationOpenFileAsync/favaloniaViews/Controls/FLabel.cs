using Avalonia.Controls;
using Avalonia.Styling;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FAvalonia.favaloniaViews.Controls
{
    public partial class FLabel : TextBlock, IFLabel, IStyleable
    {

        Type IStyleable.StyleKey => typeof(TextBlock);

        public FLabel(string text)
        {
           // this.FName = Guid.NewGuid().ToString();
            this.Text = text;
            //this.FColspan = 1;

            this.TextWrapping = Avalonia.Media.TextWrapping.WrapWithOverflow;
            this.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Stretch;
            /*
            TextAlign = ContentAlignment.MiddleLeft;
            this.AutoSize = true;
            this.SetAutoSizeMode(AutoSizeMode.GrowAndShrink);


            if (!string.IsNullOrEmpty(text)) //for long text we stretch
            {
                if (text.Length > 50)
                {
                    this.Padding = new Padding(3, 6, 3, 6);
                    this.TextAlign = ContentAlignment.TopLeft;
                }
            }*/




        }

        public void SetUnderline()
        {
            //this.SetValue(TextDecorationsProperty, "Underline");



            this.TextDecorations = Avalonia.Media.TextDecorations.Underline;

        }

        public void RemoveUnderline()
        {
            this.TextDecorations = null;
        }


        public string FText { get { return this.Text; } set { this.Text = value; } }

        private bool fbold = false;
        public bool FBold
        {
            get
            {
                return this.FontWeight == Avalonia.Media.FontWeight.Bold;
            }
            set
            {
                if (value)
                    this.FontWeight = Avalonia.Media.FontWeight.Bold;
                else
                    this.FontWeight = Avalonia.Media.FontWeight.Normal;
            }
        }

        public SKColor FColor { get; set; } //EJ: removed dependency








    }
}

