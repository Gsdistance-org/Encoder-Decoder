using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder_Decoder
{
    public partial class EncoderDecoder : Form
    {
        public EncoderDecoder()
        {
            InitializeComponent();
            Progresslabelc.Text = "Idle";
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Starting to encode...");
            Progresslabelc.Text = "Encoding...";
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
    }
}
