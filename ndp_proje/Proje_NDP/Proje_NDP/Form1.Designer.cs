namespace Proje_NDP
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabPage4 = new TabPage();
            dataGridViewRandevular = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            label33 = new Label();
            toplam1 = new TextBox();
            label31 = new Label();
            Personeller1 = new ComboBox();
            comboBox2 = new ComboBox();
            RandevuGuncelle = new Button();
            randevuSil = new Button();
            yeniTarih = new DateTimePicker();
            yeniTelno = new MaskedTextBox();
            yeniEmail = new TextBox();
            yeniSoyad = new TextBox();
            yeniAd = new TextBox();
            mevcutrandevuTarihi = new DateTimePicker();
            groupBox1 = new GroupBox();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label19 = new Label();
            checkBox13 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox18 = new CheckBox();
            checkBox17 = new CheckBox();
            checkBox16 = new CheckBox();
            checkBox14 = new CheckBox();
            RandevuGoruntule = new Button();
            l7 = new Label();
            l6 = new Label();
            l5 = new Label();
            l3 = new Label();
            l2 = new Label();
            l1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            mevcutrandevuSaatleri = new ComboBox();
            tabPage2 = new TabPage();
            label30 = new Label();
            Personeller = new ComboBox();
            comboBox1 = new ComboBox();
            groupBoxHizmetler = new GroupBox();
            label32 = new Label();
            toplam = new TextBox();
            label21 = new Label();
            checkBox3 = new CheckBox();
            label20 = new Label();
            checkBox1 = new CheckBox();
            label18 = new Label();
            checkBox5 = new CheckBox();
            label16 = new Label();
            label17 = new Label();
            checkBox2 = new CheckBox();
            checkBox8 = new CheckBox();
            label15 = new Label();
            checkBox7 = new CheckBox();
            label13 = new Label();
            checkBox6 = new CheckBox();
            label12 = new Label();
            checkBox4 = new CheckBox();
            label3 = new Label();
            buttonrandevukaydet = new Button();
            label2 = new Label();
            musteriMail = new TextBox();
            musteriSoyad = new TextBox();
            musteriAd = new TextBox();
            label7 = new Label();
            RandevuTarih = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            musteriTelNo = new MaskedTextBox();
            label10 = new Label();
            label11 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewHizmetler = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRandevular).BeginInit();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBoxHizmetler.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHizmetler).BeginInit();
            SuspendLayout();
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridViewRandevular);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1167, 661);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Randevular";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRandevular
            // 
            dataGridViewRandevular.AllowUserToAddRows = false;
            dataGridViewRandevular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRandevular.BackgroundColor = Color.Teal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRandevular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRandevular.ColumnHeadersHeight = 29;
            dataGridViewRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewRandevular.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column8, Column7 });
            dataGridViewRandevular.Dock = DockStyle.Fill;
            dataGridViewRandevular.Location = new Point(3, 3);
            dataGridViewRandevular.Name = "dataGridViewRandevular";
            dataGridViewRandevular.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewRandevular.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRandevular.RowHeadersWidth = 51;
            dataGridViewRandevular.RowTemplate.Height = 29;
            dataGridViewRandevular.Size = new Size(1161, 655);
            dataGridViewRandevular.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Müşteri Adı";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Müşteri Soyadı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Müşteri Tel. No";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Müşteri E-mail";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Randevu Tarihi";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Randevu Saati";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Seçili Personel";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Seçilen Hizmetler";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label33);
            tabPage3.Controls.Add(toplam1);
            tabPage3.Controls.Add(label31);
            tabPage3.Controls.Add(Personeller1);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(RandevuGuncelle);
            tabPage3.Controls.Add(randevuSil);
            tabPage3.Controls.Add(yeniTarih);
            tabPage3.Controls.Add(yeniTelno);
            tabPage3.Controls.Add(yeniEmail);
            tabPage3.Controls.Add(yeniSoyad);
            tabPage3.Controls.Add(yeniAd);
            tabPage3.Controls.Add(mevcutrandevuTarihi);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(RandevuGoruntule);
            tabPage3.Controls.Add(l7);
            tabPage3.Controls.Add(l6);
            tabPage3.Controls.Add(l5);
            tabPage3.Controls.Add(l3);
            tabPage3.Controls.Add(l2);
            tabPage3.Controls.Add(l1);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(mevcutrandevuSaatleri);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1167, 661);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Randevu Düzenle";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // label33
            // 
            label33.Font = new Font("Rockwell Nova Cond", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label33.Location = new Point(851, 483);
            label33.Name = "label33";
            label33.Size = new Size(162, 32);
            label33.TabIndex = 51;
            label33.Text = "Toplam Fiyat : ";
            // 
            // toplam1
            // 
            toplam1.Location = new Point(1019, 488);
            toplam1.Name = "toplam1";
            toplam1.Size = new Size(125, 27);
            toplam1.TabIndex = 50;
            // 
            // label31
            // 
            label31.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label31.Location = new Point(42, 448);
            label31.Name = "label31";
            label31.Size = new Size(174, 25);
            label31.TabIndex = 49;
            label31.Text = "Seçili Personel :";
            // 
            // Personeller1
            // 
            Personeller1.FormattingEnabled = true;
            Personeller1.Items.AddRange(new object[] { "Eren Taşkın", "Berkay Kocaman", "Umut Gündüz", "Can Yıldız", "Murat Aslan", "Furkan Korkmaz", "Tolga Demirci", "Onur Aktaş", "Deniz Aydın", "Özgür Çelik" });
            Personeller1.Location = new Point(222, 449);
            Personeller1.Name = "Personeller1";
            Personeller1.Size = new Size(170, 28);
            Personeller1.TabIndex = 48;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "10:00", "10:45", "11:30", "12:15", "13:00", "14:30", "15:15", "16:00", "16:45", "17:30" });
            comboBox2.Location = new Point(222, 387);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 47;
            // 
            // RandevuGuncelle
            // 
            RandevuGuncelle.Location = new Point(441, 529);
            RandevuGuncelle.Name = "RandevuGuncelle";
            RandevuGuncelle.Size = new Size(142, 51);
            RandevuGuncelle.TabIndex = 46;
            RandevuGuncelle.Text = "Randevu Güncelle";
            RandevuGuncelle.UseVisualStyleBackColor = true;
            RandevuGuncelle.Click += RandevuGuncelle_Click;
            // 
            // randevuSil
            // 
            randevuSil.Location = new Point(267, 529);
            randevuSil.Name = "randevuSil";
            randevuSil.Size = new Size(142, 51);
            randevuSil.TabIndex = 45;
            randevuSil.Text = "Randevu Sil";
            randevuSil.UseVisualStyleBackColor = true;
            randevuSil.Click += randevuSil_Click;
            // 
            // yeniTarih
            // 
            yeniTarih.Location = new Point(233, 325);
            yeniTarih.Name = "yeniTarih";
            yeniTarih.Size = new Size(250, 27);
            yeniTarih.TabIndex = 44;
            // 
            // yeniTelno
            // 
            yeniTelno.Location = new Point(641, 184);
            yeniTelno.Mask = "(999) 000-0000";
            yeniTelno.Name = "yeniTelno";
            yeniTelno.Size = new Size(125, 27);
            yeniTelno.TabIndex = 42;
            // 
            // yeniEmail
            // 
            yeniEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            yeniEmail.Location = new Point(630, 243);
            yeniEmail.Name = "yeniEmail";
            yeniEmail.Size = new Size(197, 32);
            yeniEmail.TabIndex = 41;
            // 
            // yeniSoyad
            // 
            yeniSoyad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            yeniSoyad.Location = new Point(222, 250);
            yeniSoyad.Name = "yeniSoyad";
            yeniSoyad.Size = new Size(197, 32);
            yeniSoyad.TabIndex = 40;
            // 
            // yeniAd
            // 
            yeniAd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            yeniAd.Location = new Point(212, 181);
            yeniAd.Name = "yeniAd";
            yeniAd.Size = new Size(197, 32);
            yeniAd.TabIndex = 39;
            // 
            // mevcutrandevuTarihi
            // 
            mevcutrandevuTarihi.Location = new Point(42, 121);
            mevcutrandevuTarihi.Name = "mevcutrandevuTarihi";
            mevcutrandevuTarihi.Size = new Size(250, 27);
            mevcutrandevuTarihi.TabIndex = 38;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label29);
            groupBox1.Controls.Add(label28);
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(checkBox13);
            groupBox1.Controls.Add(checkBox11);
            groupBox1.Controls.Add(checkBox15);
            groupBox1.Controls.Add(checkBox12);
            groupBox1.Controls.Add(checkBox18);
            groupBox1.Controls.Add(checkBox17);
            groupBox1.Controls.Add(checkBox16);
            groupBox1.Controls.Add(checkBox14);
            groupBox1.Location = new Point(844, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 316);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // label29
            // 
            label29.Location = new Point(169, 271);
            label29.Name = "label29";
            label29.Size = new Size(61, 25);
            label29.TabIndex = 52;
            label29.Text = "label29";
            // 
            // label28
            // 
            label28.Location = new Point(169, 243);
            label28.Name = "label28";
            label28.Size = new Size(61, 25);
            label28.TabIndex = 51;
            label28.Text = "label28";
            // 
            // label27
            // 
            label27.Location = new Point(131, 211);
            label27.Name = "label27";
            label27.Size = new Size(61, 25);
            label27.TabIndex = 50;
            label27.Text = "label27";
            // 
            // label26
            // 
            label26.Location = new Point(143, 184);
            label26.Name = "label26";
            label26.Size = new Size(61, 25);
            label26.TabIndex = 49;
            label26.Text = "label26";
            // 
            // label25
            // 
            label25.Location = new Point(155, 154);
            label25.Name = "label25";
            label25.Size = new Size(61, 25);
            label25.TabIndex = 48;
            label25.Text = "label25";
            // 
            // label24
            // 
            label24.Location = new Point(169, 124);
            label24.Name = "label24";
            label24.Size = new Size(61, 25);
            label24.TabIndex = 47;
            label24.Text = "label24";
            // 
            // label23
            // 
            label23.Location = new Point(199, 94);
            label23.Name = "label23";
            label23.Size = new Size(61, 25);
            label23.TabIndex = 46;
            label23.Text = "label23";
            // 
            // label22
            // 
            label22.Location = new Point(179, 65);
            label22.Name = "label22";
            label22.Size = new Size(61, 25);
            label22.TabIndex = 45;
            label22.Text = "label22";
            // 
            // label19
            // 
            label19.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(34, 23);
            label19.Name = "label19";
            label19.Size = new Size(173, 25);
            label19.TabIndex = 29;
            label19.Text = "Seçilen Hizmetler";
            label19.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(33, 123);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(136, 24);
            checkBox13.TabIndex = 23;
            checkBox13.Text = "SAÇ BOYAMA - ";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(32, 63);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(141, 24);
            checkBox11.TabIndex = 21;
            checkBox11.Text = "SAÇ TASARIMI - ";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point(33, 184);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(111, 24);
            checkBox15.TabIndex = 28;
            checkBox15.Text = "MANİKÜR - ";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(33, 93);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(171, 24);
            checkBox12.TabIndex = 22;
            checkBox12.Text = "SAÇ DÜZLEŞTİRME - ";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            checkBox18.AutoSize = true;
            checkBox18.Location = new Point(33, 274);
            checkBox18.Name = "checkBox18";
            checkBox18.Size = new Size(139, 24);
            checkBox18.TabIndex = 27;
            checkBox18.Text = "DAMAT TRAŞI - ";
            checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Location = new Point(33, 244);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(141, 24);
            checkBox17.TabIndex = 24;
            checkBox17.Text = "KAŞ TASARIMI - ";
            checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(33, 214);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(104, 24);
            checkBox16.TabIndex = 26;
            checkBox16.Text = "PEDİKÜR - ";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(33, 153);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(125, 24);
            checkBox14.TabIndex = 25;
            checkBox14.Text = "CİLT BAKIMI - ";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // RandevuGoruntule
            // 
            RandevuGoruntule.Location = new Point(539, 117);
            RandevuGoruntule.Name = "RandevuGoruntule";
            RandevuGoruntule.Size = new Size(119, 38);
            RandevuGoruntule.TabIndex = 27;
            RandevuGoruntule.Text = "Görüntüle";
            RandevuGoruntule.UseVisualStyleBackColor = true;
            RandevuGoruntule.Click += ButtonRandevuGoruntule_Click;
            // 
            // l7
            // 
            l7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            l7.Location = new Point(42, 386);
            l7.Name = "l7";
            l7.Size = new Size(174, 25);
            l7.TabIndex = 26;
            l7.Text = "Randevu Saati :";
            // 
            // l6
            // 
            l6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            l6.Location = new Point(42, 326);
            l6.Name = "l6";
            l6.Size = new Size(174, 25);
            l6.TabIndex = 25;
            l6.Text = "Randevu Tarihi :";
            // 
            // l5
            // 
            l5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            l5.Location = new Point(450, 250);
            l5.Name = "l5";
            l5.Size = new Size(174, 25);
            l5.TabIndex = 24;
            l5.Text = "Müşteri E-Mail :";
            // 
            // l3
            // 
            l3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            l3.Location = new Point(450, 181);
            l3.Name = "l3";
            l3.Size = new Size(174, 25);
            l3.TabIndex = 23;
            l3.Text = "Müşteri Tel. No :";
            // 
            // l2
            // 
            l2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            l2.Location = new Point(42, 250);
            l2.Name = "l2";
            l2.Size = new Size(174, 25);
            l2.TabIndex = 22;
            l2.Text = "Müşteri Soyadı :";
            // 
            // l1
            // 
            l1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            l1.Location = new Point(42, 188);
            l1.Name = "l1";
            l1.Size = new Size(137, 25);
            l1.TabIndex = 21;
            l1.Text = "Müşteri Adı :";
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(61, 81);
            label6.Name = "label6";
            label6.Size = new Size(547, 25);
            label6.TabIndex = 20;
            label6.Text = "Görüntülenecek Randevu Tarih Ve Saat Bilgisini Seçiniz";
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(124, 106);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 19;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(267, 12);
            label4.Name = "label4";
            label4.Size = new Size(527, 47);
            label4.TabIndex = 18;
            label4.Text = "MEVCUT RANDEVU DÜZENLE / SİL ";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // mevcutrandevuSaatleri
            // 
            mevcutrandevuSaatleri.FormattingEnabled = true;
            mevcutrandevuSaatleri.Items.AddRange(new object[] { "10:00", "10:45", "11:30", "12:15", "13:00", "14:30", "15:15", "16:00", "16:45", "17:30" });
            mevcutrandevuSaatleri.Location = new Point(332, 123);
            mevcutrandevuSaatleri.Name = "mevcutrandevuSaatleri";
            mevcutrandevuSaatleri.Size = new Size(151, 28);
            mevcutrandevuSaatleri.TabIndex = 14;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label30);
            tabPage2.Controls.Add(Personeller);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(groupBoxHizmetler);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(buttonrandevukaydet);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(musteriMail);
            tabPage2.Controls.Add(musteriSoyad);
            tabPage2.Controls.Add(musteriAd);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(RandevuTarih);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(musteriTelNo);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1167, 661);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Randevu Oluştur";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label30
            // 
            label30.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label30.ForeColor = SystemColors.ActiveCaptionText;
            label30.Location = new Point(586, 303);
            label30.Name = "label30";
            label30.Size = new Size(157, 37);
            label30.TabIndex = 33;
            label30.Text = "Personel Seç :";
            // 
            // Personeller
            // 
            Personeller.FormattingEnabled = true;
            Personeller.Items.AddRange(new object[] { "Eren Taşkın", "Berkay Kocaman", "Umut Gündüz", "Can Yıldız", "Murat Aslan", "Furkan Korkmaz", "Tolga Demirci", "Onur Aktaş", "Deniz Aydın", "Özgür Çelik" });
            Personeller.Location = new Point(748, 303);
            Personeller.Name = "Personeller";
            Personeller.Size = new Size(170, 28);
            Personeller.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10:00", "10:45", "11:30", "12:15", "13:00", "14:30", "15:15", "16:00", "16:45", "17:30" });
            comboBox1.Location = new Point(704, 249);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 28);
            comboBox1.TabIndex = 31;
            // 
            // groupBoxHizmetler
            // 
            groupBoxHizmetler.Controls.Add(label32);
            groupBoxHizmetler.Controls.Add(toplam);
            groupBoxHizmetler.Controls.Add(label21);
            groupBoxHizmetler.Controls.Add(checkBox3);
            groupBoxHizmetler.Controls.Add(label20);
            groupBoxHizmetler.Controls.Add(checkBox1);
            groupBoxHizmetler.Controls.Add(label18);
            groupBoxHizmetler.Controls.Add(checkBox5);
            groupBoxHizmetler.Controls.Add(label16);
            groupBoxHizmetler.Controls.Add(label17);
            groupBoxHizmetler.Controls.Add(checkBox2);
            groupBoxHizmetler.Controls.Add(checkBox8);
            groupBoxHizmetler.Controls.Add(label15);
            groupBoxHizmetler.Controls.Add(checkBox7);
            groupBoxHizmetler.Controls.Add(label13);
            groupBoxHizmetler.Controls.Add(checkBox6);
            groupBoxHizmetler.Controls.Add(label12);
            groupBoxHizmetler.Controls.Add(checkBox4);
            groupBoxHizmetler.Location = new Point(52, 355);
            groupBoxHizmetler.Name = "groupBoxHizmetler";
            groupBoxHizmetler.Size = new Size(1077, 176);
            groupBoxHizmetler.TabIndex = 30;
            groupBoxHizmetler.TabStop = false;
            // 
            // label32
            // 
            label32.Font = new Font("Rockwell Nova Cond", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(353, 128);
            label32.Name = "label32";
            label32.Size = new Size(162, 32);
            label32.TabIndex = 40;
            label32.Text = "Toplam Fiyat : ";
            // 
            // toplam
            // 
            toplam.Location = new Point(521, 133);
            toplam.Name = "toplam";
            toplam.Size = new Size(125, 27);
            toplam.TabIndex = 39;
            // 
            // label21
            // 
            label21.Location = new Point(972, 78);
            label21.Name = "label21";
            label21.Size = new Size(73, 25);
            label21.TabIndex = 38;
            label21.Text = "label21";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(312, 30);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(145, 27);
            checkBox3.TabIndex = 23;
            checkBox3.Text = "Saç Boyama - ";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.Location = new Point(967, 36);
            label20.Name = "label20";
            label20.Size = new Size(59, 25);
            label20.TabIndex = 37;
            label20.Text = "label20";
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(21, 28);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(166, 27);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Saç Tasarımı - ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.Location = new Point(697, 81);
            label18.Name = "label18";
            label18.Size = new Size(59, 25);
            label18.TabIndex = 36;
            label18.Text = "label18";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox5.Location = new Point(575, 30);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(116, 27);
            checkBox5.TabIndex = 28;
            checkBox5.Text = "Manikür - ";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.Location = new Point(469, 81);
            label16.Name = "label16";
            label16.Size = new Size(59, 25);
            label16.TabIndex = 34;
            label16.Text = "label16";
            // 
            // label17
            // 
            label17.Location = new Point(712, 31);
            label17.Name = "label17";
            label17.Size = new Size(59, 25);
            label17.TabIndex = 35;
            label17.Text = "label17";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(21, 77);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(177, 27);
            checkBox2.TabIndex = 22;
            checkBox2.Text = "Saç Düzleştirme - ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox8.Location = new Point(821, 76);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(145, 27);
            checkBox8.TabIndex = 27;
            checkBox8.Text = "Damat Traşı - ";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.Location = new Point(477, 32);
            label15.Name = "label15";
            label15.Size = new Size(59, 25);
            label15.TabIndex = 33;
            label15.Text = "label15";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox7.Location = new Point(821, 33);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(148, 27);
            checkBox7.TabIndex = 24;
            checkBox7.Text = "Kaş Tasarımı - ";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.Location = new Point(220, 79);
            label13.Name = "label13";
            label13.Size = new Size(72, 25);
            label13.TabIndex = 32;
            label13.Text = "label13";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox6.Location = new Point(581, 80);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(110, 27);
            checkBox6.TabIndex = 26;
            checkBox6.Text = "Pedikür - ";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Location = new Point(206, 30);
            label12.Name = "label12";
            label12.Size = new Size(61, 25);
            label12.TabIndex = 31;
            label12.Text = "label12";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.Location = new Point(312, 79);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(138, 27);
            checkBox4.TabIndex = 25;
            checkBox4.Text = "Cilt Bakımı - ";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(248, 38);
            label3.Name = "label3";
            label3.Size = new Size(608, 46);
            label3.TabIndex = 12;
            label3.Text = "YENİ RANDEVU OLUŞTUR";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonrandevukaydet
            // 
            buttonrandevukaydet.Location = new Point(485, 554);
            buttonrandevukaydet.Name = "buttonrandevukaydet";
            buttonrandevukaydet.Size = new Size(199, 60);
            buttonrandevukaydet.TabIndex = 20;
            buttonrandevukaydet.Text = "Randevu Kaydet";
            buttonrandevukaydet.UseVisualStyleBackColor = true;
            buttonrandevukaydet.Click += ButtonRandevuKaydet_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(586, 121);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 1;
            label2.Text = "Tel. No :";
            // 
            // musteriMail
            // 
            musteriMail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            musteriMail.Location = new Point(704, 184);
            musteriMail.Name = "musteriMail";
            musteriMail.Size = new Size(200, 31);
            musteriMail.TabIndex = 19;
            // 
            // musteriSoyad
            // 
            musteriSoyad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            musteriSoyad.Location = new Point(250, 184);
            musteriSoyad.Name = "musteriSoyad";
            musteriSoyad.Size = new Size(213, 31);
            musteriSoyad.TabIndex = 14;
            // 
            // musteriAd
            // 
            musteriAd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            musteriAd.Location = new Point(250, 124);
            musteriAd.Name = "musteriAd";
            musteriAd.Size = new Size(213, 31);
            musteriAd.TabIndex = 13;
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(136, 123);
            label7.Name = "label7";
            label7.Size = new Size(108, 30);
            label7.TabIndex = 6;
            label7.Text = "Adı        :";
            // 
            // RandevuTarih
            // 
            RandevuTarih.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            RandevuTarih.Location = new Point(250, 253);
            RandevuTarih.Name = "RandevuTarih";
            RandevuTarih.Size = new Size(213, 27);
            RandevuTarih.TabIndex = 17;
            // 
            // label8
            // 
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(136, 184);
            label8.Name = "label8";
            label8.Size = new Size(108, 27);
            label8.TabIndex = 7;
            label8.Text = "Soyadı  :";
            // 
            // label9
            // 
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(586, 183);
            label9.Name = "label9";
            label9.Size = new Size(190, 27);
            label9.TabIndex = 8;
            label9.Text = "E-Mail :";
            // 
            // musteriTelNo
            // 
            musteriTelNo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            musteriTelNo.Location = new Point(704, 120);
            musteriTelNo.Mask = "(999) 000-0000";
            musteriTelNo.Name = "musteriTelNo";
            musteriTelNo.Size = new Size(200, 31);
            musteriTelNo.TabIndex = 15;
            // 
            // label10
            // 
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(136, 250);
            label10.Name = "label10";
            label10.Size = new Size(108, 27);
            label10.TabIndex = 9;
            label10.Text = "Tarih    :";
            // 
            // label11
            // 
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(586, 251);
            label11.Name = "label11";
            label11.Size = new Size(190, 37);
            label11.TabIndex = 10;
            label11.Text = "Saat    :";
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(136, 317);
            label1.Name = "label1";
            label1.Size = new Size(143, 27);
            label1.TabIndex = 11;
            label1.Text = "Hizmet Seç :";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1175, 694);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewHizmetler);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1167, 661);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Hizmetler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHizmetler
            // 
            dataGridViewHizmetler.AllowUserToAddRows = false;
            dataGridViewHizmetler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHizmetler.BackgroundColor = Color.Teal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewHizmetler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHizmetler.ColumnHeadersHeight = 29;
            dataGridViewHizmetler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewHizmetler.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewHizmetler.Dock = DockStyle.Fill;
            dataGridViewHizmetler.Location = new Point(0, 0);
            dataGridViewHizmetler.Name = "dataGridViewHizmetler";
            dataGridViewHizmetler.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewHizmetler.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewHizmetler.RowHeadersWidth = 51;
            dataGridViewHizmetler.RowTemplate.Height = 29;
            dataGridViewHizmetler.Size = new Size(1167, 661);
            dataGridViewHizmetler.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Hizmet Adı";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Hizmet Ücreti";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Hizmet Maliyeti";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Hizmet Detayı";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 650);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRandevular).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBoxHizmetler.ResumeLayout(false);
            groupBoxHizmetler.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHizmetler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage4;
        private TabPage tabPage3;
        private ComboBox mevcutrandevuSaatleri;
        private TabPage tabPage2;
        private CheckBox checkBox8;
        private CheckBox checkBox6;
        private CheckBox checkBox4;
        private CheckBox checkBox7;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label3;
        private Button buttonrandevukaydet;
        private Label label2;
        private TextBox musteriMail;
        private TextBox musteriSoyad;
        private TextBox musteriAd;
        private Label label7;
        private DateTimePicker RandevuTarih;
        private Label label8;
        private Label label9;
        private MaskedTextBox musteriTelNo;
        private Label label10;
        private Label label11;
        private Label label1;
        private TabControl tabControl1;
        private CheckBox checkBox5;
        private GroupBox groupBoxHizmetler;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label l1;
        private GroupBox groupBox1;
        private Label label19;
        private CheckBox checkBox13;
        private CheckBox checkBox11;
        private CheckBox checkBox15;
        private CheckBox checkBox12;
        private CheckBox checkBox18;
        private CheckBox checkBox17;
        private CheckBox checkBox16;
        private CheckBox checkBox14;
        private Button RandevuGoruntule;
        private Label l7;
        private Label l6;
        private Label l5;
        private Label l3;
        private Label l2;
        private MaskedTextBox yeniTelno;
        private DateTimePicker yeniTarih;
        private TextBox textBox4;
        private TextBox yeniEmail;
        private TextBox yeniSoyad;
        private TextBox yeniAd;
        private DateTimePicker mevcutrandevuTarihi;
        private Label label12;
        private Label label20;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label13;
        private Label label21;
        private ComboBox comboBox1;
        private Label label23;
        private Label label22;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Button RandevuGuncelle;
        private Button randevuSil;
        private ComboBox comboBox2;
        private DataGridView dataGridViewRandevular;
        private Label label30;
        private ComboBox Personeller;
        private ComboBox Personeller1;
        private Label label31;
        private Label label32;
        private TextBox toplam;
        private Label label33;
        private TextBox toplam1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
        private TabPage tabPage1;
        private DataGridView dataGridViewHizmetler;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
