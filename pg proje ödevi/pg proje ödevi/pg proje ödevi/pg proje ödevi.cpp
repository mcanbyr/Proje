/***************************************************************************************************************************************************************
**
**                                                                SAKARYA ÜNİVERSİTESİ
**                                                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                                           BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                                             PROGRAMLAMAYA GİRİŞ DERSİ                                                                    
**
**                                               ÖDEV NUMARASI.........: PROJE ÖDEVİ
**                                               ÖĞRENCİ ADI...........: MEHMET CAN BAYAR
**                                               ÖĞRENCİ NUMARASI......: B231210042
**                                               DERS GRUBU............: B GRUBU
**
*****************************************************************************************************************************************************************/
#include <iostream>
#include<iomanip>
#include <fstream>
using namespace std;

class Futbolcu {
public:
    long long TC;
    string Adi;
    string Soyadi;
    int lisansNo;
    string konumu;
    long long ucret;
    string dogumTarihi;
    int takimNO;
    int formano;
    int golSayisi = 0;
};
class Takim {
public:
    int TakimNO;
    string Adi;
    string Adresi;
    string Telefon;
    int oyuncuSayisi;
    string yoneticiIsmi;
    int puan = 0;
};
class macskorları {
public:
    int takimNo1;
    int takimNo2;
    int skor1;
    int skor2;
};

Futbolcu futbolcu;
Takim takim;
macskorları macSonucu;

