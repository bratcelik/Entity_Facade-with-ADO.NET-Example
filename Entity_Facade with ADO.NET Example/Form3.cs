using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Facade_with_ADO.NET_Example
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            btnSirketSil.Click += BtnSirketSil_Click;
        }

        private void BtnSirketSil_Click(object? sender, EventArgs e)
        {
            string mesaj = string.Empty;

            int sirketID = Convert.ToInt32(txtSirketID.Text);


            bool sonuc = BLLShippers.BLL_DELETE(sirketID);

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
