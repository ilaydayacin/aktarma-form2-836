namespace Aktarma_836
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.btnOde = new System.Windows.Forms.Button();
            this.cbOgrenci = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb50 = new System.Windows.Forms.RadioButton();
            this.rb150 = new System.Windows.Forms.RadioButton();
            this.rb100 = new System.Windows.Forms.RadioButton();
            this.rb200 = new System.Windows.Forms.RadioButton();
            this.btnYukle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bütçe:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(110, 26);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(59, 31);
            this.lblMiktar.TabIndex = 1;
            this.lblMiktar.Text = "200";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb1.Location = new System.Drawing.Point(18, 75);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(139, 29);
            this.rb1.TabIndex = 2;
            this.rb1.TabStop = true;
            this.rb1.Text = "1. Aktarma ";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb2.Location = new System.Drawing.Point(18, 110);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(133, 29);
            this.rb2.TabIndex = 3;
            this.rb2.TabStop = true;
            this.rb2.Text = "2. Aktarma";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb3.Location = new System.Drawing.Point(18, 145);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(133, 29);
            this.rb3.TabIndex = 4;
            this.rb3.TabStop = true;
            this.rb3.Text = "3. Aktarma";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb4.Location = new System.Drawing.Point(18, 180);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(133, 29);
            this.rb4.TabIndex = 5;
            this.rb4.TabStop = true;
            this.rb4.Text = "4. Aktarma";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // btnOde
            // 
            this.btnOde.BackColor = System.Drawing.Color.Red;
            this.btnOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.ForeColor = System.Drawing.Color.White;
            this.btnOde.Location = new System.Drawing.Point(116, 225);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(150, 110);
            this.btnOde.TabIndex = 6;
            this.btnOde.Text = "Öde";
            this.btnOde.UseVisualStyleBackColor = false;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // cbOgrenci
            // 
            this.cbOgrenci.AutoSize = true;
            this.cbOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOgrenci.Location = new System.Drawing.Point(361, 145);
            this.cbOgrenci.Name = "cbOgrenci";
            this.cbOgrenci.Size = new System.Drawing.Size(106, 29);
            this.cbOgrenci.TabIndex = 7;
            this.cbOgrenci.Text = "Öğrenci";
            this.cbOgrenci.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(255, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 100);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tam; \r\n1. Aktarma; 15$\r\n2. Aktarma; 12.20$\r\n3. Aktarma; 8$\r\n4. Aktarma; 9.60$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(458, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 100);
            this.label3.TabIndex = 9;
            this.label3.Text = "Öğrenci;\r\n1. Aktarma; 8$\r\n2. Aktarma; 6.20$\r\n3. Aktarma; 4$\r\n4. Aktarma; 7.50$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(458, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bakiye Yükleme";
            // 
            // rb50
            // 
            this.rb50.AutoSize = true;
            this.rb50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb50.Location = new System.Drawing.Point(462, 257);
            this.rb50.Name = "rb50";
            this.rb50.Size = new System.Drawing.Size(54, 24);
            this.rb50.TabIndex = 11;
            this.rb50.TabStop = true;
            this.rb50.Text = "50$";
            this.rb50.UseVisualStyleBackColor = true;
            // 
            // rb150
            // 
            this.rb150.AutoSize = true;
            this.rb150.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb150.Location = new System.Drawing.Point(552, 257);
            this.rb150.Name = "rb150";
            this.rb150.Size = new System.Drawing.Size(63, 24);
            this.rb150.TabIndex = 12;
            this.rb150.TabStop = true;
            this.rb150.Text = "150$";
            this.rb150.UseVisualStyleBackColor = true;
            // 
            // rb100
            // 
            this.rb100.AutoSize = true;
            this.rb100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb100.Location = new System.Drawing.Point(453, 287);
            this.rb100.Name = "rb100";
            this.rb100.Size = new System.Drawing.Size(63, 24);
            this.rb100.TabIndex = 13;
            this.rb100.TabStop = true;
            this.rb100.Text = "100$";
            this.rb100.UseVisualStyleBackColor = true;
            // 
            // rb200
            // 
            this.rb200.AutoSize = true;
            this.rb200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb200.Location = new System.Drawing.Point(552, 287);
            this.rb200.Name = "rb200";
            this.rb200.Size = new System.Drawing.Size(63, 24);
            this.rb200.TabIndex = 14;
            this.rb200.TabStop = true;
            this.rb200.Text = "200$";
            this.rb200.UseVisualStyleBackColor = true;
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.Lime;
            this.btnYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukle.Location = new System.Drawing.Point(453, 317);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(162, 54);
            this.btnYukle.TabIndex = 15;
            this.btnYukle.Text = "Bakiye Yükle";
            this.btnYukle.UseVisualStyleBackColor = false;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(710, 409);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.rb200);
            this.Controls.Add(this.rb100);
            this.Controls.Add(this.rb150);
            this.Controls.Add(this.rb50);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOgrenci);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.CheckBox cbOgrenci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb50;
        private System.Windows.Forms.RadioButton rb150;
        private System.Windows.Forms.RadioButton rb100;
        private System.Windows.Forms.RadioButton rb200;
        private System.Windows.Forms.Button btnYukle;
    }
}

