namespace Entity_Facade_with_ADO.NET_Example
{
    partial class Form3
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
            label3 = new Label();
            txtSirketID = new TextBox();
            btnSirketSil = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 65);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 13;
            label3.Text = "Şirket ID:";
            // 
            // txtSirketID
            // 
            txtSirketID.Location = new Point(131, 62);
            txtSirketID.Name = "txtSirketID";
            txtSirketID.Size = new Size(125, 27);
            txtSirketID.TabIndex = 12;
            // 
            // btnSirketSil
            // 
            btnSirketSil.Location = new Point(162, 113);
            btnSirketSil.Name = "btnSirketSil";
            btnSirketSil.Size = new Size(94, 29);
            btnSirketSil.TabIndex = 14;
            btnSirketSil.Text = "Sil";
            btnSirketSil.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 234);
            Controls.Add(btnSirketSil);
            Controls.Add(label3);
            Controls.Add(txtSirketID);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtSirketID;
        private Button btnSirketSil;
    }
}