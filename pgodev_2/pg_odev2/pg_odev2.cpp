/*********************************************************************************************************************************************************
**
**                                                                SAKARYA ÜNİVERSİTESİ
**                                                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                                           BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                                             PROGRAMLAMAYA GİRİŞ DERSİ
**
**
**                                            ÖDEV NUMARASI.........: 2.Ödev
**                                            ÖĞRENCİ ADI...........: Mehmet Can BAYAR
**                                            ÖĞRENCİ NUMARASI......: B231210042
**                                            DERS GRUBU............: B Grubu
**
**
*************************************************************************************************************************************************************/
#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <ctime>

using namespace std;

int gun = 0;
int rastgelegunler[3] = { 0 };   //Rastegele seçtiğimiz günleri dizide tutar.
class Hesap { //Hesap adlı class oluşturma.
private:
public:
    string hesapTuru;
    int hesapId;
    double kriptoAdedi;
    double kriptoKur;
    static int hesapSayac;
    double miktar;
    int gunFarki;
    time_t acilisZamani;

    Hesap() {  // Başlangıç oluşturucusunu atama işlemini yapar.

        hesapTuru = "";
        hesapId = 0;
        miktar = 0.0;
        kriptoAdedi = 0.0;
        kriptoKur = 1.0;
        gunFarki = 0;
    }

    Hesap(const string& tur, double miktar) {  // Yapıcı fonksiyon oluşturur.
        hesapTuru = tur;
        hesapId = ++hesapSayac;
        this->miktar = miktar;
        kriptoAdedi = 0.0;
        kriptoKur = 1.0;
        gunFarki = 0;
        acilisZamani = time(0);
    }

    void kriptoAl(int kriptoAdedi) {   //Kripto alma işlemini yapar.
        if (miktar >= kriptoAdedi * kriptoKur) {
            this->kriptoAdedi += kriptoAdedi;
            miktar -= kriptoAdedi * kriptoKur;
            cout << kriptoAdedi << " kripto alındı.\n";
        }
        else {
            cout << "Yetersiz bakiye!\n";
        }
    }

    void kriptoSat(int kriptoAdedi) {  //Kripto satma işlemini yapar.
        if (this->kriptoAdedi >= kriptoAdedi) {
            this->kriptoAdedi -= kriptoAdedi;
            miktar += kriptoAdedi * kriptoKur;
            cout << kriptoAdedi << " kripto satıldı.\n";
        }
        else {
            cout << "Yetersiz kripto adedi!\n";
        }
    }

    void tlcek(double cekilecekMiktar) { //Tl ekleme işlemini yapar.
        if (miktar >= cekilecekMiktar) {
            miktar -= cekilecekMiktar;
            cout << cekilecekMiktar << " TL çekildi.\n";
        }
        else {
            cout << "Yetersiz bakiye!\n";
        }
    }

    void tlekle(double eklenenMiktar) { //Tl çekme işlemini yapar.
        miktar += eklenenMiktar;
        cout << eklenenMiktar << " TL hesaba eklendi.\n";
    }

    void bakiyeBilgileriniGuncelle() {  //Hesabın içeriğini gösterme işlemini yapar.
        cout << "\n";
        cout << "\n";
        cout << "Hesap Türü:\t" << hesapTuru << endl;
        cout << "Hesap No:\t" << hesapId << endl;
        cout << "Bakiye(TL):\t" << miktar << " TL" << endl;
        cout << "Kripto Adedi:\t" << kriptoAdedi << " birim" << endl;
        cout << "Toplam Kripto Değeri:\t" << kriptoAdedi * kriptoKur << " TL" << endl;
        cout << "1 Kriptonun Değeri:   " << kriptoKur << " TL" << endl;

    }
    void randomgun() {  //Özel hesap için 1 ay içinde rastgele 3 gün seçme işlemini yapar.
        srand(time(NULL));
        for (int i = 0; i < 3; i++) {
            rastgelegunler[i] = rand() % 30 + 1;
        }
    }

    double kriptoKurGuncelle() {   //Kripto kurunu genel ve özel hesap için ayrı ayrı hesaplayarak günceller. 

        if (hesapTuru == "Genel") {
            for (int a = 1; a <= gunFarki; a++) {
                if (a % 15 == 0) {
                    kriptoKur += kriptoKur * 0.01;
                    kriptoKur -= kriptoKur * 0.05;
                }
                else {
                    kriptoKur += kriptoKur * 0.01;
                }
            }
        }
        else {
            for (int a = 1; a <= gunFarki; a++) {
                kriptoKur += kriptoKur * 0.05;
                for (int i = 0; i < 3; i++) {
                    if (rastgelegunler[a] == gun) {  //Hesaplama yapılan tarihin gün kısmı ile rastgele seçilen gün eşitse kripto kurunu %10 düşür.
                        kriptoKur -= kriptoKur * 0.1;
                    }
                }
            }
        }
        return kriptoKur;
    }
};
int Hesap::hesapSayac = 0;

