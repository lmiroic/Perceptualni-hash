using Shipwreck.Phash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Shipwreck.Phash.Bitmaps;
using System.Collections;

namespace Sloj_poslovne_logike.Hash_funkcije
{
    public class PerceptualnoHashiranje : Hashiranje
    {
        private Digest prvobitniHashSlike;
        public PerceptualnoHashiranje(Bitmap bitmap)
        {
            this.prvobitniHashSlike = ImagePhash.ComputeDigest(bitmap.ToLuminanceImage());
            byte[] hashSlikeBytes = Encoding.ASCII.GetBytes(this.prvobitniHashSlike.ToString());
            this.hashiranaVrijednost = VratiBitove(new BitArray(hashSlikeBytes));
        }
        public Digest GetDigest()
        {
            return this.prvobitniHashSlike;
        }
        public static double RačunanjeSlicnostiPercepcijskogHasha(PerceptualnoHashiranje hashPrveSlike, PerceptualnoHashiranje hashDrugeSlike)
        {
            return ImagePhash.GetCrossCorrelation(hashPrveSlike.GetDigest(), hashDrugeSlike.GetDigest()) * 100;
        }
    }
}
