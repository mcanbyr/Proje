
/****************************************************************************************************************************************
**				                                      	SAKARYA ÜNİVERSİTESİ
**				                                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				                                    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				                                   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					                                   2023-2024 BAHAR DÖNEMİ
**                                                          PROJE ÖDEVİ
**	
**				                                   ÖDEV NUMARASI..........: Proje Ödevi
**				                                   ÖĞRENCİ ADI............: MEHMET CAN BAYAR
**				                                   ÖĞRENCİ NUMARASI.......: B231210042
**                                                 DERSİN ALINDIĞI GRUP...: A Grubu 1.Öğretim
****************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_NDP
{
    public interface IHizmet
    {
        string Ad { get; }
        string Ucret { get; }
        string Aciklama { get; }
    }

    public abstract class Hizmetler : IHizmet
    {
        public abstract string Ad { get; }
        public abstract string Ucret { get; }
        public abstract int Maliyet { get; }
        public abstract string Aciklama { get; }
    }

    public class SacTasarimi : Hizmetler
    {
        public override string Ad => "SAÇ TASARIMI - ";
        public override string Ucret => "350 TL";
        public override int Maliyet => 150;
        public override string Aciklama => "Size özel kafa ve yüz şeklinize göre Anatomik Saç ve Sakal kesimi yapmaktayız.";
    }

    public class SacDuzlestirme : Hizmetler
    {
        public override string Ad => "SAÇ DÜZLEŞTİRME - ";
        public override string Ucret => "250 TL";
        public override int Maliyet => 100;
        public override string Aciklama => "Silindir Saç Düzleştirme kremimizle saçlarınızı yıpratmadan, kontrollü bir şekilde 2-6 ay arası kalıcı düzleştiriyoruz.";
    }

    public class SacBoyama : Hizmetler
    {
        public override string Ad => "SAÇ BOYAMA - ";
        public override string Ucret => "700 TL";
        public override int Maliyet => 300;
        public override string Aciklama => "Saç Boyama ile istediğiniz renkteki boyayı saçınıza özenli bir şekilde entegre ediyoruz.";
    }
    public class KasTasarimi : Hizmetler
    {
        public override string Ad => "KAŞ TASARIMI - ";
        public override string Ucret => "250 TL";
        public override int Maliyet => 100;
        public override string Aciklama => "Kaşlarınızın bakımlı ve güzel olması bakışlarınızı daha iyi ifade etmenizi sağlayacaktır. Bunu önemseyerek tasarım yapıyoruz.";
    }

    public class Manikur : Hizmetler
    {
        public override string Ad => "MANİKÜR - ";
        public override string Ucret => "300 TL";
        public override int Maliyet => 150;
        public override string Aciklama => "Dokunduğunuzda hissedebilebilecek, estetik bir görünüme sahip el ve tırnak bakımı sağlıyoruz.";
    }

    public class Pedikur : Hizmetler
    {
        public override string Ad => "PEDİKÜR - ";
        public override string Ucret => "400 TL";
        public override int Maliyet => 150;
        public override string Aciklama => "Vücudumuzun tüm yükünü çeken ayaklar her zaman doğru bakımı hak etmektedir. Ayak ve tırnak bakımınızı önemseyip gerekli bakımları özenle yapıyoruz.";
    }

    public class CiltBakimi : Hizmetler
    {
        public override string Ad => "CİLT BAKIMI - ";
        public override string Ucret => "350 TL";
        public override int Maliyet => 150;
        public override string Aciklama => "Cildinizdeki ölü deriyi ve yağı temizleyip siyah nokta oluşumunu azaltıyoruz.";
    }

    public class DamatTrasi : Hizmetler
    {
        public override string Ad => "DAMAT TRAŞI - ";
        public override string Ucret => "1150 TL";
        public override int Maliyet => 450;
        public override string Aciklama => "Hayatınızın en özel gününde, düğününüze gelecek misafirlerinizin önüne sizi ifade edebilecek bir saçla çıkmanın önemini vurguluyoruz.";
    }
}
