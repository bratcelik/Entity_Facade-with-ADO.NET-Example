namespace Entity_Facade_with_ADO.NET_Example
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            btnSirketEkle = new Button();
            txtSirketTelefon = new TextBox();
            txtSirketAd = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 93);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 9;
            label2.Text = "Telefon:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 8;
            label1.Text = "Şirket Adı:";
            // 
            // btnSirketEkle
            // 
            btnSirketEkle.Location = new Point(167, 147);
            btnSirketEkle.Name = "btnSirketEkle";
            btnSirketEkle.Size = new Size(94, 29);
            btnSirketEkle.TabIndex = 7;
            btnSirketEkle.Text = "Ekle";
            btnSirketEkle.UseVisualStyleBackColor = true;
            // 
            // txtSirketTelefon
            // 
            txtSirketTelefon.Location = new Point(136, 90);
            txtSirketTelefon.Name = "txtSirketTelefon";
            txtSirketTelefon.Size = new Size(125, 27);
            txtSirketTelefon.TabIndex = 6;
            // 
            // txtSirketAd
            // 
            txtSirketAd.Location = new Point(136, 42);
            txtSirketAd.Name = "txtSirketAd";
            txtSirketAd.Size = new Size(125, 27);
            txtSirketAd.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 218);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSirketEkle);
            Controls.Add(txtSirketTelefon);
            Controls.Add(txtSirketAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnSirketEkle;
        private TextBox txtSirketTelefon;
        private TextBox txtSirketAd;
    }
}