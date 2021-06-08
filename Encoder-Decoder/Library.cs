using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder_Decoder
{
    static class Library
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EncoderDecoder());
        }
        static void Null1()
        {
            string a = "?k9K3";
            string b = "x3*A5";
            string c = "~a3B9";
            string d = "5Mg9&";
            string e = "";
        }
    }
}
