
namespace Encoder_Decoder
{
    partial class EncoderDecoder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncoderDecoder));
            this.updater = new System.ComponentModel.BackgroundWorker();
            this.fontselector = new System.Windows.Forms.FontDialog();
            this.Encodestring = new System.Windows.Forms.RichTextBox();
            this.toencodelabel = new System.Windows.Forms.Label();
            this.Encode = new System.Windows.Forms.Button();
            this.Decodestring = new System.Windows.Forms.RichTextBox();
            this.todecodelabel = new System.Windows.Forms.Label();
            this.Decode = new System.Windows.Forms.Button();
            this.backimage = new System.Windows.Forms.NotifyIcon(this.components);
            this.encoderdecoderservice = new System.ServiceProcess.ServiceController();
            this.help = new System.Windows.Forms.HelpProvider();
            this.process1 = new System.Diagnostics.Process();
            this.helpbutton = new System.Windows.Forms.Button();
            this.Progresslabel = new System.Windows.Forms.Label();
            this.Progresslabelc = new System.Windows.Forms.Label();
            this.processer = new System.ComponentModel.BackgroundWorker();
            this.opentext = new System.Windows.Forms.OpenFileDialog();
            this.hashengineselector = new System.Windows.Forms.ComboBox();
            this.encodetypeselector = new System.Windows.Forms.ComboBox();
            this.hashselector = new System.Windows.Forms.RichTextBox();
            this.Bitcodeselector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // updater
            // 
            this.updater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updater_DoWork);
            // 
            // fontselector
            // 
            this.fontselector.FontMustExist = true;
            // 
            // Encodestring
            // 
            this.Encodestring.Location = new System.Drawing.Point(31, 32);
            this.Encodestring.Name = "Encodestring";
            this.Encodestring.Size = new System.Drawing.Size(100, 96);
            this.Encodestring.TabIndex = 0;
            this.Encodestring.Text = "";
            // 
            // toencodelabel
            // 
            this.toencodelabel.AutoSize = true;
            this.toencodelabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toencodelabel.Location = new System.Drawing.Point(48, 9);
            this.toencodelabel.Name = "toencodelabel";
            this.toencodelabel.Size = new System.Drawing.Size(69, 16);
            this.toencodelabel.TabIndex = 1;
            this.toencodelabel.Text = "To Encode";
            this.toencodelabel.Click += new System.EventHandler(this.toencodelabel_Click);
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(43, 130);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(75, 26);
            this.Encode.TabIndex = 2;
            this.Encode.Text = "Encode";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // Decodestring
            // 
            this.Decodestring.Location = new System.Drawing.Point(31, 179);
            this.Decodestring.Name = "Decodestring";
            this.Decodestring.Size = new System.Drawing.Size(100, 96);
            this.Decodestring.TabIndex = 3;
            this.Decodestring.Text = "";
            // 
            // todecodelabel
            // 
            this.todecodelabel.AutoSize = true;
            this.todecodelabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.todecodelabel.Location = new System.Drawing.Point(39, 156);
            this.todecodelabel.Name = "todecodelabel";
            this.todecodelabel.Size = new System.Drawing.Size(67, 16);
            this.todecodelabel.TabIndex = 4;
            this.todecodelabel.Text = "To Decode";
            this.todecodelabel.Click += new System.EventHandler(this.todecodelabel_Click);
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(43, 281);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(75, 33);
            this.Decode.TabIndex = 5;
            this.Decode.Text = "Decode";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // backimage
            // 
            this.backimage.Icon = ((System.Drawing.Icon)(resources.GetObject("backimage.Icon")));
            this.backimage.Text = "Encoder-Decoder";
            this.backimage.Visible = true;
            this.backimage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.backimage_MouseDoubleClick);
            // 
            // encoderdecoderservice
            // 
            this.encoderdecoderservice.ServiceName = "encoderdecoder";
            // 
            // help
            // 
            this.help.HelpNamespace = "C:\\Users\\MÜRVET YÜZDEN ŞEN\\source\\repos\\Encoder-Decoder\\Encoder-Decoder\\htmlhelp\\" +
    "encoderdecoderhelp.chm";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = true;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // helpbutton
            // 
            this.helpbutton.Location = new System.Drawing.Point(-1, -1);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(24, 23);
            this.helpbutton.TabIndex = 6;
            this.helpbutton.Text = "?";
            this.helpbutton.UseVisualStyleBackColor = true;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            // 
            // Progresslabel
            // 
            this.Progresslabel.AutoSize = true;
            this.Progresslabel.Location = new System.Drawing.Point(258, 2);
            this.Progresslabel.Name = "Progresslabel";
            this.Progresslabel.Size = new System.Drawing.Size(58, 16);
            this.Progresslabel.TabIndex = 7;
            this.Progresslabel.Text = "Progress:";
            // 
            // Progresslabelc
            // 
            this.Progresslabelc.AutoSize = true;
            this.Progresslabelc.Location = new System.Drawing.Point(258, 22);
            this.Progresslabelc.Name = "Progresslabelc";
            this.Progresslabelc.Size = new System.Drawing.Size(0, 16);
            this.Progresslabelc.TabIndex = 8;
            // 
            // processer
            // 
            this.processer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.processer_DoWork);
            // 
            // opentext
            // 
            this.opentext.FileName = "*.txt";
            this.opentext.FileOk += new System.ComponentModel.CancelEventHandler(this.opentext_FileOk);
            // 
            // hashengineselector
            // 
            this.hashengineselector.FormattingEnabled = true;
            this.hashengineselector.Items.AddRange(new object[] {
            "null//0",
            "null//1",
            "null//2",
            "null//3"});
            this.hashengineselector.Location = new System.Drawing.Point(169, 100);
            this.hashengineselector.Name = "hashengineselector";
            this.hashengineselector.Size = new System.Drawing.Size(121, 24);
            this.hashengineselector.TabIndex = 9;
            this.hashengineselector.SelectedIndexChanged += new System.EventHandler(this.engineselector_SelectedIndexChanged);
            // 
            // encodetypeselector
            // 
            this.encodetypeselector.FormattingEnabled = true;
            this.encodetypeselector.Items.AddRange(new object[] {
            "Hash",
            "Bitcode",
            "Slash",
            "None",
            "SHA512"});
            this.encodetypeselector.Location = new System.Drawing.Point(169, 55);
            this.encodetypeselector.Name = "encodetypeselector";
            this.encodetypeselector.Size = new System.Drawing.Size(121, 24);
            this.encodetypeselector.TabIndex = 10;
            this.encodetypeselector.SelectedIndexChanged += new System.EventHandler(this.encodetypeselector_SelectedIndexChanged);
            // 
            // hashselector
            // 
            this.hashselector.Location = new System.Drawing.Point(169, 244);
            this.hashselector.Name = "hashselector";
            this.hashselector.Size = new System.Drawing.Size(121, 31);
            this.hashselector.TabIndex = 11;
            this.hashselector.Text = "";
            // 
            // Bitcodeselector
            // 
            this.Bitcodeselector.FormattingEnabled = true;
            this.Bitcodeselector.Location = new System.Drawing.Point(169, 100);
            this.Bitcodeselector.Name = "Bitcodeselector";
            this.Bitcodeselector.Size = new System.Drawing.Size(121, 24);
            this.Bitcodeselector.TabIndex = 12;
            this.Bitcodeselector.SelectedIndexChanged += new System.EventHandler(this.Bitcodeselector_SelectedIndexChanged);
            // 
            // EncoderDecoder
            // 
            this.AccessibleDescription = "This is a encoder/decoder program for null and others";
            this.AccessibleName = "EncoderDecoder";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(329, 353);
            this.Controls.Add(this.Bitcodeselector);
            this.Controls.Add(this.hashselector);
            this.Controls.Add(this.encodetypeselector);
            this.Controls.Add(this.hashengineselector);
            this.Controls.Add(this.Progresslabelc);
            this.Controls.Add(this.Progresslabel);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.todecodelabel);
            this.Controls.Add(this.Decodestring);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.toencodelabel);
            this.Controls.Add(this.Encodestring);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.help.SetHelpString(this, "");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EncoderDecoder";
            this.help.SetShowHelp(this, true);
            this.Text = "Encoder-Decoder";
            this.Load += new System.EventHandler(this.EncoderDecoder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.ComponentModel.BackgroundWorker updater;
        public System.Windows.Forms.FontDialog fontselector;
        private System.Windows.Forms.Label toencodelabel;
        public System.Windows.Forms.Button Encode;
        public System.Windows.Forms.RichTextBox Decodestring;
        public System.Windows.Forms.RichTextBox Encodestring;
        private System.Windows.Forms.Label todecodelabel;
        public System.Windows.Forms.Button Decode;
        public System.Windows.Forms.NotifyIcon backimage;
        private System.ServiceProcess.ServiceController encoderdecoderservice;
        private System.Windows.Forms.HelpProvider help;
        public System.Diagnostics.Process process1;
        private System.Windows.Forms.Button helpbutton;
        public System.Windows.Forms.Label Progresslabel;
        public System.Windows.Forms.Label Progresslabelc;
        private System.ComponentModel.BackgroundWorker processer;
        public System.Windows.Forms.OpenFileDialog opentext;
        private System.Windows.Forms.ComboBox hashengineselector;
        private System.Windows.Forms.ComboBox encodetypeselector;
        private System.Windows.Forms.RichTextBox hashselector;
        private System.Windows.Forms.ComboBox Bitcodeselector;
    }
}

