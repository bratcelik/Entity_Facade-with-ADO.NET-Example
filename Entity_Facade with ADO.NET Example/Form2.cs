using BLL;
using Entity;

namespace Entity_Facade_with_ADO.NET_Example
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            btnSirketGuncelle.Click += BtnSirketGuncelle_Click;
        }

        private void BtnSirketGuncelle_Click(object? sender, EventArgs e)
        {
            string mesaj = string.Empty;
            EShipper shipper = new EShipper();
            shipper.CompanyName = txtSirketAd.Text;
            shipper.Phone = txtSirketTelefon.Text;
            shipper.ShipperID = Convert.ToInt32(txtSirketID.Text);


            bool sonuc = BLLShippers.BLL_UPDATE(shipper);

            if (sonuc)
            {
                mesaj = "İşlem Başarılı!";
            }
            else
            {
                mesaj = "İşlem Başarısız!";
            }

            MessageBox.Show(mesaj, "İşlem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
