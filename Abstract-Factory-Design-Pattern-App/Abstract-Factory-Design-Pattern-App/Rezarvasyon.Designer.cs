
namespace Abstract_Factory_Design_Pattern_App
{
    partial class Rezarvasyon
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
            this.cbKonaklama = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbUlasim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tpDonus = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tpGidis = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbLokasyon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSifre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtKimlikNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAdSoyad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEkle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnJsonSeyahat = new Guna.UI2.WinForms.Guna2Button();
            this.btnJsonKullaniciBilgi = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cbKonaklama
            // 
            this.cbKonaklama.BackColor = System.Drawing.Color.Transparent;
            this.cbKonaklama.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKonaklama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKonaklama.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbKonaklama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbKonaklama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbKonaklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbKonaklama.ItemHeight = 30;
            this.cbKonaklama.Items.AddRange(new object[] {
            "Otel",
            "Cadir"});
            this.cbKonaklama.Location = new System.Drawing.Point(505, 380);
            this.cbKonaklama.Margin = new System.Windows.Forms.Padding(4);
            this.cbKonaklama.Name = "cbKonaklama";
            this.cbKonaklama.Size = new System.Drawing.Size(268, 36);
            this.cbKonaklama.TabIndex = 39;
            // 
            // cbUlasim
            // 
            this.cbUlasim.BackColor = System.Drawing.Color.Transparent;
            this.cbUlasim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUlasim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUlasim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUlasim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUlasim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbUlasim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbUlasim.ItemHeight = 30;
            this.cbUlasim.Items.AddRange(new object[] {
            "Ucak",
            "Otobus"});
            this.cbUlasim.Location = new System.Drawing.Point(507, 260);
            this.cbUlasim.Margin = new System.Windows.Forms.Padding(4);
            this.cbUlasim.Name = "cbUlasim";
            this.cbUlasim.Size = new System.Drawing.Size(268, 36);
            this.cbUlasim.TabIndex = 38;
            // 
            // tpDonus
            // 
            this.tpDonus.Checked = true;
            this.tpDonus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpDonus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tpDonus.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tpDonus.Location = new System.Drawing.Point(507, 145);
            this.tpDonus.Margin = new System.Windows.Forms.Padding(4);
            this.tpDonus.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tpDonus.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tpDonus.Name = "tpDonus";
            this.tpDonus.Size = new System.Drawing.Size(267, 44);
            this.tpDonus.TabIndex = 37;
            this.tpDonus.Value = new System.DateTime(2022, 5, 24, 14, 26, 43, 526);
            // 
            // tpGidis
            // 
            this.tpGidis.Checked = true;
            this.tpGidis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpGidis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tpGidis.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tpGidis.Location = new System.Drawing.Point(505, 55);
            this.tpGidis.Margin = new System.Windows.Forms.Padding(4);
            this.tpGidis.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tpGidis.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tpGidis.Name = "tpGidis";
            this.tpGidis.Size = new System.Drawing.Size(269, 44);
            this.tpGidis.TabIndex = 36;
            this.tpGidis.Value = new System.DateTime(2022, 5, 24, 14, 26, 43, 526);
            // 
            // cbLokasyon
            // 
            this.cbLokasyon.BackColor = System.Drawing.Color.Transparent;
            this.cbLokasyon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLokasyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLokasyon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLokasyon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLokasyon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLokasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLokasyon.ItemHeight = 30;
            this.cbLokasyon.Items.AddRange(new object[] {
            "Marmaris ",
            "Fethiye",
            "Milas",
            "İstanbul",
            "Antalya",
            "İzmir",
            "Kusadası"});
            this.cbLokasyon.Location = new System.Drawing.Point(577, -87);
            this.cbLokasyon.Margin = new System.Windows.Forms.Padding(4);
            this.cbLokasyon.Name = "cbLokasyon";
            this.cbLokasyon.Size = new System.Drawing.Size(268, 36);
            this.cbLokasyon.TabIndex = 35;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(153, 159);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(249, 30);
            this.guna2HtmlLabel1.TabIndex = 34;
            this.guna2HtmlLabel1.Text = "Seyahat Donus Tarihi";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Transparent;
            this.txtSifre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtSifre.Location = new System.Drawing.Point(159, 275);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(245, 30);
            this.txtSifre.TabIndex = 33;
            this.txtSifre.Text = "Ulasim Tipini Seciniz";
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.BackColor = System.Drawing.Color.Transparent;
            this.txtKimlikNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtKimlikNo.Location = new System.Drawing.Point(165, 55);
            this.txtKimlikNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(237, 30);
            this.txtKimlikNo.TabIndex = 32;
            this.txtKimlikNo.Text = "Seyahat Gidis Tarihi";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.txtAdSoyad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtAdSoyad.Location = new System.Drawing.Point(-48, -87);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(510, 30);
            this.txtAdSoyad.TabIndex = 31;
            this.txtAdSoyad.Text = "Seyahat etmek istediginiz lokasyonu seciniz";
            // 
            // btnEkle
            // 
            this.btnEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEkle.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEkle.FillColor2 = System.Drawing.Color.Blue;
            this.btnEkle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(575, 596);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(201, 68);
            this.btnEkle.TabIndex = 30;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(106, 395);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(295, 30);
            this.guna2HtmlLabel2.TabIndex = 29;
            this.guna2HtmlLabel2.Text = "Konaklama Tipini Seciniz";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Marmaris",
            "Fethiye"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(505, 479);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(268, 36);
            this.guna2ComboBox1.TabIndex = 41;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(47, 479);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(353, 30);
            this.guna2HtmlLabel3.TabIndex = 40;
            this.guna2HtmlLabel3.Text = "Gideceginiz lokasyonu seciniz";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Location = new System.Drawing.Point(851, 67);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(16, 18);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(873, 55);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(200, 36);
            this.txtID.TabIndex = 43;
            // 
            // btnJsonSeyahat
            // 
            this.btnJsonSeyahat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJsonSeyahat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJsonSeyahat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJsonSeyahat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJsonSeyahat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnJsonSeyahat.ForeColor = System.Drawing.Color.White;
            this.btnJsonSeyahat.Location = new System.Drawing.Point(873, 178);
            this.btnJsonSeyahat.Name = "btnJsonSeyahat";
            this.btnJsonSeyahat.Size = new System.Drawing.Size(200, 45);
            this.btnJsonSeyahat.TabIndex = 44;
            this.btnJsonSeyahat.Text = "JsonSeyahatBilgi";
            this.btnJsonSeyahat.Click += new System.EventHandler(this.btnJsonSeyahat_Click);
            // 
            // btnJsonKullaniciBilgi
            // 
            this.btnJsonKullaniciBilgi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJsonKullaniciBilgi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJsonKullaniciBilgi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJsonKullaniciBilgi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJsonKullaniciBilgi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnJsonKullaniciBilgi.ForeColor = System.Drawing.Color.White;
            this.btnJsonKullaniciBilgi.Location = new System.Drawing.Point(873, 275);
            this.btnJsonKullaniciBilgi.Name = "btnJsonKullaniciBilgi";
            this.btnJsonKullaniciBilgi.Size = new System.Drawing.Size(200, 45);
            this.btnJsonKullaniciBilgi.TabIndex = 46;
            this.btnJsonKullaniciBilgi.Text = "JsonKullaniciBilgi";
            this.btnJsonKullaniciBilgi.Click += new System.EventHandler(this.btnJsonKullaniciBilgi_Click);
            // 
            // Rezarvasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 759);
            this.Controls.Add(this.btnJsonKullaniciBilgi);
            this.Controls.Add(this.btnJsonSeyahat);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cbKonaklama);
            this.Controls.Add(this.cbUlasim);
            this.Controls.Add(this.tpDonus);
            this.Controls.Add(this.tpGidis);
            this.Controls.Add(this.cbLokasyon);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKimlikNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Rezarvasyon";
            this.Text = "Rezarvasyon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbKonaklama;
        private Guna.UI2.WinForms.Guna2ComboBox cbUlasim;
        private Guna.UI2.WinForms.Guna2DateTimePicker tpDonus;
        private Guna.UI2.WinForms.Guna2DateTimePicker tpGidis;
        private Guna.UI2.WinForms.Guna2ComboBox cbLokasyon;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtSifre;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtKimlikNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtAdSoyad;
        private Guna.UI2.WinForms.Guna2GradientButton btnEkle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblID;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2Button btnJsonSeyahat;
        private Guna.UI2.WinForms.Guna2Button btnJsonKullaniciBilgi;
    }
}