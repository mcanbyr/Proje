/*********************************************************************************************************************************************************
**
**                                                                SAKARYA ÜNİVERSİTESİ
**                                                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                                           BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                                             PROGRAMLAMAYA GİRİŞ DERSİ
**
**
**                                            ÖDEV NUMARASI.........: 1.Ödev
**                                            ÖĞRENCİ ADI...........: Mehmet Can BAYAR
**                                            ÖĞRENCİ NUMARASI......: B231210042
**                                            DERS GRUBU............: B Grubu
**
**
*************************************************************************************************************************************************************/
#include <iostream>
#include<iomanip>
#include <string>
#include <cstdlib>
#include <ctime>
#include <cmath>
#include <locale.h>

using namespace std;

struct ogrenci {

    string ogrenciisim;
    string ogrencisoyisim;
    string harfnotu;
    string gecmedurumu;
    float vize;
    float odev1;
    float odev2;
    float kisasinav1;
    float kisasinav2;
    float final;
    float yilicinot;
    float yilsonunot;

};
string isimler[] = { "Ferhat","Selin","Adnan","Yasemin", "Mehmet", " Ceren", "Ramazan", "Rabia", "Serkan", "Fatmagül", "Hakan", "Bilge", "Eren", "Gizem", "Tolga", "Şeyma", "Cem", "Pelin", "Emir", "İpek", "Boran", "Şule", "Can", "Ece","Okan","Buse","Yasin","Huriye Nur","Kaan","Merve","Talha","Umut","Kerim","Azra","Bengü" };
string soyisimler[] = { "Kılıç", "Yaman", "Ersoy", "Taş", "Güler","Sarı" ,"Eser", "Özgür", "Koçak", "Yıldırım", "Şahin", "Kara","Aktaş","Ulusoy","Bektaş","Güdül","Polat","Ertürk" ,"Kurtuluş", "Tosun", "Güzel", "Ceylan", "Kurtuluş", "Çetinkaya", "Alkan", "Tuncer", "Demirci","Demiral","Boz","Karataş","Özden","Semercioğlu","Şen" };
string enyuksekogrenci, endusukogrenci;

