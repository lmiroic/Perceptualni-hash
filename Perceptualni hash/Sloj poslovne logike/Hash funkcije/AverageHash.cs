using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.Hash_funkcije
{
    public class AverageHash:Hashiranje
    {
        public AverageHash(Bitmap bmapSlika)
        {
            Bitmap slika = new Bitmap(bmapSlika, new Size(8, 8));
            Bitmap grayscale;
            int x, y, avg, a, r, g, b;
            for (x = 0; x < slika.Width; x++)
            {
                for (y = 0; y < slika.Height; y++)
                {
                    Color bojaPiksela = slika.GetPixel(x, y);
                    a = bojaPiksela.A;
                    r = bojaPiksela.R;
                    g = bojaPiksela.G;
                    b = bojaPiksela.B;
                    avg = (r + g + b) / 3;
                    slika.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
            grayscale = slika;
            int avgRed = 0, avgGreen = 0, avgBlue = 0;
            for (x = 0; x < grayscale.Width; x++)
            {
                for (y = 0; y < grayscale.Height; y++)
                {
                    r = grayscale.GetPixel(x, y).R;
                    g = grayscale.GetPixel(x, y).G;
                    b = grayscale.GetPixel(x, y).B;
                    avgRed += r;
                    avgGreen += g;
                    avgBlue += b;
                }
            }
            Color avgColor = Color.FromArgb(avgRed / 64, avgGreen / 64, avgBlue / 64);
            for (x = 0; x < grayscale.Width; x++)
            {
                for (y = 0; y < grayscale.Height; y++)
                {
                    if (grayscale.GetPixel(x, y).GetBrightness() < avgColor.GetBrightness())
                    {
                        hashiranaVrijednost += "1";
                    }
                    else
                    {
                        hashiranaVrijednost += "0";
                    }
                }
            }
        }
    }
}
