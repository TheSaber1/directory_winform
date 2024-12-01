namespace rehberarayuz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonekleme = new Button();
            ımageList1 = new ImageList(components);
            buttonsilme = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            buttonduzenle = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            soyisimtextbox = new TextBox();
            isimtextbox = new TextBox();
            yastextbox = new MaskedTextBox();
            SuspendLayout();
            // 
            // buttonekleme
            // 
            buttonekleme.BackColor = Color.ForestGreen;
            buttonekleme.FlatStyle = FlatStyle.Popup;
            buttonekleme.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonekleme.ForeColor = SystemColors.ControlText;
            buttonekleme.ImageAlign = ContentAlignment.MiddleLeft;
            buttonekleme.ImageKey = "Kyo-Tux-Delikate-Add.64.png";
            buttonekleme.ImageList = ımageList1;
            buttonekleme.Location = new Point(334, 58);
            buttonekleme.Name = "buttonekleme";
            buttonekleme.Size = new Size(193, 70);
            buttonekleme.TabIndex = 0;
            buttonekleme.Text = "Kayıt Ekle";
            buttonekleme.TextAlign = ContentAlignment.MiddleRight;
            buttonekleme.UseVisualStyleBackColor = false;
            buttonekleme.Click += buttonekleme_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Papirus-Team-Papirus-Status-User-trash-full.64.png");
            ımageList1.Images.SetKeyName(1, "Kyo-Tux-Delikate-Add.64.png");
            ımageList1.Images.SetKeyName(2, "Oxygen-Icons.org-Oxygen-Actions-document-save.64.png");
            ımageList1.Images.SetKeyName(3, "edit.png");
            // 
            // buttonsilme
            // 
            buttonsilme.BackColor = Color.FromArgb(200, 0, 0);
            buttonsilme.FlatStyle = FlatStyle.Popup;
            buttonsilme.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonsilme.ImageAlign = ContentAlignment.MiddleLeft;
            buttonsilme.ImageKey = "Papirus-Team-Papirus-Status-User-trash-full.64.png";
            buttonsilme.ImageList = ımageList1;
            buttonsilme.Location = new Point(334, 134);
            buttonsilme.Name = "buttonsilme";
            buttonsilme.RightToLeft = RightToLeft.No;
            buttonsilme.Size = new Size(193, 70);
            buttonsilme.TabIndex = 1;
            buttonsilme.Text = "Kayıt Sil";
            buttonsilme.TextAlign = ContentAlignment.MiddleRight;
            buttonsilme.UseVisualStyleBackColor = false;
            buttonsilme.Click += buttonsilme_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSlateGray;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(79, 9);
            label1.Name = "label1";
            label1.Size = new Size(356, 32);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Bilgi Toplama Formu";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightSlateGray;
            listBox1.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(12, 298);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(515, 193);
            listBox1.TabIndex = 3;
            // 
            // buttonduzenle
            // 
            buttonduzenle.BackColor = SystemColors.MenuHighlight;
            buttonduzenle.FlatStyle = FlatStyle.Popup;
            buttonduzenle.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonduzenle.ForeColor = SystemColors.ControlText;
            buttonduzenle.ImageAlign = ContentAlignment.MiddleLeft;
            buttonduzenle.ImageKey = "edit.png";
            buttonduzenle.ImageList = ımageList1;
            buttonduzenle.Location = new Point(334, 210);
            buttonduzenle.Name = "buttonduzenle";
            buttonduzenle.Size = new Size(193, 70);
            buttonduzenle.TabIndex = 4;
            buttonduzenle.Text = "Düzenle";
            buttonduzenle.TextAlign = ContentAlignment.MiddleRight;
            buttonduzenle.UseVisualStyleBackColor = false;
            buttonduzenle.Click += buttonduzenle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Tai Le", 14.25F);
            label2.Location = new Point(32, 58);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 5;
            label2.Text = "İsim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 14.25F);
            label3.Location = new Point(32, 134);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 6;
            label3.Text = "Soyisim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Tai Le", 14.25F);
            label4.Location = new Point(32, 210);
            label4.Name = "label4";
            label4.Size = new Size(40, 23);
            label4.TabIndex = 7;
            label4.Text = "Yaş";
            // 
            // soyisimtextbox
            // 
            soyisimtextbox.Location = new Point(32, 160);
            soyisimtextbox.Name = "soyisimtextbox";
            soyisimtextbox.Size = new Size(168, 23);
            soyisimtextbox.TabIndex = 8;
            soyisimtextbox.KeyPress += soyisimtextbox_KeyPress;
            // 
            // isimtextbox
            // 
            isimtextbox.Location = new Point(32, 84);
            isimtextbox.Name = "isimtextbox";
            isimtextbox.Size = new Size(168, 23);
            isimtextbox.TabIndex = 8;
            isimtextbox.KeyPress += isimtextbox_KeyPress;
            // 
            // yastextbox
            // 
            yastextbox.Location = new Point(32, 236);
            yastextbox.Mask = "000";
            yastextbox.Name = "yastextbox";
            yastextbox.Size = new Size(168, 23);
            yastextbox.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(534, 511);
            Controls.Add(yastextbox);
            Controls.Add(isimtextbox);
            Controls.Add(soyisimtextbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonduzenle);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(buttonsilme);
            Controls.Add(buttonekleme);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonekleme;
        private Button buttonsilme;
        private ImageList ımageList1;
        private Label label1;
        private ListBox listBox1;
        private Button buttonduzenle;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox soyisimtextbox;
        private TextBox isimtextbox;
        private MaskedTextBox yastextbox;
    }
}
