/*******************************************************************************************************************
**				                                      	SAKARYA �N�VERS�TES�
**				                                B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				                                    B�LG�SAYAR M�HEND�SL��� B�L�M�
**				                                 NESNEYE DAYALI PROGRAMLAMA DERS�
**					                                    2023-2024 BAHAR D�NEM�
**	
**				                                      �DEV NUMARASI..........: 2
**				                                      ��RENC� ADI............: MEHMET CAN BAYAR
**				                                      ��RENC� NUMARASI.......: B231210042
**                                                    DERS�N ALINDI�I GRUP...: A
******************************************************************************************************************/
using odev2_NDP.Geometrik_�ekiller;
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
               "1-)Uygulama ba�lad���nda ilk olarak sol �st k�s�mdan �arp��ma denetimini se�niz.\n" +
               "2-)A��lan pencerede 2 cisim i�in 2 pencere bulunmaktad�r.Aktif olan �zellikleri doldurunuz.\n" +
               "3-)Bilgileri girdikten sonra �ekilleri �iz Ve Test Butonuna t�klay�n�z.\n" +
               "4-)Cisimlerin �zelliklerini de�i�tirmek istiyorsan�z Cisimlerin �zelliklerini Gir butonuna t�klay�n�z." +
               "5-)Ba�ka bir �arp��ma denetimi yapmak istiyorsan�z ad�m birden itibaren tekrardan ger�ekle�tiriniz.\n" +
               "6-)1.Cisim W-A-S-D / 2.Cisim y�n tu�lar� ile hareket eder.");

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

        //�arp��ma denetimini se�mek i�in grupbox� g�r�n�r yapar.
        private void carp_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        //Radio Butonlardaki �arp��ma denetimi se�ilir.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Nokta ";
            cisim2.Text = " Dikd�rtgen ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Nokta ";
            cisim2.Text = " �ember ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Dikd�rtgen ";
            cisim2.Text = " Dikd�rtgen ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Dikd�rtgen ";
            cisim2.Text = " �ember ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " �ember ";
            cisim2.Text = " �ember ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Nokta ";
            cisim2.Text = " K�re ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Nokta ";
            cisim2.Text = " Dikd�rtgen Prizma ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Enabled = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " K�re ";
            cisim2.Text = " K�re ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Enabled = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " K�re ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " K�re ";
            cisim2.Text = " Y�zey ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Y�zey ";
            cisim2.Text = " Dikd�rtgen Prizma ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Y�zey ";
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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " K�re ";
            cisim2.Text = " Dikd�rtgen Prizma ";

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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true;
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cisim1.Text = " Dikd�rtgen Prizma ";
            cisim2.Text = " Dikd�rtgen Prizma ";

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
            cisimlerinKordinatlar�n�GirToolStripMenuItem.Visible = true;
            testEtToolStripMenuItem.Visible = true;
            cisimler.Visible = true; Xkoor1.Value = 0; Ykoor1.Value = 0; Zkoor1.Value = 0; genislik1.Value = 0; yukseklik1.Value = 0; derinlik1.Value = 0; cap1.Value = 0;            
            Xkoor2.Value = 0; Ykoor2.Value = 0; Zkoor2.Value = 0; genislik2.Value = 0; yukseklik2.Value = 0; derinlik2.Value = 0; cap2.Value = 0;
            cisimler.Visible = false;
        }

        public void Nesneler()//�arp��ma denetimlerini kontrol etmek i�in her cismin kendine ait class�n� kullanarak nesne olu�turulur.
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

        public void NoktaCiz(int x, int y)//Nokta �eklinin �izim kodlar� bulunmaktad�r.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);
            g.FillEllipse(kalem.Brush, x, y, 5, 5);
        }

        public void DikdortgenCiz(int x, int y, int genislik, int yukseklik)//Dikd�rtgen �eklinin �izim kodlar� bulunmaktad�r.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);
            g.DrawRectangle(kalem, x, y, genislik, yukseklik);
        }

        public void CemberCiz(int x, int y, int cap)//Cember �eklinin �izim kodlar� bulunmaktad�r.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);
            g.DrawEllipse(kalem, (x - cap / 2), (y - cap / 2), cap, cap);
        }

        public void SilindirCiz(int x, int y, int yukseklik, int cap)//Silindir �eklinin �izim kodlar� bulunmaktad�r.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);

            // Silindirin yar��ap�
            int yaricap = (capB / 2);

            // Silindirin �st ve alt elipslerini �iz
            g.DrawEllipse(kalem, x - (cap / 2), y - (cap / 2), cap, cap / 2);
            g.DrawEllipse(kalem, x - (cap / 2), (y + yukseklik) - (cap / 2), cap, cap / 2);

            // Silindirin yan y�zeylerini �iz
            g.DrawLine(kalem, x - (cap / 2), y - (cap / 4), x - (cap / 2), (y + yukseklik - (cap / 4)));
            g.DrawLine(kalem, x + (cap / 2), y - (cap / 4), x + (cap / 2), (y + yukseklik - (cap / 4)));
        }

        public void KureCiz(int x, int y, int cap)//K�re �eklinin �izim kodlar� bulunmaktad�r.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);
            g.DrawEllipse(kalem, (x - cap / 2), (y - cap / 2), cap, cap);
            g.DrawEllipse(kalem, (x - cap / 2), (y - cap / 2) + cap / 2 - 5, cap, cap / 4);
        }

        public void DikdortgenPrizmaCiz(int x, int y, int genislik, int yukseklik, int derinlik)//Dikd�rtgen Prizma �eklinin �izim kodlar� bulunmaktad�r.
        {
            // Kalem rengi ve boyutu
            Pen kalem = new Pen(Color.Black, 3);
            //Alt Y�zey
            g.DrawRectangle(kalem, x, y, genislik, yukseklik);
            // �st Y�zey
            g.DrawRectangle(kalem, x + derinlik, y + derinlik, genislik, yukseklik);
            //Yan Y�zeyler
            g.DrawLine(kalem, x, y, x + derinlik, y + derinlik);
            g.DrawLine(kalem, x + genislik, y, x + genislik + derinlik, y + derinlik);
            g.DrawLine(kalem, x, y + yukseklik, x + derinlik, y + yukseklik + derinlik);
            g.DrawLine(kalem, x + genislik, y + yukseklik, x + genislik + derinlik, y + yukseklik + derinlik);
            ///////////////
        }

        public void YuzeyCiz(int x, int y, int yukseklik, int derinlik)//Yuzey �eklinin �izim kodlar� bulunmaktad�r.
        {
            Pen kalem = new Pen(Color.Red, 3);
            int genislik = 1;
            //Alt Y�zey
            g.DrawRectangle(kalem, x, y, genislik, yukseklik);
            // �st Y�zey
            g.DrawRectangle(kalem, x + derinlik, y + derinlik, genislik, yukseklik);
            //Yan Y�zeyler
            g.DrawLine(kalem, x, y, x + derinlik, y + derinlik);
            g.DrawLine(kalem, x + genislik, y, x + genislik + derinlik, y + derinlik);
            g.DrawLine(kalem, x, y + yukseklik, x + derinlik, y + yukseklik + derinlik);
            g.DrawLine(kalem, x + genislik, y + yukseklik, x + genislik + derinlik, y + yukseklik + derinlik);
            ///
        }

        public void DegerAtama()//Se�ilen her �arp��ma denetimindeki �ekiller i�in d��ar�dan al�nan �eklin �zellik de�erlerini kodda kullan�m�n� kolayla�t�rmak i�in yeni de�i�kenlere atama i�leminin yap�ld��� fonksiyon.
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

        public void SekilleriCiz()//Se�ilen her �arp��ma denetimindeki �ekillerin kendine ait �izdirme fonksiyonunu �a��rarak form ekran�na �izdirmeyi sa�lar. 
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

        public void DenetimKontrolu()//Olu�turulan nesne fonksiyonunu �a��rarak Carp�smaDenetimi class�n� kullanarak ilgili nesneleri yerle�tirip �arp��ma olup olmad���n� kontrol eder ve kullan�c�y� bilgilendirir.
        {
            Nesneler();
            if (radioButton1.Checked)
            {
                if (carpismadenetimi.NoktaDikdortgen(nokta1, dikdortgen2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {

                    sonuc.Text = "�arp��ma Yok";
                }

            }
            if (radioButton2.Checked)
            {
                if (carpismadenetimi.NoktaCember(nokta1, cember2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }

            }
            if (radioButton3.Checked)
            {
                if (carpismadenetimi.DikdortgenDikdortgen(dikdortgen1, dikdortgen2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
            if (radioButton4.Checked)
            {
                if (carpismadenetimi.DikdortgenCember(dikdortgen1, cember2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
            if (radioButton5.Checked)
            {
                if (carpismadenetimi.CemberCember(cember1, cember2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
            if (radioButton6.Checked)
            {
                if (carpismadenetimi.NoktaKure(nokta3D1, kure2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
            if (radioButton7.Checked)
            {
                if (carpismadenetimi.NoktaDikdortgenlerPrizma(nokta3D1, dikdortgenPrizma2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
            if (radioButton8.Checked)
            {
                if (carpismadenetimi.NoktaSilindir(nokta3D1, silindir1))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }

            }
            if (radioButton9.Checked)
            {
                if (carpismadenetimi.SilindirSilindir(silindir1, silindir2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
            if (radioButton10.Checked)
            {
                if (carpismadenetimi.KureKure(kure1, kure2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
            if (radioButton11.Checked)
            {
                if (carpismadenetimi.KureSilindir(kure1, silindir2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
            if (radioButton12.Checked)
            {
                if (carpismadenetimi.KureYuzey(kure1, yuzey2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
            if (radioButton13.Checked)
            {
                if (carpismadenetimi.YuzeyDikdortgenlerPrizma(yuzey1, dikdortgenPrizma2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
            if (radioButton14.Checked)
            {
                if (carpismadenetimi.YuzeySilindir(yuzey1, silindir2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
            if (radioButton15.Checked)
            {
                if (carpismadenetimi.DikdortgenPrizmaKure(kure1, dikdortgenPrizma2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma�Yok";
                }
            }
            if (radioButton16.Checked)
            {
                if (carpismadenetimi.DikdortgenPrizmaDikdortgenPrizma(dikdortgenPrizma1, dikdortgenPrizma2))
                {
                    sonuc.Text = "�arp��ma Var";
                }
                else
                {
                    sonuc.Text = "�arp��ma Yok";
                }
            }
        }

        private void testEtToolStripMenuItem_Click(object sender, EventArgs e)//Test Et butonuna t�klad�ktan sonra d��ar�dan �zellik alma penceresinin g�r�n�rl���n� kapat�p formu temizler ard�ndan da �ekilleri forma �izdirir.
        {
            cisimler.Visible = false;
            g.Clear(BackColor);
            DegerAtama();
            SekilleriCiz();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//K�lavyedeki belirlenen tu�lar ile cisimlerin hareketlerini ger�ekle�tiren fonksiyon.
        {
            cisimler.Visible = false;
            int hareketHizi = 5;
            // K�lavyedeki Belirlenen tu�lara t�kland�ktan sonra �ekil 1 ve �ekil 2 i�in x ve y kordinatlar�nda de�i�iklik olur.
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
            //De�i�en kordinatlar� kullanarak cisimleri yeniden �izdirme i�lemini ger�ekle�tiren kodlar a�a��da.
            g.Clear(BackColor);
            DegerAtama();
            SekilleriCiz();

        }

        private void cisimlerinKordinatlar�n�GirToolStripMenuItem_Click_1(object sender, EventArgs e)//Kordinat giri� ekran�n�n g�r�n�rl���n� ayarlar.
        {
            cisimler.Visible = true;
            cisimler.Enabled = true;
        }

        private void bilgilendirmeToolStripMenuItem_Click(object sender, EventArgs e)//Kullan�c�y� bilgilendiren mesaj kutusu bulunmaktad�r.
        {
            MessageBox.Show("KULLANIM KILAVUZU ADIMLARI \n" +
               "1-)Uygulama ba�lad���nda ilk olarak sol �st k�s�mdan �arp��ma denetimini se�niz.\n" +
               "2-)A��lan pencerede 2 cisim i�in 2 pencere bulunmaktad�r.Aktif olan �zellikleri doldurunuz.\n" +
               "3-)Bilgileri girdikten sonra �ekilleri �iz Ve Test Butonuna t�klay�n�z.\n" +
               "4-)Cisimlerin �zelliklerini de�i�tirmek istiyorsan�z Cisimlerin �zelliklerini Gir butonuna t�klay�n�z." +
               "5-)Ba�ka bir �arp��ma denetimi yapmak istiyorsan�z ad�m birden itibaren tekrardan ger�ekle�tiriniz.\n" +
               "6-)1.Cisim W-A-S-D / 2.Cisim y�n tu�lar� ile hareket eder.");


        }
    }
}