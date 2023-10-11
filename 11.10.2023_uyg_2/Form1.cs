using System;

namespace _11._10._2023_uyg_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpg (.jpg)|*.jpg|Png(.png)|*.png";    
            ofd.ShowDialog(); 
            string dosyaYolu = ofd.FileName;
            pboxResim.ImageLocation = dosyaYolu;
        }

        List<PersonelBilgileri> People = new List<PersonelBilgileri>();
        public void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelBilgileri person = new PersonelBilgileri();
                person.PersonelID = txBoxID.Text;
                person.PersonelAd = txBoxAd.Text;
                person.PersonelSoyad = txBoxSoyad.Text;
                person.DogumTarihi = dtDogumTarihi.Value;
                person.Telefon = txBoxTelefon.Text;
                person.Email = txBoxEmail.Text;
                person.Adres = txBoxAdres.Text;
                person.IseGirisTarihi = dtIseGirisTarihi.Value;
                People.Add(person);
                ListViewDoldur();
                HataTespit(txBoxID.TextLength, dtDogumTarihi.Value.Date, dtIseGirisTarihi.Value, txBoxEmail.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalý giriþ yaptýnýz!!!");
                throw new Exception("Hatalý giriþ yaptýnýz!!!");
            }
        }
        private void ListViewDoldur()
        {
            lvKisiler.Items.Clear();
            foreach (PersonelBilgileri person in People)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.SubItems.Add(person.PersonelID);
                lvi.SubItems.Add(person.PersonelAd);
                lvi.SubItems.Add(person.PersonelSoyad);
                lvi.SubItems.Add(person.DogumTarihi.ToString());
                lvi.SubItems.Add(person.Telefon);
                lvi.SubItems.Add(person.Email);
                lvi.SubItems.Add(person.Adres);
                lvi.SubItems.Add(person.IseGirisTarihi.ToString());
                lvKisiler.Items.Add(lvi);
            }
        }
        public void HataTespit(decimal id, DateTime dogumTarihi, DateTime iseGirisTarihi, string email)
        {
            try
            {
                ListViewItem lvi = new ListViewItem();
                if (id < 6)
                {
                    throw new Exception("Personel ID 6 karakterden az olamaz!!!");
                }
            }
            catch (Exception)
            {
                throw new Exception("Hatalý giriþ yaptýnýz!!!");
            }
        }
        private void lvKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKisiler.SelectedItems.Count > 0)  
            {
                int index = lvKisiler.FocusedItem.Index;
            }
        }
    }
}