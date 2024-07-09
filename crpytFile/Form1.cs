using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Utilities.IO;

namespace crpytFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dosyaYukle_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = openFileDialog.FileName;
            }
        }


        private void dosyaHash_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text;

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Lütfen bir dosya yükleyin.");
                return;
            }

            string hashAlgorithm = SelectHashAlgorithm();
            if (hashAlgorithm == null)
            {
                MessageBox.Show("Lütfen bir hash algoritması seçin.");
                return;
            }

            listBox_hash.Items.Clear();
            HashFile(filePath, hashAlgorithm, 1024 * 1024); // 1MB
        }
        private string SelectHashAlgorithm()
        {
            if (md5_btn.Checked)
                return "MD5";
            else if (sha256_btn.Checked)
                return "SHA-256";
            else if (sha512_btn.Checked)
                return "SHA-512";
            else
                return null;
        }



        private void HashFile(string inputFile, string hashAlgorithm, int chunkSize)
        {
            string tempFilePath = Path.GetTempFileName();
            using (FileStream fs = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            using (FileStream tempFileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
            {
                int index = 0;
                while (true)
                {
                    byte[] buffer = new byte[chunkSize];
                    int bytesRead = fs.Read(buffer, 0, chunkSize);
                    if (bytesRead == 0)
                        break;

                    string hash = ComputeHash(buffer, bytesRead, hashAlgorithm);
                    string chunkFileName = $"{inputFile}.part{index}.{hashAlgorithm}.hash";
                    File.WriteAllText(chunkFileName, hash);

                    listBox_hash.Items.Add($"Parça {index}: {hash}");
                    index++;


                    byte[] hashBytes = Encoding.UTF8.GetBytes(hash);
                    tempFileStream.Write(hashBytes, 0, hashBytes.Length);
                }
            }

            MessageBox.Show("Dosya parçaları başarıyla hash'lendi.");




        }


        private string ComputeHash(byte[] buffer, int bytesRead, string hashAlgorithm)
        {
            using (System.Security.Cryptography.HashAlgorithm algorithm = System.Security.Cryptography.HashAlgorithm.Create(hashAlgorithm))
            {
                if (algorithm == null)
                    throw new InvalidOperationException($"Unsupported hash algorithm: {hashAlgorithm}");

                byte[] hashBytes = algorithm.ComputeHash(buffer, 0, bytesRead);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }



    }
}
