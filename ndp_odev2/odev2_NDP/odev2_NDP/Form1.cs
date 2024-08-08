/*******************************************************************************************************************
**				                                      	SAKARYA ÜNÝVERSÝTESÝ
**				                                BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				                                    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				                                 NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					                                    2023-2024 BAHAR DÖNEMÝ
**	
**				                                      ÖDEV NUMARASI..........: 2
**				                                      ÖÐRENCÝ ADI............: MEHMET CAN BAYAR
**				                                      ÖÐRENCÝ NUMARASI.......: B231210042
**                                                    DERSÝN ALINDIÐI GRUP...: A
******************************************************************************************************************/
using odev2_NDP.Geometrik_Þekiller;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace odev2_NDP
{
    public partial class Form1 : Form
    {
        Graphics g;
        Nokta nokta1;
        Nokta3d nokta3D1;
        Dikdortgen dikdortgen1;
        Cember cember1;
        Kure kure1;
        Silindir silindir1;
        DikdortgenPrizma dikdortgenPrizma1;
        Yuzey yuzey1;

        Nokta nokta2;
        Nokta3d nokta3D2;
        Dikdortgen dikdortgen2;
        Cember cember2;
        Kure kure2;
        Silindir silindir2;
        DikdortgenPrizma dikdortgenPrizma2;
        Yuzey yuzey2;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();

            MessageBox.Show("KULLANIM KILAVUZU ADIMLARI \n" +
               "1-)Uygulama baþladýðýnda ilk olarak sol üst kýsýmdan çarpýþma denetimini seçniz.\n" +
               "2-)Açýlan pencerede 2 cisim için 2 pencere bulunmaktadýr.Aktif olan özellikleri doldurunuz.\n" +
               "3-)Bilgileri girdikten sonra Þekilleri Çiz Ve Test Butonuna týklayýnýz.\n" +
               "4-)Cisimlerin özelliklerini deðiþtirmek istiyorsanýz Cisimlerin Özelliklerini Gir butonuna týklayýnýz." +
               "5-)Baþka bir çarpýþma denetimi yapmak istiyorsanýz adým birden itibaren tekrardan gerçekleþtiriniz.\n" +
               "6-)1.Cisim W-A-S-D / 2.Cisim yön tuþlarý ile hareket eder.");

        }

        public int xKoorA;
        public int yKoorA;
        public int zKoorA;
        public int genislikA;
        public int yukseklikA;
        public int derinlikA;
        public int capA;
        public int xKoorB;
        public int yKoorB;
        public int zKoorB;
        public int genislikB;
        public int yukseklikB;
        public int derinlikB;
        public int capB;

        //Çarpýþma denetimini seçmek için grupboxý görünür yapar.
        private void carp_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        //Radio Butonlardaki çarpýþma denetimi seçilir.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Nokta ";
            cisim2.Text = " Dikdörtgen ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = false;
            genislik1.Enabled = false;
            yukseklik1.Enabled = false;
            derinlik1.Enabled = false;
            cap1.Enabled = false;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = false;
            genislik2.Enabled = true;
            yukseklik2.Enabled = true;
            derinlik2.Enabled = false;
            cap2.Enabled = false;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Nokta ";
            cisim2.Text = " Çember ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = false;
            genislik1.Enabled = false;
            yukseklik1.Enabled = false;
            derinlik1.Enabled = false;
            cap1.Enabled = false;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = false;
            genislik2.Enabled = false;
            yukseklik2.Enabled = false;
            derinlik2.Enabled = false;
            cap2.Enabled = true;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Dikdörtgen ";
            cisim2.Text = " Dikdörtgen ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = false;
            genislik1.Enabled = true;
            yukseklik1.Enabled = true;
            derinlik1.Enabled = false;
            cap1.Enabled = false;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = false;
            genislik2.Enabled = true;
            yukseklik2.Enabled = true;
            derinlik2.Enabled = false;
            cap2.Enabled = false;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Dikdörtgen ";
            cisim2.Text = " Çember ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = false;
            genislik1.Enabled = true;
            yukseklik1.Enabled = true;
            derinlik1.Enabled = false;
            cap1.Enabled = false;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = false;
            genislik2.Enabled = false;
            yukseklik2.Enabled = false;
            derinlik2.Enabled = false;
            cap2.Enabled = true;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Çember ";
            cisim2.Text = " Çember ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = false;
            genislik1.Enabled = false;
            yukseklik1.Enabled = false;
            derinlik1.Enabled = false;
            cap1.Enabled = true;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = false;
            genislik2.Enabled = false;
            yukseklik2.Enabled = false;
            derinlik2.Enabled = false;
            cap2.Enabled = true;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Nokta ";
            cisim2.Text = " Küre ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = true;
            genislik1.Enabled = false;
            yukseklik1.Enabled = false;
            derinlik1.Enabled = false;
            cap1.Enabled = false;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = true;
            genislik2.Enabled = false;
            yukseklik2.Enabled = false;
            derinlik2.Enabled = false;
            cap2.Enabled = true;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Nokta ";
            cisim2.Text = " Dikdörtgen Prizma ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = true;
            genislik1.Enabled = false;
            yukseklik1.Enabled = false;
            derinlik1.Enabled = false;
            cap1.Enabled = false;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = true;
            genislik2.Enabled = true;
            yukseklik2.Enabled = true;
            derinlik2.Enabled = true;
            cap2.Enabled = false;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Nokta ";
            cisim2.Text = " Silindir ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = true;
            genislik1.Enabled = false;
            yukseklik1.Enabled = false;
            derinlik1.Enabled = false;
            cap1.Enabled = false;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = true;
            genislik2.Enabled = false;
            yukseklik2.Enabled = true;
            derinlik2.Enabled = false;
            cap2.Enabled = true;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Silindir ";
            cisim2.Text = " Silindir ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = true;
            genislik1.Enabled = false;
            yukseklik1.Enabled = true;
            derinlik1.Enabled = false;
            cap1.Enabled = true;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = true;
            genislik2.Enabled = false;
            yukseklik2.Enabled = true;
            derinlik2.Enabled = false;
            cap2.Enabled = true;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Enabled = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Küre ";
            cisim2.Text = " Küre ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = true;
            genislik1.Enabled = false;
            yukseklik1.Enabled = false;
            derinlik1.Enabled = false;
            cap1.Enabled = true;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = true;
            genislik2.Enabled = false;
            yukseklik2.Enabled = false;
            derinlik2.Enabled = false;
            cap2.Enabled = true;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Enabled = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Küre ";
            cisim2.Text = " Silindir ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = true;
            genislik1.Enabled = false;
            yukseklik1.Enabled = false;
            derinlik1.Enabled = false;
            cap1.Enabled = true;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = true;
            genislik2.Enabled = false;
            yukseklik2.Enabled = true;
            derinlik2.Enabled = false;
            cap2.Enabled = true;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Küre ";
            cisim2.Text = " Yüzey ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = true;
            genislik1.Enabled = false;
            yukseklik1.Enabled = false;
            derinlik1.Enabled = false;
            cap1.Enabled = true;

            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = true;
            genislik2.Enabled = false;
            yukseklik2.Enabled = true;
            derinlik2.Enabled = true;
            cap2.Enabled = false;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Yüzey ";
            cisim2.Text = " Dikdörtgen Prizma ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = true;
            genislik1.Enabled = false;
            yukseklik1.Enabled = true;
            derinlik1.Enabled = true;
            cap1.Enabled = false;

            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = true;
            genislik2.Enabled = true;
            yukseklik2.Enabled = true;
            derinlik2.Enabled = true;
            cap2.Enabled = false;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Yüzey ";
            cisim2.Text = " Silindir ";
            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = true;
            genislik1.Enabled = false;
            yukseklik1.Enabled = true;
            derinlik1.Enabled = true;
            cap1.Enabled = false;

            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = true;
            genislik2.Enabled = false;
            yukseklik2.Enabled = true;
            derinlik2.Enabled = false;
            cap2.Enabled = true;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Küre ";
            cisim2.Text = " Dikdörtgen Prizma ";

            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = true;
            genislik1.Enabled = false;
            yukseklik1.Enabled = false;
            derinlik1.Enabled = false;
            cap1.Enabled = true;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = true;
            genislik2.Enabled = true;
            yukseklik2.Enabled = true;
            derinlik2.Enabled = true;
            cap2.Enabled = false;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true;
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Dikdörtgen Prizma ";
            cisim2.Text = " Dikdörtgen Prizma ";

            cisimler.Enabled = true;
            Xkoor1.Enabled = true;
            Ykoor1.Enabled = true;
            Zkoor1.Enabled = true;
            genislik1.Enabled = true;
            yukseklik1.Enabled = true;
            derinlik1.Enabled = true;
            cap1.Enabled = false;
            Xkoor2.Enabled = true;
            Ykoor2.Enabled = true;
            Zkoor2.Enabled = true;
            genislik2.Enabled = true;
            yukseklik2.Enabled = true;
            derinlik2.Enabled = true;
            cap2.Enabled = false;
            cisimlerinKordinatlarýnýGirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;
            cisimler.Visible = false;
        }

        public void Nesneler()//Çarpýþma denetimlerini kontrol etmek için her cismin kendine ait classýný kullanarak nesne oluþturulur.
        {
            nokta1 = new Nokta(Convert.ToInt32(Xkoor1.Text), Convert.ToInt32(Ykoor1.Text));
            nokta3D1 = new Nokta3d(new Nokta(Convert.ToInt32(Xkoor1.Text), Convert.ToInt32(Ykoor1.Text)), Convert.ToInt32(Zkoor1.Text));
            dikdortgen1 = new Dikdortgen(new Nokta(Convert.ToInt32(Xkoor1.Text), Convert.ToInt32(Ykoor1.Text)), Convert.ToInt32(genislik1.Text), Convert.ToInt32(yukseklik1.Text));
            cember1 = new Cember(new Nokta(Convert.ToInt32(Xkoor1.Text), Convert.ToInt32(Ykoor1.Text)), (Convert.ToInt32(cap1.Text) / 2));
            kure1 = new Kure(new Nokta3d(new Nokta(Convert.ToInt32(Xkoor1.Text), Convert.ToInt32(Ykoor1.Text)), Convert.ToInt32(Zkoor1.Text)), (Convert.ToInt32(cap1.Text) / 2));
            silindir1 = new Silindir(new Nokta3d(new Nokta(Convert.ToInt32(Xkoor1.Text), Convert.ToInt32(Ykoor1.Text)), Convert.ToInt32(Zkoor1.Text)), (Convert.ToInt32(cap1.Text) / 2), Convert.ToInt32(yukseklik1.Text));
            dikdortgenPrizma1 = new DikdortgenPrizma(new Nokta3d(new Nokta(Convert.ToInt32(Xkoor1.Text), Convert.ToInt32(Ykoor1.Text)), Convert.ToInt32(Zkoor1.Text)), Convert.ToInt32(genislik1.Text), Convert.ToInt32(yukseklik1.Text), Convert.ToInt32(derinlik1.Text));
            yuzey1 = new Yuzey(new Nokta3d(new Nokta(Convert.ToInt32(Xkoor1.Text), Convert.ToInt32(Ykoor1.Text)), Convert.ToInt32(Zkoor1.Text)), 1, Convert.ToInt32(yukseklik1.Text), Convert.ToInt32(derinlik1.Text));

            nokta2 = new Nokta(Convert.ToInt32(Xkoor2.Text), Convert.ToInt32(Ykoor2.Text));
            nokta3D2 = new Nokta3d(new Nokta(Convert.ToInt32(Xkoor2.Text), Convert.ToInt32(Ykoor2.Text)), Convert.ToInt32(Zkoor2.Text));
            dikdortgen2 = new Dikdortgen(new Nokta(Convert.ToInt32(Xkoor2.Text), Convert.ToInt32(Ykoor2.Text)), Convert.ToInt32(genislik2.Text), Convert.ToInt32(yukseklik2.Text));
            cember2 = new Cember(new Nokta(Convert.ToInt32(Xkoor2.Text), Convert.ToInt32(Ykoor2.Text)), (Convert.ToInt32(cap2.Text) / 2));
            kure2 = new Kure(new Nokta3d(new Nokta(Convert.ToInt32(Xkoor2.Text), Convert.ToInt32(Ykoor2.Text)), Convert.ToInt32(Zkoor2.Text)), (Convert.ToInt32(cap2.Text) / 2));
            silindir2 = new Silindir(new Nokta3d(new Nokta(Convert.ToInt32(Xkoor2.Text), Convert.ToInt32(Ykoor2.Text)), Convert.ToInt32(Zkoor2.Text)), (Convert.ToInt32(cap2.Text) / 2), Convert.ToInt32(yukseklik2.Text));
            dikdortgenPrizma2 = new DikdortgenPrizma(new Nokta3d(new Nokta(Convert.ToInt32(Xkoor2.Text), Convert.ToInt32(Ykoor2.Text)), Convert.ToInt32(Zkoor2.Text)), Convert.ToInt32(genislik2.Text), Convert.ToInt32(yukseklik2.Text), Convert.ToInt32(derinlik2.Text));
            yuzey2 = new Yuzey(new Nokta3d(new Nokta(Convert.ToInt32(Xkoor2.Text), Convert.ToInt32(Ykoor2.Text)), Convert.ToInt32(Zkoor2.Text)), 1, Convert.ToInt32(yukseklik2.Text), Convert.ToInt32(derinlik2.Text));
        }

        public void NoktaCiz(int x, int y)//Nokta þeklinin çizim kodlarý bulunmaktadýr.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);
            g.FillEllipse(kalem.Brush, x, y, 5, 5);
        }

        public void DikdortgenCiz(int x, int y, int genislik, int yukseklik)//Dikdörtgen þeklinin çizim kodlarý bulunmaktadýr.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);
            g.DrawRectangle(kalem, x, y, genislik, yukseklik);
        }

        public void CemberCiz(int x, int y, int cap)//Cember þeklinin çizim kodlarý bulunmaktadýr.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);
            g.DrawEllipse(kalem, (x - cap / 2), (y - cap / 2), cap, cap);
        }

        public void SilindirCiz(int x, int y, int yukseklik, int cap)//Silindir þeklinin çizim kodlarý bulunmaktadýr.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);

            // Silindirin yarýçapý
            int yaricap = (capB / 2);

            // Silindirin üst ve alt elipslerini çiz
            g.DrawEllipse(kalem, x - (cap / 2), y - (cap / 2), cap, cap / 2);
            g.DrawEllipse(kalem, x - (cap / 2), (y + yukseklik) - (cap / 2), cap, cap / 2);

            // Silindirin yan yüzeylerini çiz
            g.DrawLine(kalem, x - (cap / 2), y - (cap / 4), x - (cap / 2), (y + yukseklik - (cap / 4)));
            g.DrawLine(kalem, x + (cap / 2), y - (cap / 4), x + (cap / 2), (y + yukseklik - (cap / 4)));
        }

        public void KureCiz(int x, int y, int cap)//Küre þeklinin çizim kodlarý bulunmaktadýr.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);
            g.DrawEllipse(kalem, (x - cap / 2), (y - cap / 2), cap, cap);
            g.DrawEllipse(kalem, (x - cap / 2), (y - cap / 2) + cap / 2 - 5, cap, cap / 4);
        }

        public void DikdortgenPrizmaCiz(int x, int y, int genislik, int yukseklik, int derinlik)//Dikdörtgen Prizma þeklinin çizim kodlarý bulunmaktadýr.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);
            //Alt Yüzey
            g.DrawRectangle(kalem, x, y, genislik, yukseklik);
            // Üst Yüzey
            g.DrawRectangle(kalem, x + derinlik, y + derinlik, genislik, yukseklik);
            //Yan Yüzeyler
            g.DrawLine(kalem, x, y, x + derinlik, y + derinlik);
            g.DrawLine(kalem, x + genislik, y, x + genislik + derinlik, y + derinlik);
            g.DrawLine(kalem, x, y + yukseklik, x + derinlik, y + yukseklik + derinlik);
            g.DrawLine(kalem, x + genislik, y + yukseklik, x + genislik + derinlik, y + yukseklik + derinlik);
            ///////////////
        }

        public void YuzeyCiz(int x, int y, int yukseklik, int derinlik)//Yuzey þeklinin çizim kodlarý bulunmaktadýr.
        {
            Pen kalem = new Pen(Color.Red, 3);
            int genislik = 1;
            //Alt Yüzey
            g.DrawRectangle(kalem, x, y, genislik, yukseklik);
            // Üst Yüzey
            g.DrawRectangle(kalem, x + derinlik, y + derinlik, genislik, yukseklik);
            //Yan Yüzeyler
            g.DrawLine(kalem, x, y, x + derinlik, y + derinlik);
            g.DrawLine(kalem, x + genislik, y, x + genislik + derinlik, y + derinlik);
            g.DrawLine(kalem, x, y + yukseklik, x + derinlik, y + yukseklik + derinlik);
            g.DrawLine(kalem, x + genislik, y + yukseklik, x + genislik + derinlik, y + yukseklik + derinlik);
            ///
        }

        public void DegerAtama()//Seçilen her çarpýþma denetimindeki þekiller için dýþarýdan alýnan þeklin özellik deðerlerini kodda kullanýmýný kolaylaþtýrmak için yeni deðiþkenlere atama iþleminin yapýldýðý fonksiyon.
        {
            if (radioButton1.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                genislikA = 5;
                yukseklikA = 5;
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                genislikB = Convert.ToInt32(genislik2.Text);
                yukseklikB = Convert.ToInt32(yukseklik2.Text);

            }
            if (radioButton2.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                genislikA = 5;
                yukseklikA = 5;
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                capB = Convert.ToInt32(cap2.Text);

            }
            if (radioButton3.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                genislikA = Convert.ToInt32(genislik1.Text);
                yukseklikA = Convert.ToInt32(yukseklik1.Text);
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                genislikB = Convert.ToInt32(genislik2.Text);
                yukseklikB = Convert.ToInt32(yukseklik2.Text);
            }
            if (radioButton4.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                genislikA = Convert.ToInt32(genislik1.Text);
                yukseklikA = Convert.ToInt32(yukseklik1.Text);
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                capB = Convert.ToInt32(cap2.Text);
            }
            if (radioButton5.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                capA = Convert.ToInt32(cap1.Text);
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                capB = Convert.ToInt32(cap2.Text);
            }
            if (radioButton6.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                zKoorA = Convert.ToInt32(Zkoor1.Text);
                genislikA = 5;
                yukseklikA = 5;
                derinlikA = 5;
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                zKoorB = Convert.ToInt32(Zkoor2.Text);
                capB = Convert.ToInt32(cap2.Text);
            }
            if (radioButton7.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                zKoorA = Convert.ToInt32(Zkoor1.Text);
                genislikA = 5;
                yukseklikA = 5;
                derinlikA = 5;
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                zKoorB = Convert.ToInt32(Zkoor2.Text);
                genislikB = Convert.ToInt32(genislik2.Text);
                yukseklikB = Convert.ToInt32(yukseklik2.Text);
                derinlikB = Convert.ToInt32(derinlik2.Text);
            }
            if (radioButton8.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                zKoorA = Convert.ToInt32(Zkoor1.Text);
                genislikA = 5;
                yukseklikA = 5;
                derinlikA = 5;
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                zKoorB = Convert.ToInt32(Zkoor2.Text);
                capB = Convert.ToInt32(cap2.Text);
                yukseklikB = Convert.ToInt32(yukseklik2.Text);
            }
            if (radioButton9.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                zKoorA = Convert.ToInt32(Zkoor1.Text);
                capA = Convert.ToInt32(cap1.Text);
                yukseklikA = Convert.ToInt32(yukseklik1.Text);
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                zKoorB = Convert.ToInt32(Zkoor2.Text);
                capB = Convert.ToInt32(cap2.Text);
                yukseklikB = Convert.ToInt32(yukseklik2.Text);
            }
            if (radioButton10.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                zKoorA = Convert.ToInt32(Zkoor1.Text);
                capA = Convert.ToInt32(cap1.Text);
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                zKoorB = Convert.ToInt32(Zkoor2.Text);
                capB = Convert.ToInt32(cap2.Text);
            }
            if (radioButton11.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                zKoorA = Convert.ToInt32(Zkoor1.Text);
                capA = Convert.ToInt32(cap1.Text);
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                zKoorB = Convert.ToInt32(Zkoor2.Text);
                capB = Convert.ToInt32(cap2.Text);
                yukseklikB = Convert.ToInt32(yukseklik2.Text);
            }
            if (radioButton12.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                zKoorA = Convert.ToInt32(Zkoor1.Text);
                capA = Convert.ToInt32(cap1.Text);
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                zKoorB = Convert.ToInt32(Zkoor2.Text);
                genislikB = 1;
                yukseklikB = Convert.ToInt32(yukseklik2.Text);
                derinlikB = Convert.ToInt32(derinlik2.Text);
            }
            if (radioButton13.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                zKoorA = Convert.ToInt32(Zkoor1.Text);
                genislikA = 1;
                yukseklikA = Convert.ToInt32(yukseklik1.Text);
                derinlikA = Convert.ToInt32(derinlik1.Text);
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                zKoorB = Convert.ToInt32(Zkoor2.Text);
                genislikB = Convert.ToInt32(genislik2.Text);
                yukseklikB = Convert.ToInt32(yukseklik2.Text);
                derinlikB = Convert.ToInt32(derinlik2.Text);
            }
            if (radioButton14.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                zKoorA = Convert.ToInt32(Zkoor1.Text);
                genislikA = 1;
                yukseklikA = Convert.ToInt32(yukseklik1.Text);
                derinlikA = Convert.ToInt32(derinlik1.Text);
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                zKoorB = Convert.ToInt32(Zkoor2.Text);
                capB = Convert.ToInt32(cap2.Text);
                yukseklikB = Convert.ToInt32(yukseklik2.Text);
            }
            if (radioButton15.Checked)
            {
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                zKoorB = Convert.ToInt32(Zkoor2.Text);
                genislikB = Convert.ToInt32(genislik2.Text);
                yukseklikB = Convert.ToInt32(yukseklik2.Text);
                derinlikB = Convert.ToInt32(derinlik2.Text);
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                zKoorA = Convert.ToInt32(Zkoor1.Text);
                capA = Convert.ToInt32(cap1.Text);
            }
            if (radioButton16.Checked)
            {
                xKoorA = Convert.ToInt32(Xkoor1.Text);
                yKoorA = Convert.ToInt32(Ykoor1.Text);
                zKoorA = Convert.ToInt32(Zkoor1.Text);
                genislikA = Convert.ToInt32(genislik1.Text);
                yukseklikA = Convert.ToInt32(yukseklik1.Text);
                derinlikA = Convert.ToInt32(derinlik1.Text);
                xKoorB = Convert.ToInt32(Xkoor2.Text);
                yKoorB = Convert.ToInt32(Ykoor2.Text);
                zKoorB = Convert.ToInt32(Zkoor2.Text);
                genislikB = Convert.ToInt32(genislik2.Text);
                yukseklikB = Convert.ToInt32(yukseklik2.Text);
                derinlikB = Convert.ToInt32(derinlik2.Text);
            }
        }

        public void SekilleriCiz()//Seçilen her çarpýþma denetimindeki þekillerin kendine ait çizdirme fonksiyonunu çaðýrarak form ekranýna çizdirmeyi saðlar. 
        {
            if (radioButton1.Checked)
            {
                NoktaCiz(xKoorA, yKoorA);
                DikdortgenCiz(xKoorB, yKoorB, genislikB, yukseklikB);
            }
            if (radioButton2.Checked)
            {
                NoktaCiz(xKoorA, yKoorA);
                CemberCiz(xKoorB, yKoorB, capB);
            }
            if (radioButton3.Checked)
            {
                DikdortgenCiz(xKoorA, yKoorA, genislikA, yukseklikA);
                DikdortgenCiz(xKoorB, yKoorB, genislikB, yukseklikB);
            }
            if (radioButton4.Checked)
            {
                DikdortgenCiz(xKoorA, yKoorA, genislikA, yukseklikA);
                CemberCiz(xKoorB, yKoorB, capB);
            }
            if (radioButton5.Checked)
            {
                CemberCiz(xKoorA, yKoorA, capA);
                CemberCiz(xKoorB, yKoorB, capB);
            }
            if (radioButton6.Checked)
            {
                NoktaCiz(xKoorA, yKoorA);
                KureCiz(xKoorB, yKoorB, capB);
            }
            if (radioButton7.Checked)
            {
                NoktaCiz(xKoorA, yKoorB);
                DikdortgenPrizmaCiz(xKoorB, yKoorB, genislikB, yukseklikB, derinlikB);
            }
            if (radioButton8.Checked)
            {
                
                NoktaCiz(xKoorA, yKoorA);
                SilindirCiz(xKoorB, yKoorB, yukseklikB, capB);
            }
            if (radioButton9.Checked)
            {
                SilindirCiz(xKoorA, yKoorA, yukseklikA, capA);
                SilindirCiz(xKoorB, yKoorB, yukseklikB, capB);
            }
            if (radioButton10.Checked)
            {
                KureCiz(xKoorA, yKoorA, capA);
                KureCiz(xKoorB, yKoorB, capB);
            }
            if (radioButton11.Checked)
            {
                KureCiz(xKoorA, yKoorA, capA);
                SilindirCiz(xKoorB, yKoorB, yukseklikB, capB);
            }
            if (radioButton12.Checked)
            {
                KureCiz(xKoorA, yKoorA, capA);
                YuzeyCiz(xKoorB, yKoorB, yukseklikB, derinlikB);
            }
            if (radioButton13.Checked)
            {
                YuzeyCiz(xKoorA, yKoorA, yukseklikA, derinlikA);
                DikdortgenPrizmaCiz(xKoorB, yKoorB, genislikB, yukseklikB, derinlikB);
            }
            if (radioButton14.Checked)
            {
                YuzeyCiz(xKoorA, yKoorA, yukseklikA, derinlikA);
                SilindirCiz(yKoorB, yKoorB, yukseklikB, capB);
            }
            if (radioButton15.Checked)
            {
                KureCiz(xKoorA, yKoorA, capA);
                DikdortgenPrizmaCiz(xKoorB, yKoorB, genislikB, yukseklikB, derinlikB);

            }
            if (radioButton16.Checked)
            {
                DikdortgenPrizmaCiz(xKoorA, yKoorA, genislikA, yukseklikA, derinlikA);
                DikdortgenPrizmaCiz(xKoorB, yKoorB, genislikB, yukseklikB, derinlikB);
            }
            cisimler.Enabled = false;
            sonuc.Enabled = false;

            DenetimKontrolu();
        }

        public void DenetimKontrolu()//Oluþturulan nesne fonksiyonunu çaðýrarak CarpýsmaDenetimi classýný kullanarak ilgili nesneleri yerleþtirip çarpýþma olup olmadýðýný kontrol eder ve kullanýcýyý bilgilendirir.
        {
            Nesneler();
            if (radioButton1.Checked)
            {
                if (carpismadenetimi.NoktaDikdortgen(nokta1, dikdortgen2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {

                    sonuc.Text = "Çarpýþma Yok";
                }

            }
            if (radioButton2.Checked)
            {
                if (carpismadenetimi.NoktaCember(nokta1, cember2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }

            }
            if (radioButton3.Checked)
            {
                if (carpismadenetimi.DikdortgenDikdortgen(dikdortgen1, dikdortgen2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton4.Checked)
            {
                if (carpismadenetimi.DikdortgenCember(dikdortgen1, cember2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton5.Checked)
            {
                if (carpismadenetimi.CemberCember(cember1, cember2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton6.Checked)
            {
                if (carpismadenetimi.NoktaKure(nokta3D1, kure2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton7.Checked)
            {
                if (carpismadenetimi.NoktaDikdortgenlerPrizma(nokta3D1, dikdortgenPrizma2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton8.Checked)
            {
                if (carpismadenetimi.NoktaSilindir(nokta3D1, silindir1))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }

            }
            if (radioButton9.Checked)
            {
                if (carpismadenetimi.SilindirSilindir(silindir1, silindir2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton10.Checked)
            {
                if (carpismadenetimi.KureKure(kure1, kure2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton11.Checked)
            {
                if (carpismadenetimi.KureSilindir(kure1, silindir2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton12.Checked)
            {
                if (carpismadenetimi.KureYuzey(kure1, yuzey2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton13.Checked)
            {
                if (carpismadenetimi.YuzeyDikdortgenlerPrizma(yuzey1, dikdortgenPrizma2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton14.Checked)
            {
                if (carpismadenetimi.YuzeySilindir(yuzey1, silindir2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton15.Checked)
            {
                if (carpismadenetimi.DikdortgenPrizmaKure(kure1, dikdortgenPrizma2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
            if (radioButton16.Checked)
            {
                if (carpismadenetimi.DikdortgenPrizmaDikdortgenPrizma(dikdortgenPrizma1, dikdortgenPrizma2))
                {
                    sonuc.Text = "Çarpýþma Var";
                }
                else
                {
                    sonuc.Text = "Çarpýþma Yok";
                }
            }
        }

        private void testEtToolStripMenuItem_Click(object sender, EventArgs e)//Test Et butonuna týkladýktan sonra dýþarýdan özellik alma penceresinin görünürlüðünü kapatýp formu temizler ardýndan da þekilleri forma çizdirir.
        {
            cisimler.Visible = false;
            g.Clear(BackColor);
            DegerAtama();
            SekilleriCiz();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//Kýlavyedeki belirlenen tuþlar ile cisimlerin hareketlerini gerçekleþtiren fonksiyon.
        {
            cisimler.Visible = false;
            int hareketHizi = 5;
            // Kýlavyedeki Belirlenen tuþlara týklandýktan sonra þekil 1 ve þekil 2 için x ve y kordinatlarýnda deðiþiklik olur.
            if (e.KeyCode == Keys.W)
            {
                Ykoor1.Text = (Convert.ToInt32(Ykoor1.Text) - hareketHizi).ToString();
            }
            else if (e.KeyCode == Keys.A)
            {
                Xkoor1.Text = (Convert.ToInt32(Xkoor1.Text) - hareketHizi).ToString();
            }
            else if (e.KeyCode == Keys.S)
            {
                Ykoor1.Text = (Convert.ToInt32(Ykoor1.Text) + hareketHizi).ToString();
            }
            else if (e.KeyCode == Keys.D)
            {
                Xkoor1.Text = (Convert.ToInt32(Xkoor1.Text) + hareketHizi).ToString();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Ykoor2.Text = (Convert.ToInt32(Ykoor2.Text) - hareketHizi).ToString();
            }
            else if (e.KeyCode == Keys.Left)
            {
                Xkoor2.Text = (Convert.ToInt32(Xkoor2.Text) - hareketHizi).ToString();
            }
            else if (e.KeyCode == Keys.Down)
            {
                Ykoor2.Text = (Convert.ToInt32(Ykoor2.Text) + hareketHizi).ToString();
            }
            else if (e.KeyCode == Keys.Right)
            {
                Xkoor2.Text = (Convert.ToInt32(Xkoor2.Text) + hareketHizi).ToString();
            }
            //Deðiþen kordinatlarý kullanarak cisimleri yeniden çizdirme iþlemini gerçekleþtiren kodlar aþaðýda.
            g.Clear(BackColor);
            DegerAtama();
            SekilleriCiz();

        }

        private void cisimlerinKordinatlarýnýGirToolStripMenuItem_Click_1(object sender, EventArgs e)//Kordinat giriþ ekranýnýn görünürlüðünü ayarlar.
        {
            cisimler.Visible = true;
            cisimler.Enabled = true;
        }

        private void bilgilendirmeToolStripMenuItem_Click(object sender, EventArgs e)//Kullanýcýyý bilgilendiren mesaj kutusu bulunmaktadýr.
        {
            MessageBox.Show("KULLANIM KILAVUZU ADIMLARI \n" +
               "1-)Uygulama baþladýðýnda ilk olarak sol üst kýsýmdan çarpýþma denetimini seçniz.\n" +
               "2-)Açýlan pencerede 2 cisim için 2 pencere bulunmaktadýr.Aktif olan özellikleri doldurunuz.\n" +
               "3-)Bilgileri girdikten sonra Þekilleri Çiz Ve Test Butonuna týklayýnýz.\n" +
               "4-)Cisimlerin özelliklerini deðiþtirmek istiyorsanýz Cisimlerin Özelliklerini Gir butonuna týklayýnýz." +
               "5-)Baþka bir çarpýþma denetimi yapmak istiyorsanýz adým birden itibaren tekrardan gerçekleþtiriniz.\n" +
               "6-)1.Cisim W-A-S-D / 2.Cisim yön tuþlarý ile hareket eder.");


        }
    }
}