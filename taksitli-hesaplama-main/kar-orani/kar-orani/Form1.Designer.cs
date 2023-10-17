namespace kar_orani
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPeşin = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblTaksit = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb12);
            this.groupBox1.Controls.Add(this.rb9);
            this.groupBox1.Controls.Add(this.rb6);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rbPeşin);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEÇİM YAP";
            // 
            // rbPeşin
            // 
            this.rbPeşin.AutoSize = true;
            this.rbPeşin.Checked = true;
            this.rbPeşin.Location = new System.Drawing.Point(12, 19);
            this.rbPeşin.Name = "rbPeşin";
            this.rbPeşin.Size = new System.Drawing.Size(80, 17);
            this.rbPeşin.TabIndex = 0;
            this.rbPeşin.TabStop = true;
            this.rbPeşin.Text = "PEŞİN (%0)";
            this.rbPeşin.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(12, 42);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(95, 17);
            this.rb2.TabIndex = 2;
            this.rb2.Text = "2 TAKSİT (%2)";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(12, 65);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(95, 17);
            this.rb6.TabIndex = 3;
            this.rb6.Text = "6 TAKSİT (%4)";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.Location = new System.Drawing.Point(12, 88);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(95, 17);
            this.rb9.TabIndex = 4;
            this.rb9.Text = "9 TAKSİT (%7)";
            this.rb9.UseVisualStyleBackColor = true;
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.Location = new System.Drawing.Point(12, 111);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(107, 17);
            this.rb12.TabIndex = 5;
            this.rb12.Text = "12 TAKSİT (%10)";
            this.rb12.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FİYAT:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(180, 23);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 7;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(180, 49);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 23);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(134, 92);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(94, 13);
            this.lblToplam.TabIndex = 9;
            this.lblToplam.Text = "TOPLAM TUTAR:";
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Location = new System.Drawing.Point(134, 114);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(88, 13);
            this.lblTaksit.TabIndex = 10;
            this.lblTaksit.Text = "TAKSİT TUTAR:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 149);
            this.Controls.Add(this.lblTaksit);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rbPeşin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblTaksit;
    }
}

