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
        string null1hash = "nT/r";
        string null2hash = "?MtMJMQc";
        string null3hash = "MLYcn,sAvmRurrlC";
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
                if (hashengineselector.Text == "null//2")
                {
                    byte[] data = UnicodeEncoding.Unicode.GetBytes(Encodestring.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(null2hash));
                        using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripdes.CreateEncryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            this.Decodestring.Text = (Convert.ToBase64String(results, 0, results.Length));
                        }
                    }
                }
                else if (hashengineselector.Text == "null//3")
                {
                    byte[] data = UnicodeEncoding.Unicode.GetBytes(Encodestring.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(null3hash));
                        using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripdes.CreateEncryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            this.Decodestring.Text = (Convert.ToBase64String(results, 0, results.Length));
                        }
                    }
                }
                else if (hashengineselector.Text == "null//0")
                {
                    byte[] data = UnicodeEncoding.Unicode.GetBytes(Encodestring.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(this.hashselector.Text));
                        using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripdes.CreateEncryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            this.Decodestring.Text = (Convert.ToBase64String(results, 0, results.Length));
                        }
                    }
                }
                else if (hashengineselector.Text == "null//1")
                {
                    byte[] data = UnicodeEncoding.Unicode.GetBytes(Encodestring.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(null1hash));
                        using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripdes.CreateEncryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            this.Decodestring.Text = (Convert.ToBase64String(results, 0, results.Length));
                        }
                    }
                }
                this.Progresslabelc.Text = ("Done.");
            }
            else if (encodetypeselector.Text == "SHA512")
            {
                SHA512 sHA = SHA512.Create();
                byte[] result = (UnicodeEncoding.Unicode.GetBytes(Encodestring.Text));
                this.Decodestring.Text = (BitConverter.ToString(result).Replace("-", ""));

            }
        }


        private void Encode_Click(object sender, EventArgs e)
        {
            Progresslabelc.Text = "Encoding...";
            string toencode = (this.Encodestring.Text);
            File.WriteAllText(@".\toencode.memory" , toencode);
            Encodefrommem();
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a help button.");
        }
        public void Decodefrommem()
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
                if (hashengineselector.Text == "null//2")
                {
                    byte[] data = Convert.FromBase64String(Decodestring.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(null2hash));
                        using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripdes.CreateDecryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            this.Encodestring.Text = (UnicodeEncoding.Unicode.GetString(results));
                        }
                    }
                }
                else if (hashengineselector.Text == "null//3")
                {
                    byte[] data = Convert.FromBase64String(Decodestring.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(null3hash));
                        using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripdes.CreateDecryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            this.Encodestring.Text = (UnicodeEncoding.Unicode.GetString(results));
                        }
                    }
                }
                else if (hashengineselector.Text == "null//0")
                {
                    byte[] data = Convert.FromBase64String(Decodestring.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(this.hashselector.Text));
                        using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripdes.CreateDecryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            this.Encodestring.Text = (UnicodeEncoding.Unicode.GetString(results));
                        }
                    }
                }
                else if (hashengineselector.Text == "null//1")
                {
                    byte[] data = Convert.FromBase64String(Decodestring.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(null1hash));
                        using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripdes.CreateDecryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            this.Encodestring.Text = (UnicodeEncoding.Unicode.GetString(results));
                        }
                    }
                }
                this.Progresslabelc.Text = ("Done.");
            }
            //TODO - fix this bug
            else if (encodetypeselector.Text == "SHA512")
            {
                SHA512 sHA = SHA512.Create();
                byte[] result = (Convert.FromBase64String(Decodestring.Text));
                this.Encodestring.Text = (BitConverter.ToString(result).Replace("-", ""));

            }
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            Progresslabelc.Text = "Decoding...";
            string todecode = (this.Decodestring.Text);
            File.WriteAllText(@".\todecode.memory", todecode);
            Decodefrommem();
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
            Application.Restart();
        }

        private void engineselector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedengine = (this.hashengineselector.Text);
            File.WriteAllText(@".\engine.memory", selectedengine);
            if (this.hashengineselector.Text == "null//0")
            {
                hashselector.Show();
            }
            else
            {
                hashselector.Hide();
            }
        }

        private void EncoderDecoder_Load(object sender, EventArgs e)
        {
            hashengineselector.Hide();
            Bitcodeselector.Hide();
            hashselector.Hide();
        }

        private void toencodelabel_Click(object sender, EventArgs e)
        {

        }

        private void todecodelabel_Click(object sender, EventArgs e)
        {

        }

        private void encodetypeselector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (encodetypeselector.Text == "Hash")
            {
                hashengineselector.Show();
                Bitcodeselector.Hide();
            }
            else if (encodetypeselector.Text == "Bitcode")
            {
                Bitcodeselector.Show();
                hashengineselector.Hide();
            }
            else if (encodetypeselector.Text == "SHA512")
            {
                Bitcodeselector.Hide();
                hashengineselector.Hide();
            }
            else
            {
                hashengineselector.Hide();
                Bitcodeselector.Hide();
            }
        }

        private void Bitcodeselector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EncoderDecoder_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(@".\todecode.memory");
            File.Delete(@".\toencode.memory");
            File.Delete(@".\engine.memory");
            encoderdecoderservice.Stop();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
    }
}