int main() {

    setlocale(LC_ALL, "turkish");
    srand(time(0));
    // Sınıf mevcudu bilgisini dışarıdan al.
    int sinifmevcudu = 0;
    do {
        cout << "Lütfen sınıf mevcudunu giriniz \n(En fazla 300 kişi girilebilir) : ";
        cin >> sinifmevcudu;
        cout << endl;
    } while (0 >= sinifmevcudu or sinifmevcudu >= 300);


    float odev1katkisi, odev2katkisi, kisasinav1katkisi, kisasinav2katkisi, vizekatkisi, yilicikatkisi, notlarınortalaması = 0, standartsapma = 0;
    int AAtoplam = 0, BAtoplam = 0, BBtoplam = 0, CBtoplam = 0, CCtoplam = 0, DCtoplam = 0, DDtoplam = 0, FDtoplam = 0, FFtoplam = 0;
    float yilsonulardizisi[300]{};
    cout << "....................................................................................................................";
    cout << endl;
    cout << " HATIRLATMA!!! \nYıl içi puanı; vize, ödevler ve kısa sınavlardan oluşmaktadır.\nYıl sonu puanı , yıl içi puanını ve finali kapsar.\nSınıfı geçme notu 45 olarak hesaplanmıştır. ";
    cout << endl;

    // Vize , ödevler ve kısa sınavların ağırlık bilgilerini kullanıcıdan iste. 
    do {

        cout << "................................................................................................................";
        cout << endl;

        cout << " UYARI! " << endl;
        cout << " Vize, ödevler ve kısa sınavların katkıları toplamı 100 olacak şekilde aşagıdaki bilgileri doldurunuz. ";
        cout << endl;

        cout << "\n1.Ödev notunun katkısını giriniz (%) : ";
        cin >> odev1katkisi;
        cout << endl;

        cout << "2.Ödev notunun katkısını giriniz (%) : ";
        cin >> odev2katkisi;
        cout << endl;

        cout << "1.Kısa sınav notunun katkısını giriniz (%) : ";
        cin >> kisasinav1katkisi;
        cout << endl;

        cout << "2.Kısa sınav notunun katkısını giriniz (%) : ";
        cin >> kisasinav2katkisi;
        cout << endl;

        cout << "Vize notunun katkısını giriniz (%) : ";
        cin >> vizekatkisi;
        cout << endl;
    } while (odev1katkisi + odev2katkisi + kisasinav1katkisi + kisasinav2katkisi + vizekatkisi != 100);

    // Yıl içi puanının ağırlığını kullanıcıdan iste ve final puanının ağırlığını yazdır.
    do {
        cout << "...................................................................................................................." << endl;
        cout << " UYARI! \nYıl içi puanının etkisi (0-100) aralığında olmalıdır. ";
        cout << endl << endl;
        cout << "Yıl içi puanının geçme notuna etkisi (%) : ";
        cin >> yilicikatkisi;
        cout << endl;
        cout << "Final puanının geçme notuna etkisi (%) : " << (100 - yilicikatkisi);
        cout << endl << endl;

    } while (0 >= yilicikatkisi or yilicikatkisi >= 100);

    float toplamnot = 0, enyukseknot = 0, endusuknot = 100;
    int a = 0 /* enyüksekögrenci sırası*/, b = 0 /*endüşükögrenci sırası*/;

    ogrenci ogr;

    for (int i = 0; i < sinifmevcudu; i++) {
        ogr.ogrenciisim = isimler[rand() % 35];
        ogr.ogrencisoyisim = soyisimler[rand() % 35];
        //Öğrencilerin notlarına belirtilen aralıklarda değer atanması. 
        //Fİnal randomu
        if (i < sinifmevcudu * 0.2) {
            ogr.final = rand() % 21 + 80;
        }
        else if (i < sinifmevcudu * 0.7) {
            ogr.final = rand() % 31 + 50;
        }
        else if (i < sinifmevcudu) {
            ogr.final = rand() % 51;
        }
        //Vize randomu
        if (i < sinifmevcudu * 0.2) {
            ogr.vize = rand() % 21 + 80;
        }
        else if (i < sinifmevcudu * 0.5) {
            ogr.vize = rand() % 51;
        }
        else if (i < sinifmevcudu) {
            ogr.vize = rand() % 21 + 80;
        }
        //Ödev 1 randomu
        if (i < sinifmevcudu * 0.2) {
            ogr.odev1 = rand() % 21 + 80;
        }
        else if (i < sinifmevcudu * 0.7) {
            ogr.odev1 = rand() % 31 + 50;
        }
        else if (i < sinifmevcudu) {
            ogr.odev1 = rand() % 51;
        }
        //Ödev 2 randomu
        if (i < sinifmevcudu * 0.2) {
            ogr.odev2 = rand() % 21 + 80;
        }
        else if (i < sinifmevcudu * 0.5) {
            ogr.odev2 = rand() % 51;
        }
        else if (i < sinifmevcudu) {
            ogr.odev2 = rand() % 31 + 50;
        }
        //Kısa sınav 2 randomu 
        if (i < sinifmevcudu * 0.3) {
            ogr.kisasinav2 = rand() % 50;
        }
        else if (i < sinifmevcudu * 0.5) {
            ogr.kisasinav2 = rand() % 21 + 80;
        }
        else if (i < sinifmevcudu) {
            ogr.kisasinav2 = rand() % 31 + 50;
        }
        //Kısa sınav 1 randomu   
        if (i < sinifmevcudu * 0.2) {
            ogr.kisasinav1 = rand() % 21 + 80;
        }
        else if (i < sinifmevcudu * 0.7) {
            ogr.kisasinav1 = rand() % 31 + 50;
        }
        else if (i < sinifmevcudu) {
            ogr.kisasinav1 = rand() % 51;
        }
        //Öğrenci yıl sonu notunun hesaplanması.
        ogr.yilsonunot = (ogr.vize * vizekatkisi + ogr.odev1 * odev1katkisi + ogr.odev2 * odev2katkisi + ogr.kisasinav1 * kisasinav1katkisi + ogr.kisasinav2 * kisasinav2katkisi) * yilicikatkisi / 10000 + (ogr.final * (100 - yilicikatkisi) / 100);

        //STandart sapmada kullanılmak üzere yıl sonu notlarının dizi içine kayıt edilmesi.
        yilsonulardizisi[i] = ogr.yilsonunot;

        //Öğrenci yıl sonu notunun harf notu karşılığının bulunması.
        if (ogr.yilsonunot <= 39.99 and ogr.yilsonunot >= 0)
        {
            ogr.harfnotu = "FF  (Başarısız)";
            FFtoplam++;
        }
        else if (ogr.yilsonunot <= 49.99)
        {
            ogr.harfnotu = "FD  (Başarısız)";
            FDtoplam++;
        }
        else if (ogr.yilsonunot <= 57.99)
        {
            ogr.harfnotu = "DD  (Zayıf)";
            DDtoplam++;
        }
        else if (ogr.yilsonunot <= 64.99)
        {
            ogr.harfnotu = "DC  (Zayıf - Orta)";
            DCtoplam++;
        }
        else if (ogr.yilsonunot <= 74.99)
        {
            ogr.harfnotu = "CC  (Orta)";
            CCtoplam++;
        }
        else if (ogr.yilsonunot <= 79.99)
        {
            ogr.harfnotu = "CB  (Orta - İyi)";
            CBtoplam++;
        }
        else if (ogr.yilsonunot <= 84.99)
        {
            ogr.harfnotu = "BB  (İyi)";
            BBtoplam++;
        }
        else if (ogr.yilsonunot <= 89.99)
        {
            ogr.harfnotu = "BA  (İyi - Pekiyi)";
            BAtoplam++;
        }
        else if (ogr.yilsonunot <= 100.00)
        {
            ogr.harfnotu = "AA  (Pekiyi)";
            AAtoplam++;
        }
        else {}
        //Öğrencinin sınıfı geçme durumu
        if (ogr.yilsonunot <= 45) {
            ogr.gecmedurumu = "KALDI";
        }
        else {
            ogr.gecmedurumu = "GEÇTİ";
        }
        //Sınıfın en yüksek ve en düşük notlarının hesaplanması.    
        if (ogr.yilsonunot > enyukseknot) {
            enyukseknot = ogr.yilsonunot;
            enyuksekogrenci = ". Öğrenci " + ogr.ogrenciisim + " " + ogr.ogrencisoyisim;
            a = (i + 1);
        }
        if (ogr.yilsonunot < endusuknot) {
            endusuknot = ogr.yilsonunot;
            endusukogrenci = ". Öğrenci " + ogr.ogrenciisim + " " + ogr.ogrencisoyisim;
            b = (i + 1);
        }
        // Öğrenci bilgilerini ekrana yazdırma.
        cout << "-----------------------------------------------------------------------------------";
        cout << endl;
        cout << setw(25) << i + 1 << ". ÖĞRENCİNİN BİLGİLERİ";
        cout << endl;
        cout << "Öğrenci Adı : " << ogr.ogrenciisim;
        cout << endl;
        cout << "Öğrenci Soyadı : " << ogr.ogrencisoyisim;
        cout << endl;
        cout << "Öğrencinin yıl sonu notu : " << ogr.yilsonunot;
        cout << endl;
        cout << "Öğrencinin yıl sonu notunun harf karşılığı : " << ogr.harfnotu;
        cout << endl;
        cout << "Öğrencinin sınıfı geçme durumu : " << ogr.gecmedurumu;
        cout << endl;

        //Her öğrencinin yıl sonu norunun toplanması ve sınıfın not ortalamsının hesaplanması.
        toplamnot += ogr.yilsonunot;
        notlarınortalaması = toplamnot / sinifmevcudu;
    }
    //Standart sapma değerinin hesaplanması.
    float formuldepay = 0;
    for (int j = 0; j < sinifmevcudu; j++) {
        formuldepay = formuldepay + (yilsonulardizisi[j] - notlarınortalaması) * (yilsonulardizisi[j] - notlarınortalaması);
    }
    standartsapma = sqrt(formuldepay / (sinifmevcudu - 1));

    // Sınıf bilgilerinin ekrana yazdırılması.
    cout << endl;
    cout << "##########################################################################################";
    cout << endl;
    cout << setw(60) << "SINIF HAKKINDAKİ DİĞER BİLGİLER";
    cout << endl;
    cout << "Sınıf mevcudu : " << sinifmevcudu << endl;
    cout << "Sınıfın en düşük notu : " << b << endusukogrenci << " ( " << endusuknot << " ) " << endl;
    cout << "Sınıfın en yüksek notu : " << a << enyuksekogrenci << " ( " << enyukseknot << " ) " << endl;
    cout << "Sınıfın not ortalaması : " << notlarınortalaması << endl;
    cout << "Sınıfın standart sapma değeri : " << standartsapma << endl << endl;
    cout << "AA harf notunu alan öğrenci sayısı / yüzdelik değeri : " << AAtoplam << " " << "/ % " << 100 * AAtoplam / sinifmevcudu << endl;
    cout << endl << endl;
    cout << "BA harf notunu alan öğrenci sayısı / yüzdelik değeri : " << BAtoplam << " " << "/ % " << 100 * BAtoplam / sinifmevcudu << endl;
    cout << endl << endl;
    cout << "BB harf notunu alan öğrenci sayısı / yüzdelik değeri : " << BBtoplam << " " << "/ % " << 100 * BBtoplam / sinifmevcudu << endl;
    cout << endl << endl;
    cout << "CB harf notunu alan öğrenci sayısı / yüzdelik değeri : " << CBtoplam << " " << "/ % " << 100 * CBtoplam / sinifmevcudu << endl;
    cout << endl << endl;
    cout << "CC harf notunu alan öğrenci sayısı / yüzdelik değeri : " << CCtoplam << " " << "/ % " << 100 * CCtoplam / sinifmevcudu << endl;
    cout << endl << endl;
    cout << "DC harf notunu alan öğrenci sayısı / yüzdelik değeri : " << DCtoplam << " " << "/ % " << 100 * DCtoplam / sinifmevcudu << endl;
    cout << endl << endl;
    cout << "DD harf notunu alan öğrenci sayısı / yüzdelik değeri : " << DDtoplam << " " << "/ % " << 100 * DDtoplam / sinifmevcudu << endl;
    cout << endl << endl;
    cout << "FD harf notunu alan öğrenci sayısı / yüzdelik değeri : " << FDtoplam << " " << "/ % " << 100 * FDtoplam / sinifmevcudu << endl;
    cout << endl << endl;
    cout << "FF harf notunu alan öğrenci sayısı / yüzdelik değeri : " << FFtoplam << " " << "/ % " << 100 * FFtoplam / sinifmevcudu << endl;
    cout << endl << endl;
    cout << "############################################################################################## ";
    cout << endl << endl;
    return 0;

}