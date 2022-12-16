using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCore
{
    public static class FUtilSkia
    {
        private static Random rnd = new Random();


        /// <summary>
        /// generates a random color
        /// </summary>
        /// <returns></returns>
        public static SKColor RandomColor()
        {
            return new SKColor((byte)rnd.Next(128, 255), (byte)rnd.Next(128, 255), (byte)rnd.Next(128, 255));
        }

        public static SKBitmap RandomBitmap(int w, int h)
        {
            SKBitmap bmp = new SKBitmap(w, h);
            using (SKCanvas g = new SKCanvas(bmp))
            {
                g.Clear(RandomColor());
            }
            return bmp;
        }

        
    }
}
