using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Skia.Helpers;
using Avalonia.Visuals.Media.Imaging;
using Avalonia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using Avalonia.Media.Imaging;

namespace FAvalonia.favaloniaViews.Helpers
{
    public static class GraphicsExtensions
    {
        /*
        public static WindowIcon ToWindowIcon(this SKBitmap skbmp)
        {
            if (skbmp == null)
                return null;




            WindowIcon w = new WindowIcon(FUtilSkia.IcoStreamFromSKBitmap(skbmp));

            return w; //this probably won't work on linux/mac. Todo check this. 
        }*/

        public static Bitmap ToBitmap(this SKBitmap skbmp)
        {
            if (skbmp == null)
                return null;
            using (MemoryStream ms = new MemoryStream())
            {
                skbmp.Encode(ms, SKEncodedImageFormat.Png, 100);
                ms.Position = 0;
                return new Bitmap(ms);
            }
        }


        public static SKBitmap ToSKBitmap(this IImage iimage)
        {
            Rect r = new Rect(iimage.Size);

            SKBitmap bmp = new SKBitmap((int)r.Width,(int) r.Height); //EJ:removed core call here.

            using (SKCanvas g = new SKCanvas(bmp))
            {
                IDrawingContextImpl contextImpl = DrawingContextHelper.WrapSkiaCanvas(g, new Vector(96, 96));
                DrawingContext cnt = new DrawingContext(contextImpl);
                iimage.Draw(cnt, r, r, BitmapInterpolationMode.HighQuality);
            }

            return bmp;
        }




        public static Image ToImage(this SKBitmap skbmp)
        {
            if (skbmp == null)
                return null;
            Bitmap bmp = skbmp.ToBitmap();
            Image img = new Image();
            img.Source = bmp;
            return img;

        }

        public static ImageBrush ToImageBrush(this SKBitmap skbmp)
        {
            if (skbmp == null)
                return null;
            Bitmap bmp = skbmp.ToBitmap();
            return new ImageBrush(bmp);
        }

        /// <summary>
        /// convert a sk color struct to solidcolorbrush avalonia
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static SolidColorBrush ToSolidBrush(this SKColor color)
        {
            return new SolidColorBrush(((uint)color));
        }

        public static SKColor ToSKColor(this Color color)
        {
            return new SKColor(color.R, color.G, color.B, color.A);
        }

        public static Color ToColor(this SKColor color)
        {
            return new Color(color.Alpha, color.Red, color.Green, color.Blue);
        }

        /// <summary>
        /// if solid brush then returns color. otherwise white.
        /// </summary>
        /// <param name="brush"></param>
        /// <returns></returns>
        public static SKColor ToSKColor(this IBrush brush)
        {
            if (brush is SolidColorBrush) //normally 
            {
                SolidColorBrush solid = (SolidColorBrush)brush;
                return solid.Color.ToSKColor();
            }
            return SKColors.White;
        }
    }
}
