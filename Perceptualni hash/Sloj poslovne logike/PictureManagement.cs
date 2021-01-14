using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike
{
    public class PictureManagement
    {
        private String putanja;
        private String naslovOFD;
        private String filterOFD;
        private String hashSlike;

        public PictureManagement()
        {
            this.naslovOFD = "Pictures";
            this.filterOFD = "All Images | *.jpg; *.bmp; *.png";

        }
        public String GetHash()
        {
            return this.hashSlike;
        }
        public void SetHash(String hash)
        {
            this.hashSlike = hash;
        }
        public String GetPutanja()
        {
            return this.putanja;
        }
        public void SetPutanja(string putanja)
        {
            this.putanja = putanja;
        }
        public String GetNaslov()
        {
            return this.naslovOFD;
        }
        public String GetFilter()
        {
            return this.filterOFD;
        }
    }
}