void HesapAc(Hesap hesaplar[], int& hesapSayisi) {  // Hesap açma işlemini yapar , içinde hesap türünü genel ve özel olarak ayrı ayrı tutar. 
    string hesapTuru;
    int secim = 0;
    do {
        cout << "1- Genel Hesap " << endl;
        cout << "2- Özel Hesap " << endl;
        cout << "\nHesap türü seçiniz : ";
        cin >> secim;
        if (secim == 1) {
            hesapTuru = "Genel";
            cout << " \nGenel Hesap Açılıyor.. \n";
        }
        else if (secim == 2) {
            hesapTuru = "Özel";
            cout << " \nÖzel Hesap Açılıyor.. \n";
        }
    } while (secim != 1 and secim != 2);
    cout << "Hesaba yatırılacak başlangıç TL miktarını girin: ";
    cin >> hesaplar->miktar;
    Hesap yeniHesap(hesapTuru, hesaplar->miktar);       //Hesap sınıfında yeniHesap adlı nesne oluşturuur. 
    hesaplar[hesapSayisi] = yeniHesap;                  //yeniHesap adlı nesneyi listelemek amacıyla ; sınıftan hesaplar adlı dizi oluşturulup içine kaydedilir.
    hesapSayisi++;                                      //hesapSayısını 1 arttır çünkü tekrar hesap oluşturulduğunda hesaplar dizisinin bir sonraki elemanına kaydetmesi için.
    cout << "Hesap İD : " << hesapSayisi << endl;
    cout << "Hesap başarıyla açıldı.\n";
    cout << "***********************" << endl;
}

void Listele(Hesap hesaplar[], int hesapSayisi) {  //Açılan hesapları hesaplar dizisi yardımı ile listeleme işlemini yapar.
    cout << "Açılan hesapların listesi:\n";
    for (int i = 0; i < hesapSayisi; i++) {
        hesaplar[i].bakiyeBilgileriniGuncelle();
    }
    cout << "***********************" << endl;
}

void KriptoAl(Hesap hesaplar[], int hesapSayisi) {  // Kripto almak istenilem hesap id sini ve alınacak kripto adedini ister.
    int hesapNo, kriptoAdedi;                       // Sonra kripto alma işlemini yapmak isteiğin id yi hesaplar adlı class dizisinden bularak kriptoAl fonksiyonu ile işlemi gerçekleştirir.
    cout << "İşlem yapılacak hesap numarasını girin: ";
    cin >> hesapNo;
    if (hesapNo > 0 && hesapNo <= hesapSayisi) {
        cout << "Alınacak kripto adedini girin: ";
        cin >> kriptoAdedi;
        hesaplar[hesapNo - 1].kriptoAl(kriptoAdedi);
    }
    else {
        cout << "Geçersiz hesap numarası!\n";
    }
    cout << "***********************" << endl;
}

void KriptoSat(Hesap hesaplar[], int hesapSayisi) {      // Kripto sat istenilem hesap id sini ve alınacak kripto adedini ister.
    int hesapNo, kriptoAdedi;                            // Sonra kripto sat işlemini yapmak isteiğin id yi hesaplar adlı class dizisinden bularak kriptoSat fonksiyonu ile işlemi gerçekleştirir.
    cout << "İşlem yapılacak hesap numarasını girin: ";
    cin >> hesapNo;
    if (hesapNo > 0 && hesapNo <= hesapSayisi) {
        cout << "Satılacak kripto adedini girin: ";
        cin >> kriptoAdedi;
        hesaplar[hesapNo - 1].kriptoSat(kriptoAdedi);
    }
    else {
        cout << "Geçersiz hesap numarası!\n";
    }
    cout << "***********************" << endl;
}

void ParaCek(Hesap hesaplar[], int hesapSayisi) {  // TL çekme işlemini yapmayı istenilem hesabın id sini ve çekilecek TL miktarını ister.
    int hesapNo;                                   // Sonra TL çekme işlemini yapmak isteiğin id yi hesaplar adlı class dizisinden bularak paracek fonksiyonu ile işlemi gerçekleştirir.
    double cekilecekMiktar;
    cout << "İşlem yapılacak hesap numarasını girin: ";
    cin >> hesapNo;
    if (hesapNo > 0 && hesapNo <= hesapSayisi) {
        cout << "Çekilecek TL miktarını girin: ";
        cin >> cekilecekMiktar;
        hesaplar[hesapNo - 1].tlcek(cekilecekMiktar);
    }
    else {
        cout << "Geçersiz hesap numarası!\n";
    }
    cout << "***********************" << endl;
}

void ParaEkle(Hesap hesaplar[], int hesapSayisi) {        // TL ekleme işlemini yapmayı istenilem hesabın id sini ve eklenecek TL miktarını ister.
    int hesapNo;                                          // Sonra TL ekleme işlemini yapmak isteiğin id yi hesaplar adlı class dizisinden bularak paraekle fonksiyonu ile işlemi gerçekleştirir.
    double eklenenMiktar;
    cout << "İşlem yapılacak hesap numarasını girin: ";
    cin >> hesapNo;
    if (hesapNo > 0 && hesapNo <= hesapSayisi) {
        cout << "Eklenecek TL miktarını girin: ";
        cin >> eklenenMiktar;
        hesaplar[hesapNo - 1].tlekle(eklenenMiktar);
    }
    else {
        cout << "Geçersiz hesap numarası!\n";
    }
    cout << "***********************" << endl;
}

