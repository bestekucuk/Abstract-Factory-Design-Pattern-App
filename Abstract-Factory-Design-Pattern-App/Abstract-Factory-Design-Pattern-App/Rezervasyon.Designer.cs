namespace Abstract_Factory_Design_Pattern_App
{
    partial class Rezervasyon
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
            this.txtSifre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtKimlikNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAdSoyad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEkle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbLokasyon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tpGidis = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tpDonus = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbUlasim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbKonaklama = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Transparent;
            this.txtSifre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtSifre.Location = new System.Drawing.Point(269, 306);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(191, 24);
            this.txtSifre.TabIndex = 19;
            this.txtSifre.Text = "Ulasim Tipini Seciniz";
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.BackColor = System.Drawing.Color.Transparent;
            this.txtKimlikNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtKimlikNo.Location = new System.Drawing.Point(274, 127);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(186, 24);
            this.txtKimlikNo.TabIndex = 18;
            this.txtKimlikNo.Text = "Seyahat Gidis Tarihi";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.txtAdSoyad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtAdSoyad.Location = new System.Drawing.Point(59, 38);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(401, 24);
            this.txtAdSoyad.TabIndex = 17;
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
            this.btnEkle.Location = new System.Drawing.Point(581, 490);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(151, 55);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "EKLE";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(229, 403);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(231, 24);
            this.guna2HtmlLabel2.TabIndex = 15;
            this.guna2HtmlLabel2.Text = "Konaklama Tipini Seciniz";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(264, 212);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(196, 24);
            this.guna2HtmlLabel1.TabIndex = 23;
            this.guna2HtmlLabel1.Text = "Seyahat Donus Tarihi";
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
            this.cbLokasyon.Location = new System.Drawing.Point(528, 38);
            this.cbLokasyon.Name = "cbLokasyon";
            this.cbLokasyon.Size = new System.Drawing.Size(202, 36);
            this.cbLokasyon.TabIndex = 24;
            // 
            // tpGidis
            // 
            this.tpGidis.Checked = true;
            this.tpGidis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpGidis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tpGidis.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tpGidis.Location = new System.Drawing.Point(528, 127);
            this.tpGidis.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tpGidis.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tpGidis.Name = "tpGidis";
            this.tpGidis.Size = new System.Drawing.Size(202, 36);
            this.tpGidis.TabIndex = 25;
            this.tpGidis.Value = new System.DateTime(2022, 5, 24, 14, 26, 43, 526);
            // 
            // tpDonus
            // 
            this.tpDonus.Checked = true;
            this.tpDonus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpDonus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tpDonus.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tpDonus.Location = new System.Drawing.Point(530, 200);
            this.tpDonus.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tpDonus.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tpDonus.Name = "tpDonus";
            this.tpDonus.Size = new System.Drawing.Size(200, 36);
            this.tpDonus.TabIndex = 26;
            this.tpDonus.Value = new System.DateTime(2022, 5, 24, 14, 26, 43, 526);
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
            this.cbUlasim.Location = new System.Drawing.Point(530, 294);
            this.cbUlasim.Name = "cbUlasim";
            this.cbUlasim.Size = new System.Drawing.Size(202, 36);
            this.cbUlasim.TabIndex = 27;
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
            this.cbKonaklama.Location = new System.Drawing.Point(528, 391);
            this.cbKonaklama.Name = "cbKonaklama";
            this.cbKonaklama.Size = new System.Drawing.Size(202, 36);
            this.cbKonaklama.TabIndex = 28;
            // 
            // Rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 599);
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
            this.Name = "Rezervasyon";
            this.Text = "Rezervasyon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel txtSifre;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtKimlikNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtAdSoyad;
        private Guna.UI2.WinForms.Guna2GradientButton btnEkle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbLokasyon;
        private Guna.UI2.WinForms.Guna2DateTimePicker tpGidis;
        private Guna.UI2.WinForms.Guna2DateTimePicker tpDonus;
        private Guna.UI2.WinForms.Guna2ComboBox cbUlasim;
        private Guna.UI2.WinForms.Guna2ComboBox cbKonaklama;
    }
}