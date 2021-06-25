using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder_Decoder
{
    public partial class EncoderDecoder : Form
    {
        string hash = "nT/r4jOx";
        public EncoderDecoder()
        {
            InitializeComponent();
            Progresslabelc.Text = "Idle";
        }

        /// <summary>
        /// this is the start of the encoding decoding code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public void Encodefrommem()
        {
            if (encodetypeselector.Text == "Bitcode")
            {
                string engine = (File.ReadAllText(@".\engine.memory"));
                string encode = (File.ReadAllText(@".\toencode.memory"));
                if (engine == "null//2")
                {
                    double mempart = 5;
                    processengine(mempart, 0);
                }
                else if (engine == "base64")
                {
                    double mempart = 0;
                    processengine(mempart, 1);
                }
                string processengine(double mempart, double isbase)
                {
                    if (isbase == 0)
                    {
                        double encodetxtlenght = (encode.Length);
                        double processedtxt = (0);
                        double toprocessparts = (processedtxt / mempart);
                        while (processedtxt > encodetxtlenght)
                        {

                            processedtxt++;
                        }
                        return ("");
                    }
                    else if (isbase > 1)
                    {
                        MessageBox.Show("Base is not avavible sorry :(");
                        return ("");
                    }
                    else
                    {
                        MessageBox.Show("An error has happened");
                        return ("");
                    }
                }
            }
            else if (encodetypeselector.Text == "Hash")
            {
                byte[] data = UTF8Encoding.UTF8.GetBytes(Encodestring.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripdes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        this.Decodestring.Text = (Convert.ToBase64String(results, 0, results.Length));
                    }
                }
            }
        }


        private void Encode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Starting to encode...");
            Progresslabelc.Text = "Encoding...";
            string toencode = (this.Encodestring.Text);
            File.WriteAllText(@".\toencode.memory" , toencode);
            Encodefrommem();
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a help button.");
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Starting to decode...");
            Progresslabelc.Text = "Decoding...";
        }

        private void updater_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void processer_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void opentext_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void backimage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void engineselector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedengine = (this.engineselector.Text);
            File.WriteAllText(@".\engine.memory", selectedengine);
        }
    }
}