bool takimVarMi(int takimNo) { // Gereken yerde kullanılan takım nonun takim.txt dosyasında olup olmadığını kontrol eder.
    ifstream dosya("takim.txt");
    Takim takim;

    while (dosya >> takim.TakimNO >> takim.Adi >> takim.Adresi >> takim.Telefon >> takim.oyuncuSayisi >> takim.yoneticiIsmi >> takim.puan) {
        if (takim.TakimNO == takimNo) {
            dosya.close();
            return true;  // Kontrol edilen takım takim.txt dosyasında bulundu ise true değerini döndürür.
        }
    }
    dosya.close();
    return false;  // Kontrol edilen takım takim.txt dosyasında bulunamadı ise false değerini döndürür.
}
void takimOlustur() { // Kullanıcıdan takıma dair özellikleri alıp yeni takım oluşturur ardından takim.txt dosyasına yazar.
    takim.puan = 0;
    cout << "Takım Bilgilerini Girin:" << endl;
    cout << "Takım NO: "; cin >> takim.TakimNO;

    if (!(takimVarMi(takim.TakimNO))) { // Kullanıcının girdiği takım nonun daha önceden takim.txt dosyasında olup olmadığını kontrol eder. 
        cout << "Adı: "; cin >> takim.Adi;
        cout << "Adresi: "; cin >> takim.Adresi;
        cout << "Telefon: "; cin >> takim.Telefon;
        cout << "Oyuncu Sayısı: "; cin >> takim.oyuncuSayisi;
        cout << "Yönetici İsmi: "; cin >> takim.yoneticiIsmi;

        ofstream dosya("takim.txt", ios::app); // takim.txt dosyasını açar ve girilen takım bilgileri ile yeni takımı dosyaya ekler.
        dosya << takim.TakimNO << " " << takim.Adi << " " << takim.Adresi << " " << takim.Telefon << " " << takim.oyuncuSayisi << " " << takim.yoneticiIsmi << " " << takim.puan << endl;
        dosya.close(); // Dosya kapatma fonksiyonu.

        cout << "TAKIM OLUŞTURULDU." << endl;
    }
    else {
        cout << "GİRİLEN TAKIM NUMARASI MEVCUT .. " << endl;
    }
}
void takimSil() { // Kullanıcının girdiği takım noyu takim.txt dosyasından siler.
    int silinecekTakimNO;
    cout << "Silinecek Takımın NO'sunu Girin: ";
    cin >> silinecekTakimNO;

    ifstream oku("takim.txt"); // Dosya okuma fonksiyonu.
    ofstream yaz("temp.txt"); // Dosyaya yazma fonksiyonu.

    // takim.txt dosyasını okur ve kullanıcının silmek istediği takım noya eşit olmayan takımlar temp.txt dosyasına geri yazılır.
    while (oku >> takim.TakimNO >> takim.Adi >> takim.Adresi >> takim.Telefon >> takim.oyuncuSayisi >> takim.yoneticiIsmi >> takim.puan) {
        if (takim.TakimNO != silinecekTakimNO) {
            yaz << takim.TakimNO << " " << takim.Adi << " " << takim.Adresi << " " << takim.Telefon << " " << takim.oyuncuSayisi << " " << takim.yoneticiIsmi << " " << takim.puan << endl;
        }
    }
    oku.close(); // Dosya kapatma fonksiyonu.
    yaz.close(); // Dosya kapatma fonksiyonu.

    remove("takim.txt"); //Eski bilgilere sahip takim.txt dosyası silinir.
    rename("temp.txt", "takim.txt"); //Güncel bilgilere sahip olan temp.txt dosyasının ismi takim.txt dosyasına çevrilir.

    ifstream futbolcuOku("futbolcu.txt"); // Dosya okuma fonksiyonu.
    ofstream futbolcuYaz("tempFutbolcu.txt"); // Dosyaya yazma fonksiyonu.

    // futbolcu.txt dosyasını okur, silinecek takim no ile aynı takim no değerine sahip futbolcular hariç diğerlerini tempFutbolcu.txt dosyasına yazar.
    // Yani silinen takmdaki oyuncuları geçici dosyaya yazmaz buda o takımdaki oyuncularıda silmeyi sağlar.
    while (futbolcuOku >> futbolcu.TC >> futbolcu.Adi >> futbolcu.Soyadi >> futbolcu.lisansNo >> futbolcu.konumu >> futbolcu.ucret >> futbolcu.dogumTarihi >> futbolcu.takimNO >> futbolcu.formano >> futbolcu.golSayisi) {
        if (!(futbolcu.takimNO == silinecekTakimNO)) {
            futbolcuYaz << futbolcu.TC << " " << futbolcu.Adi << " " << futbolcu.Soyadi << " " << futbolcu.lisansNo << " " << futbolcu.konumu << " " << futbolcu.ucret << " " << futbolcu.dogumTarihi << " " << futbolcu.takimNO << " " << futbolcu.formano << " " << futbolcu.golSayisi << endl;
        }
    }
    futbolcuOku.close(); // Dosya kapatma fonksiyonu.
    futbolcuYaz.close(); // Dosya kapatma fonksiyonu.

    remove("futbolcu.txt");  //Eski bilgilere sahip futbolcu.txt dosyası silinir.
    rename("tempFutbolcu.txt", "futbolcu.txt");  //Güncel bilgilere sahip olan tempFutbolcu.txt dosyasının ismi futbolcu.txt dosyasına çevrilir.

    cout << "Takım Başarıyla Silindi." << endl;
}
void futbolcuEkle() { // İstenilen takıma istenilen bilgilere sahip futbolcuları ekleme işlemini sağlar.
    do {
        cout << "Hangi takıma eklemek istiyorsunuz? Takım NO: "; cin >> futbolcu.takimNO;
        if (!takimVarMi(futbolcu.takimNO)) { // Dışarıdan alınan takım nonun daha önceden olup olmadığını kontrol eder.
            cout << "Bu takım numarasına sahip bir takım bulunamadı. Lütfen geçerli bir takım numarası girin." << endl;
        }
    } while (!takimVarMi(futbolcu.takimNO)); // Takım numarasını bulamaza while ın içi true döner ve kullanıcıdan tekrar takım no ister.
    // Eklenecek futbolcuların bilgilerini kullanıcıdan alma işlemi yapılıt.
    cout << "Futbolcu Bilgilerini Girin:" << endl;
    cout << "TC: "; cin >> futbolcu.TC;
    cout << "Adı: "; cin >> futbolcu.Adi;
    cout << "Soyadı: "; cin >> futbolcu.Soyadi;
    cout << "Lisans No: "; cin >> futbolcu.lisansNo;
    cout << "Konumu: "; cin >> futbolcu.konumu;
    cout << "Ücret: "; cin >> futbolcu.ucret;
    cout << "Doğum Tarihi: "; cin >> futbolcu.dogumTarihi;
    cout << "Forma NO: "; cin >> futbolcu.formano;

    ofstream futbolcuDosya("futbolcu.txt", ios::app); // Kullanıcıdan alınan futbolcu bilgilerini dosyaya sırasıyla yazar.
    futbolcuDosya << futbolcu.TC << " " << futbolcu.Adi << " " << futbolcu.Soyadi << " " << futbolcu.lisansNo << " " << futbolcu.konumu << " " << futbolcu.ucret << " " << futbolcu.dogumTarihi << " " << futbolcu.takimNO << " " << futbolcu.formano << " " << futbolcu.golSayisi << "\n";
    futbolcuDosya.close(); // Dosya kapatma fonksiyonu.
    cout << "Futbolcu takıma başarıyla eklendi." << endl;
}
void futbolcuSil() {
    long long silinecekTcNO;
    cout << "Silinecek Futbolcunun TC NO'sunu Girin: ";
    cin >> silinecekTcNO; // Silinecek futbolcunun tc si kullanıcıdan alınır.

    ifstream okumaDosyasi("futbolcu.txt"); // Dosya okuma fonksiyonu.
    ofstream tempDosya("temp_futbolcu.txt", ios::app);  // Dosyaya yazma fonksiyonu.

    if (!okumaDosyasi.is_open() || !tempDosya.is_open()) { // Dosyaların açılıp açılmadığını kontrol eder.
        cout << "Dosya açılamadı." << endl;
        return;
    }
    bool futbolcuBulundu = false; // Kullanıcının silmek istediği tc no ile dosyadan eşleşen bir tc no olup olmadığını kontrol etmek için bool değişkeni kullanılır.

    //futbolcu.txt dosyası okunur ve silinecek futbolcunun tc nosuna eşit olmayan futbolcular geçici olan  temp_futbolcu.txt dosyasına yazılır.
    while (okumaDosyasi >> futbolcu.TC >> futbolcu.Adi >> futbolcu.Soyadi >> futbolcu.lisansNo >> futbolcu.konumu >> futbolcu.ucret >> futbolcu.dogumTarihi >> futbolcu.takimNO >> futbolcu.formano >> futbolcu.golSayisi) {
        if (!okumaDosyasi.eof() && futbolcu.TC != silinecekTcNO) {
            tempDosya << futbolcu.TC << " " << futbolcu.Adi << " " << futbolcu.Soyadi << " " << futbolcu.lisansNo << " " << futbolcu.konumu << " " << futbolcu.ucret << " " << futbolcu.dogumTarihi << " " << futbolcu.takimNO << " " << futbolcu.formano << " " << futbolcu.golSayisi << "\n";
        }
        else if (futbolcu.TC == silinecekTcNO) {
            futbolcuBulundu = true; // Silinecek futbolcuya ait tc no futbolcu.txt dosyasında bulunursa bool true olur.
        }
    }
    okumaDosyasi.close();// Dosya kapatma fonksiyonu.
    tempDosya.close(); // Dosya kapatma fonksiyonu.

    remove("futbolcu.txt"); //Eski bilgilere sahip futbolcu.txt dosyası silinir.
    rename("temp_futbolcu.txt", "futbolcu.txt"); // Güncel bilgilere sahip olan temp_futbolcu.txt dosyasının ismi futbolcu.txt dosyasına çevrilir.

    if (futbolcuBulundu) { // bool türünde olan değişken true olduğunda futbolcu silindi yazısını yazdırır.
        cout << "Futbolcu silindi." << endl;
    }
    else {
        cout << "Silinecek futbolcu bulunamadı." << endl; // bool türünde olan değişken false olduğunda futbolcunun bulunamadığını belirten yazı ekrana yazdırılır.
    }
}
string takimadibul(int takimno) { // İstediğin takkım numarasının hangi takım adına karşılık geldiğini bulmayı sağlar.
    ifstream oku("takim.txt");
    while (oku >> takim.TakimNO >> takim.Adi >> takim.Adresi >> takim.Telefon >> takim.oyuncuSayisi >> takim.yoneticiIsmi >> takim.puan) {
        if (takim.TakimNO == takimno) { // Aranan takım noya ait takim.txt dosyasında takım bulursa o takımın adını dödürür.
            oku.close();
            return takim.Adi;
        }
    }
    oku.close();
    return "Takım Adı Bulunamadı";
}
void futbolculariListele() { // Kullanıcıdan listelenecek takım no yu alır ve o takımdaki oyuncuları listeler.
    int istenentakimno;
    cout << "Listelenecek takımın NO'sunu girin: ";
    cin >> istenentakimno;

    ifstream dosya("futbolcu.txt");

    if (!dosya.is_open()) {
        cout << "Futbolcu Dosyasi açılamadı." << endl;
        return;
    }

    bool futbolcuVar = false;
    while (dosya >> futbolcu.TC >> futbolcu.Adi >> futbolcu.Soyadi >> futbolcu.lisansNo >> futbolcu.konumu >> futbolcu.ucret >> futbolcu.dogumTarihi >> futbolcu.takimNO >> futbolcu.formano >> futbolcu.golSayisi) {
        if (futbolcu.takimNO == istenentakimno) {  //futbolcu.txt dosyasını okur istenen takim no ya sahip oyuncuların bilgilerini ekrana yazdırır.
            cout << "TC: " << futbolcu.TC << endl;
            cout << "Adı: " << futbolcu.Adi << endl;
            cout << "Soyadı: " << futbolcu.Soyadi << endl;
            cout << "Lisans No: " << futbolcu.lisansNo << endl;
            cout << "Konumu: " << futbolcu.konumu << endl;
            cout << "Ücret: " << futbolcu.ucret << endl;
            cout << "Doğum Tarihi: " << futbolcu.dogumTarihi << endl;
            cout << "Futbolcu Takım No: " << futbolcu.takimNO << endl;
            cout << "Takım Adı: " << takimadibul(futbolcu.takimNO) << endl;
            cout << "Futbolcu Forma No: " << futbolcu.formano << endl;
            cout << " --------------------------------------------------------" << endl;
            futbolcuVar = true; // bool değişkeni true döner çünkü if e girebildi. 
        }
    }
    dosya.close();

    if (!futbolcuVar) { // bool değişkeni false olursa burdaki if bloğuna girer ve gerkli bilgiyi kullanıcıya verir.
        cout << "Belirtilen takım numarasına ait futbolcu bulunamadı." << endl;
    }
}
void futbolcuGuncelle() { // Kullanıcıdan istenilen lisans numarasına sahip oyuncunun bilgilerini güncellemeyi sağlayan fonksiyon.
    int istenenlisansno;
    cout << "Güncellenecek Futbolcunun Lisans NO'sunu girin: ";
    cin >> istenenlisansno;

    ifstream okumaDosyasi("futbolcu.txt");
    ofstream tempDosya("temp_futbolcu.txt", ios::app);

    if (!okumaDosyasi.is_open() || !tempDosya.is_open()) {
        cout << "Dosya açılamadı." << endl;
        return;
    }
    bool futbolcuBulundu = false;
    // futbolcu.txt dosyasını okur ve güncellenecek futbolcunun lisans numarasına eşit olmayan futbolcuları gecici dosyaya yazar / eşit olan futbolcu için yeni bilgilerini alır ve o bilgileri dahil ederek dosyayı düzenler.
    while (okumaDosyasi >> futbolcu.TC >> futbolcu.Adi >> futbolcu.Soyadi >> futbolcu.lisansNo >> futbolcu.konumu >> futbolcu.ucret >> futbolcu.dogumTarihi >> futbolcu.takimNO >> futbolcu.formano >> futbolcu.golSayisi) {
        if (!okumaDosyasi.eof() && futbolcu.lisansNo != istenenlisansno) {
            tempDosya << futbolcu.TC << " " << futbolcu.Adi << " " << futbolcu.Soyadi << " " << futbolcu.lisansNo << " " << futbolcu.konumu << " " << futbolcu.ucret << " " << futbolcu.dogumTarihi << " " << futbolcu.takimNO << " " << futbolcu.formano << " " << futbolcu.golSayisi << "\n";
        }
        else if (futbolcu.lisansNo == istenenlisansno) {
            futbolcuBulundu = true;
            cout << "Yeni TC: "; cin >> futbolcu.TC;
            cout << "Yeni Adı: "; cin >> futbolcu.Adi;
            cout << "Yeni Soyadı: "; cin >> futbolcu.Soyadi;
            cout << "Yeni Konumu: "; cin >> futbolcu.konumu;
            cout << "Yeni Ücret: "; cin >> futbolcu.ucret;
            cout << "Yeni Doğum Tarihi: "; cin >> futbolcu.dogumTarihi;
            cout << "Yeni Forma No: "; cin >> futbolcu.formano;
            tempDosya << futbolcu.TC << " " << futbolcu.Adi << " " << futbolcu.Soyadi << " " << futbolcu.lisansNo << " " << futbolcu.konumu << " " << futbolcu.ucret << " " << futbolcu.dogumTarihi << " " << futbolcu.takimNO << " " << futbolcu.formano << " " << futbolcu.golSayisi << "\n";
        }
    }
    okumaDosyasi.close();
    tempDosya.close();
    remove("futbolcu.txt");                        // Eski dosyayı siler
    rename("temp_futbolcu.txt", "futbolcu.txt");   // Gecici dosyanın adını futbolcu.txt yapar
    // bool değişkeni true veya false dönerse gerekli bilgilendirici mesajları ekrana yazar. 
    if (futbolcuBulundu) {
        cout << "Futbolcu Bilgileri Güncellendi." << endl;
    }
    else {
        cout << "Güncellenecek Futbolcu Bulunamadı." << endl;
    }
}
void puanlariGuncelle(int takimNo, int puan) { // İstenen takım numarasına sahip takımın puanını güncellemeyi sağlar.
    ifstream dosyaOku("takim.txt");
    ofstream tempDosyaYaz("temp_takim.txt");

    if (!dosyaOku.is_open() || !tempDosyaYaz.is_open()) {
        cout << "Dosya açılamadı." << endl;
        return;
    }
    // Dosyadan okuyarak istenen takım numarasına sahip takımı bul ve puanını güncelle
    while (dosyaOku >> takim.TakimNO >> takim.Adi >> takim.Adresi >> takim.Telefon >> takim.oyuncuSayisi >> takim.yoneticiIsmi >> takim.puan) {
        if (takim.TakimNO == takimNo) {
            takim.puan += puan;
        }
        tempDosyaYaz << takim.TakimNO << " " << takim.Adi << " " << takim.Adresi << " " << takim.Telefon << " " << takim.oyuncuSayisi << " " << takim.yoneticiIsmi << " " << takim.puan << endl;
    }
    dosyaOku.close();
    tempDosyaYaz.close();
    remove("takim.txt");
    rename("temp_takim.txt", "takim.txt");
}
void golTakip(int formano, int golSayisi, int notakim) { // forma no , gol sayısı ve takım numaraları belli olan bilgilere sahip oyuncunun gol sayısı bilgisini günceller.
    ifstream okumaDosyasi("futbolcu.txt");
    ofstream yazmaDosyasi("goltakip.txt", ios::app);

    if (!okumaDosyasi.is_open() || !yazmaDosyasi.is_open()) {
        cout << "Dosya açılamadı." << endl;
        return;
    }
    bool futbolcuBulundu = false;
    // futbolcu.txt dosyasını okur ve dosyada forma no ve takım nosu istenenlerle uyumlu olan futbolcunun gol sayısı bilgisini günceller.
    while (okumaDosyasi >> futbolcu.TC >> futbolcu.Adi >> futbolcu.Soyadi >> futbolcu.lisansNo >> futbolcu.konumu >> futbolcu.ucret >> futbolcu.dogumTarihi >> futbolcu.takimNO >> futbolcu.formano >> futbolcu.golSayisi) {
        if (futbolcu.formano == formano and futbolcu.takimNO == notakim) {
            futbolcuBulundu = true;
            futbolcu.golSayisi += golSayisi;
        }
        //forma no ve takım nosu uyuşmayan oyuncunun bilgilerini değiştirmeden yazdırır.
        yazmaDosyasi << futbolcu.TC << " " << futbolcu.Adi << " " << futbolcu.Soyadi << " "
            << futbolcu.lisansNo << " " << futbolcu.konumu << " " << futbolcu.ucret << " "
            << futbolcu.dogumTarihi << " " << futbolcu.takimNO << " " << futbolcu.formano << " " << futbolcu.golSayisi << "\n";
    }
    okumaDosyasi.close();
    yazmaDosyasi.close();
    remove("futbolcu.txt");
    rename("goltakip.txt", "futbolcu.txt");
    // bool değişkeni true veya false dönerse gerekli bilgilendirici mesajları ekrana yazar.
    if (!futbolcuBulundu) {
        cout << "Gol Atan Futbolcu Bulunamadı." << endl;
    }
}
void macKaydiYap() { // Kulannıcıdan maç yapan takımların takım numarasını ve maç skorlarını alır macsonucları.txt dosyasına yazdırır ardından skorları karşılaştırarak puanları belirler.
    int evSahibiTakimNo, deplasmanTakimNo;
    int evSahibiSkor, deplasmanSkor;

    do {// Maç yapcak takımların daha önceden oluşturulup oluşturulmadığını kontrol eder.
        cout << "Ev Sahibi Takım NO: "; cin >> evSahibiTakimNo;
        cout << "Deplasman Takım NO: "; cin >> deplasmanTakimNo;
        if (!takimVarMi(evSahibiTakimNo) or !takimVarMi(deplasmanTakimNo)) {
            cout << endl << "Girilen Takım Numarasına Ait Takım Bulunamadı." << endl << endl;
        }
    } while (!takimVarMi(evSahibiTakimNo) or !takimVarMi(deplasmanTakimNo)) ;
    cout << "Ev Sahibi Skor: "; cin >> evSahibiSkor;
    cout << "Deplasman Skor: "; cin >> deplasmanSkor;

    // Maç sonuçları dosyasına yaz
    ofstream macDosya("macsonucları.txt", ios::app);
    if (!macDosya.is_open()) {
        cout << "Maç sonuçları dosyası açılamadı." << endl;
        return;
    }
    macDosya << evSahibiTakimNo << " " << deplasmanTakimNo << " " << evSahibiSkor << " " << deplasmanSkor << endl;
    macDosya.close();

    int evSahibiPuan = 0, deplasmanPuan = 0;
    if (evSahibiSkor > deplasmanSkor) {
        evSahibiPuan = 3; // Ev sahibi galip
    }
    else if (evSahibiSkor == deplasmanSkor) {
        evSahibiPuan = 1; // Berabere
    }

    if (deplasmanSkor > evSahibiSkor) {
        deplasmanPuan = 3; // Deplasman galip
    }
    else if (deplasmanSkor == evSahibiSkor) {
        deplasmanPuan = 1; // Berabere
    }
    // Puanlar belirlendikten sonra gerekli fonksiyon ile takımın puan bilgisi güncellenir.
    puanlariGuncelle(evSahibiTakimNo, evSahibiPuan);
    puanlariGuncelle(deplasmanTakimNo, deplasmanPuan);

    cout << endl << "GOL ATAN FUTBOLCULAR : " << endl;
    // Gol atan futbolcunun takım no bilgisi alınır / Girilen değerin maç yapan takımlar arasında olup olmadığı kontrol edilir. 
    int toplam = 0;
    do {
        int formaNo, golSayisi, notakim = 0;
        do {
            cout << "Gol Atan Futbolcunun Takım Numarasını Girin: ";
            cin >> notakim;

            if (!(notakim == evSahibiTakimNo or notakim == deplasmanTakimNo))
                cout << "Girilen Takım Numarısı Maçta Bulunmuyor..." << endl;
        } while (!(notakim == evSahibiTakimNo or notakim == deplasmanTakimNo));
        // Gol atan futbolcunun forma bilgisi alınır
        cout << "Gol Atan Futbolcunun Forma Numarasını Giriniz: ";
        cin >> formaNo;
        cout << "Kaç Gol Attığını Girin: ";
        cin >> golSayisi;
        cout << endl;
        golTakip(formaNo, golSayisi, notakim);
        toplam += golSayisi;

    } while (toplam != (evSahibiSkor + deplasmanSkor));
    cout << endl << "Toplam Gol Sayısına Ulaşıldı..." << endl;
    cout << "Maç Sonuçları , Puanlar ve Gol Takip İşlemleri Kaydedildi." << endl << endl;
}
void puanlariListeleSiralama() { // takim.txt dosyasındaki takımların puanlarını diziye atar ve sıralama işlemi yapıp ekrana büyükten küçüğe doğru sıralar.
    Takim takimlar[20];
    ifstream dosya("takim.txt");

    if (!dosya.is_open()) {
        cout << "Takim dosyasi açılamadı." << endl;
        return;
    }
    int takimSayisi = 0;
    // Takım bilgilerini okur ve bilgileri dizide saklar
    while (dosya >> takimlar[takimSayisi].TakimNO >> takimlar[takimSayisi].Adi >> takimlar[takimSayisi].Adresi >> takimlar[takimSayisi].Telefon >> takimlar[takimSayisi].oyuncuSayisi >> takimlar[takimSayisi].yoneticiIsmi >> takimlar[takimSayisi].puan && takimSayisi < 20) {
        takimSayisi++;
    }
    dosya.close();
    // Dizideki takımın puanlarını tutan elemanları kıyaslayarak sıralma yapar ve büyükten küçüğe doğru sıralanacak şekilde  dizide saklar.
    for (int i = 0; i < takimSayisi - 1; ++i) {
        int enfazla = i;
        for (int j = i + 1; j < takimSayisi; ++j) {
            if (takimlar[j].puan > takimlar[enfazla].puan) {
                enfazla = j;
            }
        }
        Takim temp = takimlar[i];
        takimlar[i] = takimlar[enfazla];
        takimlar[enfazla] = temp;
    }
    // Sıralanmış takımları ekrana yazdır
    for (int i = 0; i < takimSayisi; ++i) {
        cout << "Takım Adı: " << takimlar[i].Adi << "\nTakım NO: " << takimlar[i].TakimNO << "\nPuan: " << takimlar[i].puan << "\n";
        cout << "------------------------\n";
    }
}
void macSkorlariniListele() { // Girilen maçlarda oynuyan takım adlarını ve skorlarını yazdırır.
    ifstream takimDosya("takim.txt");
    ifstream macDosya("macsonucları.txt");

    if (!takimDosya.is_open() || !macDosya.is_open()) {
        cout << "Dosyalar açılamadı." << endl;
        return;
    }
    Takim takimlar[20];
    int takimSayisi = 0;
    // Takım bilgilerini oku ve dizide sakla
    while (takimDosya >> takimlar[takimSayisi].TakimNO >> takimlar[takimSayisi].Adi >> takimlar[takimSayisi].Adresi >> takimlar[takimSayisi].Telefon >> takimlar[takimSayisi].oyuncuSayisi >> takimlar[takimSayisi].yoneticiIsmi >> takimlar[takimSayisi].puan && takimSayisi < 20) {
        takimSayisi++;
    }
    takimDosya.close();

    cout << "************** Maç Skorları **************" << endl;
    // macskorları.txt dosyasını okur ve dizi sayesinde takım adı ile birlikte mac skorlarını listeleme işlemini yapar.
    while (macDosya >> macSonucu.takimNo1 >> macSonucu.takimNo2 >> macSonucu.skor1 >> macSonucu.skor2) {
        string evSahibiAdi = "takimadi";
        string deplasmanAdi = "takimadi";

        for (int i = 0; i < takimSayisi; ++i) {
            if (takimlar[i].TakimNO == macSonucu.takimNo1) {
                evSahibiAdi = takimlar[i].Adi;
            }
            if (takimlar[i].TakimNO == macSonucu.takimNo2) {
                deplasmanAdi = takimlar[i].Adi;
            }
        }
        cout << setw(14) << right << evSahibiAdi << setw(3) << macSonucu.skor1 << " - " << macSonucu.skor2 << "  " << setw(20) << left << deplasmanAdi << endl;
    }
    macDosya.close();
    cout << endl;
}
void ListeleGolTakip() {
    ifstream goltakipDosya("futbolcu.txt");
    if (!goltakipDosya.is_open()) {
        cout << "Goltakip dosyasi açılamadı." << endl;
        return;
    }
    cout << "********** Gol Takip **********" << endl;
    // futbolcu.txt dosyasını okur ve gol sayısı 0 olmayan futbolcuları yani gol atan futbolcuları ekrana yazdırmyaı sağlar.
    while (goltakipDosya >> futbolcu.TC >> futbolcu.Adi >> futbolcu.Soyadi >> futbolcu.lisansNo >> futbolcu.konumu >> futbolcu.ucret >> futbolcu.dogumTarihi >> futbolcu.takimNO >> futbolcu.formano >> futbolcu.golSayisi) {
        if (futbolcu.golSayisi != 0) {
            cout << "Forma No: " << futbolcu.formano << endl;
            cout << "Adı: " << futbolcu.Adi << endl;
            cout << "Soyadı: " << futbolcu.Soyadi << endl;
            cout << "Takım NO: " << futbolcu.takimNO << endl;
            cout << "Takım Adı: " << takimadibul(futbolcu.takimNO) << endl;
            cout << "Toplam Gol Sayısı: " << futbolcu.golSayisi << endl;
            cout << "------------------------" << endl;
        }
    }
    goltakipDosya.close();
}
void ligiSifirla() {
    // Takım puanlarını ve futbolcu gol bilgilerini sıfırla
    ofstream takimDosya("gecicitakim.txt");
    ifstream takimOku("takim.txt");
    // takim.txt dosyasını okur ve takım puanını sıfırlar.
    while (takimOku >> takim.TakimNO >> takim.Adi >> takim.Adresi >> takim.Telefon >> takim.oyuncuSayisi >> takim.yoneticiIsmi >> takim.puan) {
        takim.puan = 0;
        takimDosya << takim.TakimNO << " " << takim.Adi << " " << takim.Adresi << " " << takim.Telefon << " " << takim.oyuncuSayisi << " " << takim.yoneticiIsmi << " " << takim.puan << endl;
    }
    takimOku.close();
    takimDosya.close();

    remove("takim.txt");
    rename("gecicitakim.txt", "takim.txt");

    ifstream futbolcuOku("futbolcu.txt");
    ofstream futbolcuYaz("tempFutbolcu.txt");
    // futbolcu.txt dosyasını okur ve futbolcunun gol sayısı bilgisini sıfırlar.
    while (futbolcuOku >> futbolcu.TC >> futbolcu.Adi >> futbolcu.Soyadi >> futbolcu.lisansNo >> futbolcu.konumu >> futbolcu.ucret >> futbolcu.dogumTarihi >> futbolcu.takimNO >> futbolcu.formano >> futbolcu.golSayisi) {
        futbolcu.golSayisi = 0;
        futbolcuYaz << futbolcu.TC << " " << futbolcu.Adi << " " << futbolcu.Soyadi << " " << futbolcu.lisansNo << " " << futbolcu.konumu << " " << futbolcu.ucret << " " << futbolcu.dogumTarihi << " " << futbolcu.takimNO << " " << futbolcu.formano << " " << futbolcu.golSayisi << endl;
    }
    futbolcuOku.close();
    futbolcuYaz.close();

    remove("futbolcu.txt");
    rename("tempFutbolcu.txt", "futbolcu.txt");
    remove("macsonucları.txt");
    cout << "Lig Başarıyla Sıfırlandı." << endl;
}
int main() {
    setlocale(LC_ALL, "Turkish");
    int secim;

    do {
        cout << endl << "#####  Futbol Takip Sistemi  ##### " << endl;
        cout << " -1- Takım Oluştur " << endl;
        cout << " -2- Takım Sil " << endl;
        cout << " -3- Takıma Futbolcu Ekle " << endl;
        cout << " -4- Takımdan Futbolcu Sil " << endl;
        cout << " -5- Takımdaki Futbolcuları Listeleme " << endl;
        cout << " -6- Takımdaki Bir Futbolcuyu Güncelleme " << endl;
        cout << " -7- Ligi Başlat ve Maç Kaydı Al " << endl;
        cout << " -8- Maç Skorlarını Listele " << endl;
        cout << " -9- Takımların Puanlarını Listele " << endl;
        cout << "-10- Lig Boyunca Gol Atan Oyuncuları Listele " << endl;
        cout << "-11- Ligi Sıfırla (Maç Sonuçları - Takım Puanları - Futbolcu Gol Sayıları) " << endl;
        cout << " -0- Programı Kapat " << endl;
        cout << "Seçim: ";
        cin >> secim;

        switch (secim) {
        case 1:
            takimOlustur();
            break;
        case 2:
            takimSil();
            break;
        case 3:
            futbolcuEkle();
            break;
        case 4:
            futbolcuSil();
            break;
        case 5:
            futbolculariListele();
            break;
        case 6:
            futbolcuGuncelle();
            break;
        case 7:
            macKaydiYap();
            break;
        case 8:
            macSkorlariniListele();
            break;
        case 9:
            puanlariListeleSiralama();
            break;
        case 10:
            ListeleGolTakip();
            break;
        case 11:
            ligiSifirla();
            break;
        case 0:
            cout << "PROGRAMDAN ÇIKIŞ YAPILIYOR" << endl;
            break;
        default:
            cout << "Geçersiz seçenek. Tekrar deneyin." << endl;
        }
    } while (secim != 0);
    return 0;
}
