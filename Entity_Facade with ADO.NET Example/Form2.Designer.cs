namespace Entity_Facade_with_ADO.NET_Example
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            btnSirketGuncelle = new Button();
            txtSirketTelefon = new TextBox();
            txtSirketAd = new TextBox();
            label3 = new Label();
            txtSirketID = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 114);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 9;
            label2.Text = "Telefon:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 81);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 8;
            label1.Text = "Şirket Adı:";
            // 
            // btnSirketGuncelle
            // 
            btnSirketGuncelle.Location = new Point(166, 154);
            btnSirketGuncelle.Name = "btnSirketGuncelle";
            btnSirketGuncelle.Size = new Size(94, 29);
            btnSirketGuncelle.TabIndex = 7;
            btnSirketGuncelle.Text = "Güncelle";
            btnSirketGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtSirketTelefon
            // 
            txtSirketTelefon.Location = new Point(135, 111);
            txtSirketTelefon.Name = "txtSirketTelefon";
            txtSirketTelefon.Size = new Size(125, 27);
            txtSirketTelefon.TabIndex = 6;
            // 
            // txtSirketAd
            // 
            txtSirketAd.Location = new Point(135, 78);
            txtSirketAd.Name = "txtSirketAd";
            txtSirketAd.Size = new Size(125, 27);
            txtSirketAd.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 48);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 11;
            label3.Text = "Şirket ID:";
            // 
            // txtSirketID
            // 
            txtSirketID.Location = new Point(135, 45);
            txtSirketID.Name = "txtSirketID";
            txtSirketID.Size = new Size(125, 27);
            txtSirketID.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 270);
            Controls.Add(label3);
            Controls.Add(txtSirketID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSirketGuncelle);
            Controls.Add(txtSirketTelefon);
            Controls.Add(txtSirketAd);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnSirketGuncelle;
        private TextBox txtSirketTelefon;
        private TextBox txtSirketAd;
        private Label label3;
        private TextBox txtSirketID;
    }
}