namespace Md5EncryptionExample
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.passrecTxt = new System.Windows.Forms.TextBox();
            this.sha1Btn = new System.Windows.Forms.Button();
            this.md5Btn = new System.Windows.Forms.Button();
            this.passhowTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sifregosterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passrecTxt
            // 
            this.passrecTxt.Location = new System.Drawing.Point(158, 56);
            this.passrecTxt.Multiline = true;
            this.passrecTxt.Name = "passrecTxt";
            this.passrecTxt.Size = new System.Drawing.Size(212, 55);
            this.passrecTxt.TabIndex = 0;
           
            // 
            // sha1Btn
            // 
            this.sha1Btn.Location = new System.Drawing.Point(591, 56);
            this.sha1Btn.Name = "sha1Btn";
            this.sha1Btn.Size = new System.Drawing.Size(120, 55);
            this.sha1Btn.TabIndex = 1;
            this.sha1Btn.Text = "Sha1";
            this.sha1Btn.UseVisualStyleBackColor = true;
            this.sha1Btn.Click += new System.EventHandler(this.sha1Btn_Click);
            // 
            // md5Btn
            // 
            this.md5Btn.Location = new System.Drawing.Point(591, 117);
            this.md5Btn.Name = "md5Btn";
            this.md5Btn.Size = new System.Drawing.Size(120, 52);
            this.md5Btn.TabIndex = 2;
            this.md5Btn.Text = "Md5";
            this.md5Btn.UseVisualStyleBackColor = true;
            this.md5Btn.Click += new System.EventHandler(this.md5Btn_Click_1);
            // 
            // passhowTxt
            // 
            this.passhowTxt.Location = new System.Drawing.Point(158, 183);
            this.passhowTxt.Multiline = true;
            this.passhowTxt.Name = "passhowTxt";
            this.passhowTxt.Size = new System.Drawing.Size(291, 77);
            this.passhowTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(43, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Metin Giriniz =";
            // 
            // sifregosterLbl
            // 
            this.sifregosterLbl.AutoSize = true;
            this.sifregosterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sifregosterLbl.Location = new System.Drawing.Point(106, 210);
            this.sifregosterLbl.Name = "sifregosterLbl";
            this.sifregosterLbl.Size = new System.Drawing.Size(0, 20);
            this.sifregosterLbl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sifregosterLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passhowTxt);
            this.Controls.Add(this.md5Btn);
            this.Controls.Add(this.sha1Btn);
            this.Controls.Add(this.passrecTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Basit Metin Şifreleyici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passrecTxt;
        private System.Windows.Forms.Button sha1Btn;
        private System.Windows.Forms.Button md5Btn;
        private System.Windows.Forms.TextBox passhowTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sifregosterLbl;
    }
}

