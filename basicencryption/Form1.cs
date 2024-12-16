using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Md5EncryptionExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sha1Btn_Click(object sender, EventArgs e)
        {

           
            string inputText = passrecTxt.Text;

            // Eğer metin boşsa kullanıcıyı uyar
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Lütfen bir metin girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            string encryptedText = SHA1Hash(inputText);

            sifregosterLbl.Text = "Sha1";
            passhowTxt.Text = encryptedText;
        }
       
        private void md5Btn_Click_1(object sender, EventArgs e)
        {  
            string inputText = passrecTxt.Text;
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Lütfen bir metin girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string encryptedText = MD5Hash(inputText);
            sifregosterLbl.Text = "Md5";
            passhowTxt.Text = encryptedText;
        }
        //Md5 Algortima
        private string MD5Hash(string input)
        {
     
            using (MD5 md5 = MD5.Create())
            {          
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));  
                }

                return sb.ToString();
            }
        }
        //Sha 1 Algoritma
        private string SHA1Hash(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
               for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

     
    }
}
