using Avalonia.Controls;
using Avalonia.Styling;
using FAvalonia.favaloniaViews.Helpers;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAvalonia.favaloniaViews.Controls
{
    public partial class FToolButton : Button, IFControl, IStyleable
    {

        Type IStyleable.StyleKey => typeof(Button);

        public int ImagePadding = 4;

        public FToolButton() : base()
        {
            this.Width = ImagePadding * 2 + 16;
            this.Height = ImagePadding * 2 + 16;


        }

        public FToolButton(SKBitmap icon) : base()
        {
            this.Name = Guid.NewGuid().ToString();

            SetImage(icon);

        }

        public void SetImage(SKBitmap icon)
        {
            Image img = icon.ToImage();
            img.Width = icon.Width;
            img.Height = icon.Height;

            this.Width = ImagePadding * 2 + img.Width;
            this.Height = ImagePadding * 2 + img.Height;

            this.Content = img;
            this.HorizontalContentAlignment = Avalonia.Layout.HorizontalAlignment.Center;
            this.VerticalContentAlignment = Avalonia.Layout.VerticalAlignment.Center;
            this.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Stretch;
            this.HorizontalContentAlignment = Avalonia.Layout.HorizontalAlignment.Center;
        }

        public string FText
        {
            get
            {
                return this.Content.ToString();
            }
            set
            {
                this.Content = value.ToString();
            }
        }

        public event EventHandler FOnClick
        {
            add
            {
                AddHandler(ClickEvent, value);
            }
            remove
            {
                RemoveHandler(ClickEvent, value);
            }
        }




    }
}

