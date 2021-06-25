
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
            this.engineselector = new System.Windows.Forms.ComboBox();
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
            this.Encodestring.Location = new System.Drawing.Point(150, 50);
            this.Encodestring.Name = "Encodestring";
            this.Encodestring.Size = new System.Drawing.Size(100, 96);
            this.Encodestring.TabIndex = 0;
            this.Encodestring.Text = "";
            // 
            // toencodelabel
            // 
            this.toencodelabel.AutoSize = true;
            this.toencodelabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toencodelabel.Location = new System.Drawing.Point(158, 27);
            this.toencodelabel.Name = "toencodelabel";
            this.toencodelabel.Size = new System.Drawing.Size(83, 20);
            this.toencodelabel.TabIndex = 1;
            this.toencodelabel.Text = "To Encode";
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(69, 72);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(75, 33);
            this.Encode.TabIndex = 2;
            this.Encode.Text = "Encode";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // Decodestring
            // 
            this.Decodestring.Location = new System.Drawing.Point(150, 183);
            this.Decodestring.Name = "Decodestring";
            this.Decodestring.Size = new System.Drawing.Size(100, 96);
            this.Decodestring.TabIndex = 3;
            this.Decodestring.Text = "";
            // 
            // todecodelabel
            // 
            this.todecodelabel.AutoSize = true;
            this.todecodelabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.todecodelabel.Location = new System.Drawing.Point(158, 160);
            this.todecodelabel.Name = "todecodelabel";
            this.todecodelabel.Size = new System.Drawing.Size(81, 20);
            this.todecodelabel.TabIndex = 4;
            this.todecodelabel.Text = "To Decode";
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(69, 207);
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
            this.helpbutton.Location = new System.Drawing.Point(571, 12);
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
            this.Progresslabel.Location = new System.Drawing.Point(505, 140);
            this.Progresslabel.Name = "Progresslabel";
            this.Progresslabel.Size = new System.Drawing.Size(72, 20);
            this.Progresslabel.TabIndex = 7;
            this.Progresslabel.Text = "Progress:";
            // 
            // Progresslabelc
            // 
            this.Progresslabelc.AutoSize = true;
            this.Progresslabelc.Location = new System.Drawing.Point(505, 160);
            this.Progresslabelc.Name = "Progresslabelc";
            this.Progresslabelc.Size = new System.Drawing.Size(0, 20);
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
            // engineselector
            // 
            this.engineselector.FormattingEnabled = true;
            this.engineselector.Items.AddRange(new object[] {
            "null//2",
            "base64"});
            this.engineselector.Location = new System.Drawing.Point(474, 183);
            this.engineselector.Name = "engineselector";
            this.engineselector.Size = new System.Drawing.Size(121, 28);
            this.engineselector.TabIndex = 9;
            this.engineselector.SelectedIndexChanged += new System.EventHandler(this.engineselector_SelectedIndexChanged);
            // 
            // EncoderDecoder
            // 
            this.AccessibleDescription = "This is a encoder/decoder program for null and others";
            this.AccessibleName = "EncoderDecoder";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(607, 353);
            this.Controls.Add(this.engineselector);
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
            this.Text = "s";
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
        private System.Windows.Forms.ComboBox engineselector;
    }
}

