using Sloj_poslovne_logike;
using Sloj_poslovne_logike.Hash_funkcije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prezentacijski_sloj
{
    public partial class PerceptualnoHashiranje : Form
    {        
        private PictureManagement picture1;
        private PictureManagement picture2;
        private Bitmap bitmapPicture1;
        private Bitmap bitmapPicture2;
        private bool uploadedPicture1;
        private bool uploadedPicture2;
        public PerceptualnoHashiranje()
        {
            InitializeComponent();
        }
        
        private void ProvjeriUcitaneSlike()
        {
            if (uploadedPicture1 && uploadedPicture2)
            {
                btnAverageHash.Enabled = true;
                btnPerceptualniHash.Enabled = true;
            }
        }

        private void btnAddPicture1_Click(object sender, EventArgs e)
        {
            picture1 = new PictureManagement();
            OpenFileDialog loadPicture = new OpenFileDialog();
            loadPicture.Title = picture1.GetNaslov();
            loadPicture.Filter = picture1.GetFilter();
            if (loadPicture.ShowDialog() == DialogResult.OK)
            {
                if (loadPicture.FileName != "")
                {
                    picture1.SetPutanja(loadPicture.FileName);
                    uploadedPicture1 = true;
                    ProvjeriUcitaneSlike();
                    bitmapPicture1 = new Bitmap(picture1.GetPutanja());
                    pbPicture1.SizeMode = PictureBoxSizeMode.Zoom;
                    pbPicture1.Image = bitmapPicture1;
                }
            }
        }

        private void btnAddPicture2_Click(object sender, EventArgs e)
        {
            picture2 = new PictureManagement();
            OpenFileDialog loadPicture = new OpenFileDialog();
            loadPicture.Title = picture2.GetNaslov();
            loadPicture.Filter = picture2.GetFilter();
            if (loadPicture.ShowDialog() == DialogResult.OK)
            {
                if (loadPicture.FileName != "")
                {
                    picture2.SetPutanja(loadPicture.FileName);
                    uploadedPicture2 = true;
                    ProvjeriUcitaneSlike();
                    bitmapPicture2 = new Bitmap(picture2.GetPutanja());
                    pbPicture2.SizeMode = PictureBoxSizeMode.Zoom;
                    pbPicture2.Image = bitmapPicture2;
                }
            }
        }

        private void btnPerceptualniHash_Click(object sender, EventArgs e)
        {
            try
            {
                rTxtIspis.Clear();
                Sloj_poslovne_logike.Hash_funkcije.PerceptualnoHashiranje pHash1 = new Sloj_poslovne_logike.Hash_funkcije.PerceptualnoHashiranje(bitmapPicture1);
                Sloj_poslovne_logike.Hash_funkcije.PerceptualnoHashiranje pHash2 = new Sloj_poslovne_logike.Hash_funkcije.PerceptualnoHashiranje(bitmapPicture2);
                rTxtIspis.AppendText("Hash prve slike:  " + pHash1.GetHash());
                rTxtIspis.AppendText(Environment.NewLine);
                rTxtIspis.AppendText("Hash druge slike:  " + pHash2.GetHash());
                rTxtIspis.AppendText(Environment.NewLine);
                int brojIstihBitova = Sloj_poslovne_logike.Hash_funkcije.PerceptualnoHashiranje.VratiBrojIstihBitova(pHash1.GetHash(), pHash2.GetHash());
                rTxtIspis.AppendText("Isti bitovi:" + " " + brojIstihBitova.ToString());
                rTxtIspis.AppendText(Environment.NewLine);
                int brojRazlicitihBitova = Sloj_poslovne_logike.Hash_funkcije.PerceptualnoHashiranje.VratiBrojRazlicitihBitova(pHash1.GetHash(), pHash2.GetHash());
                rTxtIspis.AppendText("Broj razlicitih bitova:  "+brojRazlicitihBitova.ToString());
                rTxtIspis.AppendText(Environment.NewLine);
                double prosjek = Sloj_poslovne_logike.Hash_funkcije.PerceptualnoHashiranje.VratiPostotakSlicnosti(brojIstihBitova, brojRazlicitihBitova, pHash1.GetHash().Length);
                rTxtIspis.AppendText("Postotak slicnosti ucitanih slika:  "+(int)Sloj_poslovne_logike.Hash_funkcije.PerceptualnoHashiranje.RačunanjeSlicnostiPercepcijskogHasha(pHash1, pHash2) + "%");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Slika nije uploadana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAverageHash_Click(object sender, EventArgs e)
        {
            try
            {
                rTxtIspis.Clear();
                AverageHash aHash1 = new AverageHash(bitmapPicture1);
                AverageHash aHash2 = new AverageHash(bitmapPicture2);
                rTxtIspis.AppendText("Hash prve slike:  " + aHash1.GetHash());
                rTxtIspis.AppendText(Environment.NewLine);
                rTxtIspis.AppendText("Hash druge slike:  " + aHash2.GetHash());
                rTxtIspis.AppendText(Environment.NewLine);
                int brojIstihBitova = AverageHash.VratiBrojIstihBitova(aHash1.GetHash(), aHash2.GetHash());
                rTxtIspis.AppendText("Isti bitovi:" + " " + brojIstihBitova.ToString());
                rTxtIspis.AppendText(Environment.NewLine);
                int brojRazlicitihBitova = AverageHash.VratiBrojRazlicitihBitova(aHash1.GetHash(), aHash2.GetHash());
                rTxtIspis.AppendText("Broj razlicitih bitova:  " + brojRazlicitihBitova.ToString());
                rTxtIspis.AppendText(Environment.NewLine);
                double prosjek = AverageHash.VratiPostotakSlicnosti(brojIstihBitova, brojRazlicitihBitova, aHash1.GetHash().Length);
                rTxtIspis.AppendText("Postotak slicnosti ucitanih slika: "+prosjek.ToString() + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Slika nije uploadana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
