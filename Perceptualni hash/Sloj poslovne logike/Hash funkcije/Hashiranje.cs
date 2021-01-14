using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.Hash_funkcije
{
    public class Hashiranje
    {
        protected String hashiranaVrijednost;

        public String GetHash()
        {
            return this.hashiranaVrijednost;
        }

        public static int VratiBrojIstihBitova(String prviHash, String drugiHash)
        {         
            int duljinaPrvogHasha = prviHash.Length;
            int duljinaDrugogHasha = drugiHash.Length;
            int brojIstihBitova = 0;
            if (!duljinaPrvogHasha.Equals(duljinaDrugogHasha))
            {
                throw new Exception("Hash vrijednosti nisu jednake!");
            }
            var poljeSlovaPrvogHasha = prviHash.ToCharArray();
            var poljeSlovaDrugogHasha = drugiHash.ToCharArray();
            for (int i = 0; i < poljeSlovaPrvogHasha.Length; i++)
            {
                if (poljeSlovaPrvogHasha[i].Equals(poljeSlovaDrugogHasha[i]))
                {
                    brojIstihBitova++;
                }
            }
            return brojIstihBitova;
        }
        public static int VratiBrojRazlicitihBitova(String prviHash, String drugiHash)
        {          
            int duljinaPrvogHasha = prviHash.Length;
            int duljinaDrugogHasha = drugiHash.Length;
            int brojRazlicitihBitova = 0;
            if (!duljinaPrvogHasha.Equals(duljinaDrugogHasha))
            {
                throw new Exception("Hash vrijednosti nisu jednake!");
            }
            var poljeSlovaPrvogHasha = prviHash.ToCharArray();
            var poljeSlovaDrugogHasha = drugiHash.ToCharArray();
            for (int i = 0; i < poljeSlovaPrvogHasha.Length; i++)
            {
                if (!poljeSlovaPrvogHasha[i].Equals(poljeSlovaDrugogHasha[i]))
                {
                    brojRazlicitihBitova++;
                }
            }
            return brojRazlicitihBitova;
        }
        public static double VratiPostotakSlicnosti(int istiBitovi, int razlicitiBitovi, int duljinaHasha)
        {
            double prosjek = 0;
            if (istiBitovi != 0 && razlicitiBitovi != 0)
            {
                prosjek = (istiBitovi * 100 / duljinaHasha);
            }
            if (istiBitovi != 0 && razlicitiBitovi == 0)
            {
                prosjek = 100;
            }
            return prosjek;
        }
        public String VratiBitove(BitArray poljeBitova)
        {
            String StringBitova = "";
            for (int i = 0; i < poljeBitova.Length; i++)
            {
                StringBitova += poljeBitova.Get(i) ? "1" : "0";
            }
            return StringBitova;
        }
    }
}
