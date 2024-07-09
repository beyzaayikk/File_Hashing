namespace crpytFile
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
            this.dosyaYukle_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dosyaHash = new System.Windows.Forms.Button();
            this.md5_btn = new System.Windows.Forms.RadioButton();
            this.sha256_btn = new System.Windows.Forms.RadioButton();
            this.sha512_btn = new System.Windows.Forms.RadioButton();
            this.listBox_hash = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dosyaYukle_btn
            // 
            this.dosyaYukle_btn.Location = new System.Drawing.Point(63, 51);
            this.dosyaYukle_btn.Name = "dosyaYukle_btn";
            this.dosyaYukle_btn.Size = new System.Drawing.Size(135, 57);
            this.dosyaYukle_btn.TabIndex = 0;
            this.dosyaYukle_btn.Text = "Dosya Yükle";
            this.dosyaYukle_btn.UseVisualStyleBackColor = true;
            this.dosyaYukle_btn.Click += new System.EventHandler(this.dosyaYukle_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dosyaHash
            // 
            this.dosyaHash.Location = new System.Drawing.Point(63, 160);
            this.dosyaHash.Name = "dosyaHash";
            this.dosyaHash.Size = new System.Drawing.Size(135, 57);
            this.dosyaHash.TabIndex = 2;
            this.dosyaHash.Text = "Dosya Hash";
            this.dosyaHash.UseVisualStyleBackColor = true;
            this.dosyaHash.Click += new System.EventHandler(this.dosyaHash_Click);
            // 
            // md5_btn
            // 
            this.md5_btn.AutoSize = true;
            this.md5_btn.Location = new System.Drawing.Point(251, 169);
            this.md5_btn.Name = "md5_btn";
            this.md5_btn.Size = new System.Drawing.Size(56, 20);
            this.md5_btn.TabIndex = 3;
            this.md5_btn.TabStop = true;
            this.md5_btn.Text = "MD5";
            this.md5_btn.UseVisualStyleBackColor = true;
            // 
            // sha256_btn
            // 
            this.sha256_btn.AutoSize = true;
            this.sha256_btn.Location = new System.Drawing.Point(401, 169);
            this.sha256_btn.Name = "sha256_btn";
            this.sha256_btn.Size = new System.Drawing.Size(77, 20);
            this.sha256_btn.TabIndex = 4;
            this.sha256_btn.TabStop = true;
            this.sha256_btn.Text = "SHA256";
            this.sha256_btn.UseVisualStyleBackColor = true;
            // 
            // sha512_btn
            // 
            this.sha512_btn.AutoSize = true;
            this.sha512_btn.Location = new System.Drawing.Point(565, 169);
            this.sha512_btn.Name = "sha512_btn";
            this.sha512_btn.Size = new System.Drawing.Size(77, 20);
            this.sha512_btn.TabIndex = 5;
            this.sha512_btn.TabStop = true;
            this.sha512_btn.Text = "SHA512";
            this.sha512_btn.UseVisualStyleBackColor = true;
            // 
            // listBox_hash
            // 
            this.listBox_hash.FormattingEnabled = true;
            this.listBox_hash.ItemHeight = 16;
            this.listBox_hash.Location = new System.Drawing.Point(215, 244);
            this.listBox_hash.Name = "listBox_hash";
            this.listBox_hash.Size = new System.Drawing.Size(995, 404);
            this.listBox_hash.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 673);
            this.Controls.Add(this.listBox_hash);
            this.Controls.Add(this.sha512_btn);
            this.Controls.Add(this.sha256_btn);
            this.Controls.Add(this.md5_btn);
            this.Controls.Add(this.dosyaHash);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dosyaYukle_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dosyaYukle_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dosyaHash;
        private System.Windows.Forms.RadioButton md5_btn;
        private System.Windows.Forms.RadioButton sha256_btn;
        private System.Windows.Forms.RadioButton sha512_btn;
        private System.Windows.Forms.ListBox listBox_hash;
    }
}

