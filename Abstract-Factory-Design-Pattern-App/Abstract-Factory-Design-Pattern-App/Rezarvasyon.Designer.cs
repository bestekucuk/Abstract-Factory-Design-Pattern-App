
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
            this.cbKonaklama.Location = new System.Drawing.Point(449, 311);
            this.cbKonaklama.Name = "cbKonaklama";
            this.cbKonaklama.Size = new System.Drawing.Size(202, 36);
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
            this.cbUlasim.Location = new System.Drawing.Point(451, 214);
            this.cbUlasim.Name = "cbUlasim";
            this.cbUlasim.Size = new System.Drawing.Size(202, 36);
            this.cbUlasim.TabIndex = 38;
            // 
            // tpDonus
            // 
            this.tpDonus.Checked = true;
            this.tpDonus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpDonus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tpDonus.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tpDonus.Location = new System.Drawing.Point(451, 120);
            this.tpDonus.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tpDonus.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tpDonus.Name = "tpDonus";
            this.tpDonus.Size = new System.Drawing.Size(200, 36);
            this.tpDonus.TabIndex = 37;
            this.tpDonus.Value = new System.DateTime(2022, 5, 24, 14, 26, 43, 526);
            // 
            // tpGidis
            // 
            this.tpGidis.Checked = true;
            this.tpGidis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpGidis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tpGidis.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tpGidis.Location = new System.Drawing.Point(449, 47);
            this.tpGidis.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tpGidis.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tpGidis.Name = "tpGidis";
            this.tpGidis.Size = new System.Drawing.Size(202, 36);
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
            this.cbLokasyon.Location = new System.Drawing.Point(433, -71);
            this.cbLokasyon.Name = "cbLokasyon";
            this.cbLokasyon.Size = new System.Drawing.Size(202, 36);
            this.cbLokasyon.TabIndex = 35;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(185, 132);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(196, 24);
            this.guna2HtmlLabel1.TabIndex = 34;
            this.guna2HtmlLabel1.Text = "Seyahat Donus Tarihi";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Transparent;
            this.txtSifre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtSifre.Location = new System.Drawing.Point(190, 226);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(191, 24);
            this.txtSifre.TabIndex = 33;
            this.txtSifre.Text = "Ulasim Tipini Seciniz";
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.BackColor = System.Drawing.Color.Transparent;
            this.txtKimlikNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtKimlikNo.Location = new System.Drawing.Point(194, 47);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(186, 24);
            this.txtKimlikNo.TabIndex = 32;
            this.txtKimlikNo.Text = "Seyahat Gidis Tarihi";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.txtAdSoyad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtAdSoyad.Location = new System.Drawing.Point(-36, -71);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(401, 24);
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
            this.btnEkle.Location = new System.Drawing.Point(502, 487);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(151, 55);
            this.btnEkle.TabIndex = 30;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(150, 323);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(231, 24);
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
            this.guna2ComboBox1.Location = new System.Drawing.Point(449, 392);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(202, 36);
            this.guna2ComboBox1.TabIndex = 41;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(106, 392);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(275, 24);
            this.guna2HtmlLabel3.TabIndex = 40;
            this.guna2HtmlLabel3.Text = "Gideceginiz lokasyonu seciniz";
            // 
            // Rezarvasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 617);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}