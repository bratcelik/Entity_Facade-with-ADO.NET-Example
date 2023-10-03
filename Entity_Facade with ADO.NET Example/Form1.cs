using BLL;
using Entity;

namespace Entity_Facade_with_ADO.NET_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnSirketEkle.Click += BtnSirketEkle_Click;
        }

        private void BtnSirketEkle_Click(object? sender, EventArgs e)
        {
            string mesaj = string.Empty;
            EShipper shipper = new EShipper();
            shipper.CompanyName = txtSirketAd.Text;
            shipper.Phone = txtSirketTelefon.Text;

            bool sonuc = BLLShippers.BLL_INSERT(shipper);

            if (sonuc)
            {
                mesaj = "Ýþlem Baþarýlý!";
            }
            else
            {
                mesaj = "Ýþlem Baþarýsýz!";
            }

            MessageBox.Show(mesaj, "Ýþlem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}