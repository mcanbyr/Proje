
/****************************************************************************************************************************************
**				                                      	SAKARYA ÜNÝVERSÝTESÝ
**				                                BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				                                    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				                                   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					                                   2023-2024 BAHAR DÖNEMÝ
**                                                          PROJE ÖDEVÝ
**	
**				                                   ÖDEV NUMARASI..........: Proje Ödevi
**				                                   ÖÐRENCÝ ADI............: MEHMET CAN BAYAR
**				                                   ÖÐRENCÝ NUMARASI.......: B231210042
**                                                 DERSÝN ALINDIÐI GRUP...: A Grubu 1.Öðretim
****************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace Proje_NDP
{
    public interface IRandevuIslemleri
    {
        void DosyayaYaz(string veri);
        void TemizleForm();
    }
    public partial class Form1 : Form, IRandevuIslemleri
    {
        // Dýþarýdan girilen deðerlerin boþ olup olmadýðýný kontrol eden fonksiyon
        private bool GirdiBosMu(string girdi)
        {
            return string.IsNullOrWhiteSpace(girdi);
        }

        // Mail adresinin geçerli olup olmadýðýný kontrol eden fonksiyon
        private bool GecerliMailAdresiMi(string mail)
        {
            try
            {
                var addr = new MailAddress(mail);
                return addr.Address == mail;
            }
            catch
            {
                return false;
            }
        }

        // Personel seçilip seçilmediðini kontrol eden fonksiyon
        private bool PersonelSecildiMi()
        {
            return Personeller.SelectedIndex != -1;
        }

        // Randevu oluþtururken girilen deðerleri kontrol eden fonksiyon
        private bool RandevuDegerleriniKontrolEt()
        {
            if (GirdiBosMu(musteriAd.Text) ||
                GirdiBosMu(musteriSoyad.Text) ||
                GirdiBosMu(musteriTelNo.Text) ||
                GirdiBosMu(musteriMail.Text) ||
                GirdiBosMu(comboBox1.SelectedItem?.ToString()) ||
                !PersonelSecildiMi() ||
                !GecerliMailAdresiMi(musteriMail.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz ve doðru bir þekilde giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Randevu düzenlerken girilen deðerleri kontrol eden fonksiyon
        private bool DuzenlenenRandevuDegerleriniKontrolEt()
        {
            if (GirdiBosMu(yeniAd.Text) ||
                GirdiBosMu(yeniSoyad.Text) ||
                GirdiBosMu(yeniTelno.Text) ||
                GirdiBosMu(yeniEmail.Text) ||
                GirdiBosMu(comboBox2.SelectedItem?.ToString()) ||
                GirdiBosMu(Personeller1.SelectedItem?.ToString()) ||
                !GecerliMailAdresiMi(yeniEmail.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz ve doðru bir þekilde giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Randevu oluþtur butonunun týklama olayý
        private void ButtonRandevuKaydet_Click(object sender, EventArgs e)
        {
            if (!RandevuDegerleriniKontrolEt())
                return;

            string yeniRandevuTarihi = RandevuTarih.Text;
            string yeniRandevuSaati = comboBox1.SelectedItem.ToString();
            string seciliPersonel = Personeller.SelectedItem.ToString();

            // Dosyadan randevu bilgilerini oku ve kontrol et
            using (StreamReader sr = new StreamReader("randevular.txt"))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    string[] bilgiler = satir.Split(',');
                    string randevuTarihi = bilgiler[4];
                    string randevuSaati = bilgiler[5];
                    string randevuPersoneli = bilgiler[6];

                    // Ayný tarih, saat ve personelde bir randevu varsa uyarý ver
                    if (randevuTarihi == yeniRandevuTarihi && randevuSaati == yeniRandevuSaati && randevuPersoneli == seciliPersonel)
                    {
                        MessageBox.Show("Bu tarih ve saatte seçilen personel için zaten bir randevu bulunmaktadýr. Lütfen baþka bir tarih/saat veya personel seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            // Yukarýdaki kontrolü geçtiyse randevuyu kaydet
            Musteri musteri = new Musteri(musteriAd.Text, musteriSoyad.Text, musteriTelNo.Text, musteriMail.Text);
            List<string> secilenHizmetler = new();
            foreach (CheckBox checkbox in hizmetCheckBoxes1)
            {
                if (checkbox.Checked)
                {
                    secilenHizmetler.Add(checkbox.Text.Replace("Randevu Hizmeti ", ""));
                }
            }

            if (secilenHizmetler.Count == 0)
            {
                MessageBox.Show("Lütfen bir hizmet seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hizmetlerString = string.Join("/", secilenHizmetler);
            string randevuBilgisi = $"{musteri.Ad},{musteri.Soyad},{musteri.Telefon},{musteri.Email},{yeniRandevuTarihi},{yeniRandevuSaati},{seciliPersonel},{hizmetlerString}";

            dataGridViewRandevular.Rows.Add(new object[]
            {
                musteriAd.Text,musteriSoyad.Text,musteriTelNo.Text,musteriMail.Text,RandevuTarih.Text,comboBox1,seciliPersonel,secilenHizmetler
            });


            DosyayaYaz(randevuBilgisi);
            YukleRandevular();
            TemizleForm();
            MessageBox.Show("Randevu bilgileri baþarýyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Randevu güncelle butonunun týklama olayý
        private void RandevuGuncelle_Click(object sender, EventArgs e)
        {
            if (!DuzenlenenRandevuDegerleriniKontrolEt())
                return;


            // Müþteri bilgilerini al
            Musteri musteri = new Musteri(yeniAd.Text, yeniSoyad.Text, yeniTelno.Text, yeniEmail.Text);

            // Seçilen hizmetleri bir liste olarak al
            List<string> secilenHizmetler = new();
            foreach (CheckBox checkbox in hizmetCheckBoxes2)
            {
                if (checkbox.Checked)
                {
                    secilenHizmetler.Add(checkbox.Text.Replace("Randevu Hizmeti ", ""));
                }
            }

            // Eðer hiçbir hizmet seçilmediyse uyarý ver
            if (secilenHizmetler.Count == 0)
            {
                MessageBox.Show("Lütfen bir hizmet seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Seçilen hizmetleri '/' iþaretiyle birleþtir
            string hizmetlerString = string.Join("/", secilenHizmetler);

            // Diðer bilgilerle birlikte randevu bilgisini oluþtur
            string randevuBilgisi = $"{musteri.Ad},{musteri.Soyad},{musteri.Telefon},{musteri.Email},{yeniTarih.Text},{comboBox2.SelectedItem},{Personeller1.SelectedItem},{hizmetlerString}";

            // Dosyaya randevu bilgilerini yaz
            DosyayaYaz(randevuBilgisi);

            RandevuSil();
            YukleRandevular();
            // Formu temizle
            TemizleForm();
            MessageBox.Show("Randevu bilgileri baþarýyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        CheckBox[] hizmetCheckBoxes1, hizmetCheckBoxes2;

        //Dosyaya yazma iþlemleri yapýlýr.
        public void DosyayaYaz(string veri)
        {
            using (StreamWriter sw = new StreamWriter("randevular.txt", true))
            {
                sw.WriteLine(veri);
            }
        }
        // Formu temizleme iþlemi
        public void TemizleForm()
        {
            musteriAd.Clear();
            yeniAd.Clear();
            musteriSoyad.Clear();
            yeniSoyad.Clear();
            musteriMail.Clear();
            yeniEmail.Clear();
            musteriTelNo.Clear();
            yeniTelno.Clear();
            comboBox1.SelectedText = string.Empty;
            mevcutrandevuSaatleri.Text = string.Empty;
            comboBox2.Text = string.Empty;
            Personeller.Text = string.Empty;
            Personeller1.Text = string.Empty;
            RandevuTarih.Value = DateTime.Today;
            mevcutrandevuTarihi.Value = DateTime.Today;
            yeniTarih.Value = DateTime.Today;

            foreach (CheckBox checkbox in hizmetCheckBoxes1)
            {
                checkbox.Checked = false;
            }
            foreach (CheckBox checkbox in hizmetCheckBoxes2)
            {
                checkbox.Checked = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
            // CheckBox dizilerini tanýmla ve formdaki checkbox'lara baðla.
            hizmetCheckBoxes1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8 };
            hizmetCheckBoxes2 = new CheckBox[] { checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18 };
            // Tarih formatlarýný ayarla                                                                                                                        
            RandevuTarih.Format = DateTimePickerFormat.Custom;
            RandevuTarih.CustomFormat = "dd/MM/yyyy";

            mevcutrandevuTarihi.Format = DateTimePickerFormat.Custom;
            mevcutrandevuTarihi.CustomFormat = "dd/MM/yyyy";

            yeniTarih.Format = DateTimePickerFormat.Custom;
            yeniTarih.CustomFormat = "dd/MM/yyyy";
            // DataGridView ayarlarýný yap.
            dataGridViewRandevular.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            AyarlaHizmetler();
            HizmetleriGoster();
            YukleRandevular();
            // Her bir hizmet checkbox'ýna CheckedChanged olayý için dinleyici ekle
            foreach (CheckBox checkbox in hizmetCheckBoxes1)
            {
                checkbox.CheckedChanged += HizmetCheckBox_CheckedChanged;
            }

            foreach (CheckBox checkbox in hizmetCheckBoxes2)
            {
                checkbox.CheckedChanged += HizmetCheckBox_CheckedChanged;
            }


        }

        // Hizmet bilgilerini ayarla
        private void AyarlaHizmetler()
        {
            // Her bir hizmet için checkbox'larý ve fiyatlarý ayarla
            AyarlaHizmet(checkBox1, label12, new SacTasarimi());
            AyarlaHizmet(checkBox2, label13, new SacDuzlestirme());
            AyarlaHizmet(checkBox3, label15, new SacBoyama());
            AyarlaHizmet(checkBox4, label16, new KasTasarimi());
            AyarlaHizmet(checkBox5, label17, new Manikur());
            AyarlaHizmet(checkBox6, label18, new Pedikur());
            AyarlaHizmet(checkBox7, label20, new CiltBakimi());
            AyarlaHizmet(checkBox8, label21, new DamatTrasi());
            AyarlaHizmet(checkBox11, label22, new SacTasarimi());
            AyarlaHizmet(checkBox12, label23, new SacDuzlestirme());
            AyarlaHizmet(checkBox13, label24, new SacBoyama());
            AyarlaHizmet(checkBox14, label25, new KasTasarimi());
            AyarlaHizmet(checkBox15, label26, new Manikur());
            AyarlaHizmet(checkBox16, label27, new Pedikur());
            AyarlaHizmet(checkBox17, label28, new CiltBakimi());
            AyarlaHizmet(checkBox18, label29, new DamatTrasi());
        }

        // Bir hizmet için checkbox'ý, fiyatý ve numarasýyla ayarla
        private void AyarlaHizmet(CheckBox checkBox, Label label, Hizmetler hizmet)
        {
            checkBox.Text = hizmet.Ad.ToString();
            label.Text = hizmet.Ucret.ToString();
        }



        // Hizmet checkbox'larýnýn CheckedChanged olay dinleyicisi
        private void HizmetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double toplamFiyat = 0;
            double toplamFiyat1 = 0;
            // Tüm hizmet checkbox'larýný kontrol et ve seçili olanlarýn fiyatýný toplam fiyat olarak hesapla


            if (checkBox1.Checked == true)
            {
                toplamFiyat += 350;
            }
            if (checkBox2.Checked == true)
            {
                toplamFiyat += 250;
            }
            if (checkBox3.Checked == true)
            {
                toplamFiyat += 700;
            }
            if (checkBox4.Checked == true)
            {
                toplamFiyat += 250;
            }
            if (checkBox5.Checked == true)
            {
                toplamFiyat += 300;
            }
            if (checkBox6.Checked == true)
            {
                toplamFiyat += 400;

            }
            if (checkBox7.Checked == true)
            {
                toplamFiyat += 350;
            }
            if (checkBox8.Checked == true)
            {
                toplamFiyat += 1150;
            }

            if (checkBox11.Checked == true)
            {
                toplamFiyat1 += 350;
            }
            if (checkBox12.Checked == true)
            {
                toplamFiyat1 += 250;
            }
            if (checkBox13.Checked == true)
            {
                toplamFiyat1 += 700;
            }
            if (checkBox14.Checked == true)
            {
                toplamFiyat1 += 250;
            }
            if (checkBox15.Checked == true)
            {
                toplamFiyat1 += 300;
            }
            if (checkBox16.Checked == true)
            {
                toplamFiyat1 += 400;

            }
            if (checkBox17.Checked == true)
            {
                toplamFiyat1 += 350;
            }
            if (checkBox18.Checked == true)
            {
                toplamFiyat1 += 1150;
            }



            // Toplam fiyatý toplam textbox'ýna yazdýr
            toplam.Text = toplamFiyat.ToString();
            // Toplam fiyatý toplam textbox'ýna yazdýr
            toplam1.Text = toplamFiyat1.ToString();
        }

        // Randevu görüntüleme iþlemi
        private void ButtonRandevuGoruntule_Click(object sender, EventArgs e)
        {
            string arananTarih = mevcutrandevuTarihi.Text;
            string arananSaat = mevcutrandevuSaatleri.SelectedItem.ToString();

            // Dosyadan randevu bilgilerini oku
            using (StreamReader sr = new StreamReader("randevular.txt"))
            {
                //  MessageBox.Show("1");
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {

                    // Satýrý parçala
                    string[] bilgiler = satir.Split(',');
                    string musteriAdi = bilgiler[0];
                    string musteriSoyadi = bilgiler[1];
                    string musteriTelno = bilgiler[2];
                    string musteriEmail = bilgiler[3];
                    string randevuTarihi = bilgiler[4];
                    string randevuSaati = bilgiler[5];
                    string seciliPersonel = bilgiler[6];
                    string randevuHizmeti = bilgiler[7];

                    // Eþleþen tarih ve saatteki müþteri bilgilerini ekrana yazdýr
                    if (randevuTarihi == arananTarih && randevuSaati == arananSaat)
                    {
                        yeniAd.Text = musteriAdi;
                        yeniSoyad.Text = musteriSoyadi;
                        yeniTelno.Text = musteriTelno;
                        yeniEmail.Text = musteriEmail;
                        comboBox2.Text = randevuSaati;
                        yeniTarih.Text = randevuTarihi;
                        Personeller1.Text = seciliPersonel;

                        // Dosyadan okunan hizmet adlarý
                        string[] secilenHizmetler = randevuHizmeti.Split('/');

                        // CheckBox'larý kontrol ederek iþaretlemeyi gerçekleþtir
                        foreach (CheckBox checkbox in hizmetCheckBoxes2)
                        {
                            // Checkbox'ýn metninden hizmet adýný al
                            string hizmetAdi = checkbox.Text;

                            // Eðer müþterinin seçtiði hizmetler arasýnda bu hizmet adý varsa checkbox'ý iþaretle
                            if (secilenHizmetler.Any(secilenHizmet => secilenHizmet.Trim() == hizmetAdi.Trim()))
                            {
                                checkbox.Checked = true;
                            }
                            else
                            {
                                checkbox.Checked = false;
                            }
                        }


                        break;
                    }
                }
            }
            checkBox11.Enabled = true;
            checkBox12.Enabled = true;
            checkBox13.Enabled = true;
            checkBox14.Enabled = true;
            checkBox15.Enabled = true;
            checkBox16.Enabled = true;
            checkBox17.Enabled = true;
            checkBox18.Enabled = true;
            yeniAd.Enabled = true;
            yeniSoyad.Enabled = true;
            yeniTelno.Enabled = true;
            yeniEmail.Enabled = true;
            yeniTarih.Enabled = true;
            comboBox2.Enabled = true;
            Personeller1.Enabled = true;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            checkBox11.Enabled = false;
            checkBox12.Enabled = false;
            checkBox13.Enabled = false;
            checkBox14.Enabled = false;
            checkBox15.Enabled = false;
            checkBox16.Enabled = false;
            checkBox17.Enabled = false;
            checkBox18.Enabled = false;
            yeniAd.Enabled = false; yeniAd.Clear();
            yeniSoyad.Enabled = false; yeniSoyad.Clear();
            yeniTelno.Enabled = false; yeniTelno.Clear();
            yeniEmail.Enabled = false; yeniEmail.Clear();
            yeniTarih.Enabled = false; yeniTarih.Value = DateTime.Today;
            comboBox2.Enabled = false; comboBox2.Text = string.Empty;
            Personeller1.Enabled = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            TemizleForm();
        }


        private void randevuSil_Click(object sender, EventArgs e)
        {
            RandevuSil();
            MessageBox.Show("Randevu baþarýyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TemizleForm();
            YukleRandevular();
        }
        public void RandevuSil()
        {
            string tarih = mevcutrandevuTarihi.Text;
            string saat = mevcutrandevuSaatleri.SelectedItem.ToString();
            // Silinecek satýrý bulmak için dosyadan randevu bilgilerini oku
            List<string> randevular = new List<string>();
            using (StreamReader sr = new StreamReader("randevular.txt"))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    randevular.Add(satir);
                }
            }

            // Silinecek satýrý bul
            string silinecekSatir = null;
            foreach (string randevu in randevular)
            {

                string[] bilgiler = randevu.Split(',');
                string randevuTarihi = bilgiler[4];
                string randevuSaati = bilgiler[5];

                if (randevuTarihi == tarih && randevuSaati == saat)
                {
                    silinecekSatir = randevu;
                    break;
                }
            }

            // Eðer silinecek bir satýr bulunduysa, satýrý dosyadan sil
            if (silinecekSatir != null)
            {
                randevular.Remove(silinecekSatir);
                // Dosyaya güncellenmiþ randevu bilgilerini yaz
                using (StreamWriter sw = new StreamWriter("randevular.txt"))
                {
                    foreach (string randevu in randevular)
                    {
                        sw.WriteLine(randevu);
                    }
                }

            }
            else
            {
                MessageBox.Show("Belirtilen tarih ve saatte bir randevu bulunamadý.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Randevularý yükleme
        private void YukleRandevular()
        {
            // Önceki verileri temizle
            dataGridViewRandevular.Rows.Clear();

            // Örnek olarak bir dosyadan randevu bilgilerini okuyoruz
            using (StreamReader sr = new StreamReader("randevular.txt"))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    string[] bilgiler = satir.Split(',');
                    string musteriAdi = bilgiler[0];
                    string musteriSoyadi = bilgiler[1];
                    string musteriTelno = bilgiler[2];
                    string musteriEmail = bilgiler[3];
                    string randevuTarihi = bilgiler[4];
                    string randevuSaati = bilgiler[5];
                    string seciliPersonel = bilgiler[6];
                    string randevuHizmeti = bilgiler[7];

                    dataGridViewRandevular.Rows.Add(musteriAdi, musteriSoyadi, musteriTelno, musteriEmail, randevuTarihi, randevuSaati, seciliPersonel, randevuHizmeti);
                    dataGridViewRandevular.Columns["Column7"].ToolTipText = randevuHizmeti;
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tabControl1.Width = this.ClientSize.Width;
            tabControl1.Height = this.ClientSize.Height;
        }

        private void HizmetleriGoster()
        {
            // Hizmet nesnelerini içerecek bir liste oluþturun
            List<Hizmetler> hizmetListesi = new List<Hizmetler>();

            // Hizmet nesnelerini oluþturun
            SacTasarimi sacTasarimi = new SacTasarimi();
            SacDuzlestirme sacDuzlestirme = new SacDuzlestirme();
            SacBoyama sacBoyama = new SacBoyama();
            KasTasarimi kasTasarimi = new KasTasarimi();
            Manikur manikur = new Manikur();
            Pedikur pedikur = new Pedikur();
            CiltBakimi ciltBakimi = new CiltBakimi();
            DamatTrasi damatTrasi = new DamatTrasi();

            // Oluþturulan hizmet nesnelerini hizmetListesi'ne ekleyin
            hizmetListesi.Add(sacTasarimi);
            hizmetListesi.Add(sacDuzlestirme);
            hizmetListesi.Add(sacBoyama);
            hizmetListesi.Add(kasTasarimi);
            hizmetListesi.Add(manikur);
            hizmetListesi.Add(pedikur);
            hizmetListesi.Add(ciltBakimi);
            hizmetListesi.Add(damatTrasi);

            dataGridViewHizmetler.Rows.Clear(); // Önceki verileri temizle
            foreach (Hizmetler hizmet in hizmetListesi) // hizmetListesi, Hizmetler türünden bir liste olmalý
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewHizmetler);
                row.Cells[0].Value = hizmet.Ad;
                row.Cells[1].Value = hizmet.Ucret;
                row.Cells[2].Value = hizmet.Maliyet;
                row.Cells[3].Value = hizmet.Aciklama;
                dataGridViewHizmetler.Rows.Add(row);
            }
        }

    }
}