int main() {
    setlocale(LC_ALL, "Turkish");     // Ekrana Türkçe karakter girmeyi sağlar.
    Hesap hesaplar[100];              // Hesap sınıfından hesaplar adlı nesne dizisi oluşturur.
    int hesapSayisi = 0;
    int secim;

    srand(time(NULL));
    hesaplar->randomgun();      //Random günleri açılan özel hesap için her ay aynı değeri bulması yani bu işlemi tek sefer yapması amacıyla int mainin altında ilgili fonksiyonu çağırdım.

    time_t rawtime;
    struct tm timeinfo;
    time(&rawtime);
    localtime_s(&timeinfo, &rawtime);

    gun = timeinfo.tm_mday;
    int ay = timeinfo.tm_mon + 1; // tm_mon, Ocak ayını 0 olarak sayar, bu yüzden 1 ekleyerek ayı düzeltiyoruz
    int yil = timeinfo.tm_year + 1900; // Yılın başlangıcı 1900, bu yüzden 1900 ekleyerek yılı düzeltiyoruz

    time_t baslangicTarihi;
    tm baslangicTime = {};
    char nokta;

    do {
        cout << "\n   ~~~~~~ MENÜ ~~~~~~   \n"       // Hesaba dair istenilen işlemleri yapması için menü kısmı tanımlandı.
            "  1. Hesap Aç\n"
            "  2. Hesabına Para Ekle\n"
            "  3. Hesabından Para Çek\n"
            "  4. Kripto Al\n"
            "  5. Kripto Sat\n"
            "  6. Tarih İşlemleri\n"
            "  7. Açılan Tüm Hesapları Listele\n"
            "  0. ÇIKIŞ\n";

        cout << "\nYapmak İstediğiniz İşlemi Seçiniz : ";
        cin >> secim;                                   // Kullanıcıdan menüden yapılacak işlemi seçmesi istenir. 
        cout << endl;
        switch (secim) {
        case 0:
            cout << "ÇIKIŞ YAPILIYOR ...\n"; // Kullanıcı secim işleminde sıfırı seçerse programdan çıkış yapılır.
            return 0;
        case 1:
            HesapAc(hesaplar, hesapSayisi);     // Hesap açmayla ilgili fonksiyonu çağırır.
            break;
        case 2:
            ParaEkle(hesaplar, hesapSayisi);    // Hesaba TL ekleme işleminin yapıldığı ilgili fonksiyonu çağırır.
            break;
        case 3:
            ParaCek(hesaplar, hesapSayisi);     // Hesaptan TL çekme işleminin yapıldığı ilgili fonksiyonu çağırır.
            break;
        case 4:
            KriptoAl(hesaplar, hesapSayisi);    // Kripto alma işleminin yapıldığı ilgili fonksiyonu çağırır.
            break;
        case 5:
            KriptoSat(hesaplar, hesapSayisi);   // Kripto satma işleminin yapıldığı ilgili fonksiyonu çağırır.
            break;
        case 6: {

            cout << "Sistem Tarihi (GG.AA.YYYY) : " << gun << "." << ay << "." << yil << endl;  // Sistem tarihini gösterir.
            cout << "Yeni Sistem Tarihini Giriniz (GG.AA.YYYY) : ";
            cin >> gun >> nokta >> ay >> nokta >> yil;  // Yeni sistem tarihi kullanıcıdan alınır.

            // Başlangıç tarihini oluştur
            baslangicTime.tm_mday = gun + 1;
            baslangicTime.tm_mon = ay - 1; // 0-11 arası olduğu için 1 eksiltiyoruz
            baslangicTime.tm_year = yil - 1900; // Yılın başlangıcı 1900 olduğu için 1900 çıkarıyoruz
            baslangicTarihi = mktime(&baslangicTime); // Başlangıç tarihini time_t türüne çevir

            //Her hesap için gün farkını hesaplayı güncelleme işlemini yapar.
            for (int i = 0; i < hesapSayisi; ++i) {
                hesaplar[i].gunFarki = difftime(baslangicTarihi, hesaplar[i].acilisZamani) / (24 * 3600); // Başlangıç tarihinden hesap tarihine kadar geçen gün sayısı.              
                hesaplar[i].kriptoKurGuncelle();
                hesaplar[i].acilisZamani = baslangicTarihi;
            }
            cout << "**************************************" << endl;
            break;
        }
        case 7:
            Listele(hesaplar, hesapSayisi);     // Açılan hesapları listeleme işleminin yapıldığı ilgili fonksiyonu çağırır.
            break;
        default:
            cout << "Geçersiz Seçim Lütfen Tekrar Deneyiniz.\n";
        }

    } while (secim != 0);

    return 0;
}
