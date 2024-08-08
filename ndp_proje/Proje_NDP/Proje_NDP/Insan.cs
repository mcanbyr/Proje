
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
    public interface IInsan
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        string Telefon { get; set; }
        string Email { get; set; }
    }

    public class Insan : IInsan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
    }

    public class Personel : Insan
    {
        public string İsPozisyonu { get; set; }
        public Personel(string ad, string soyad, string telefon, string email, string isPozisyonu)
        {
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
            Email = email;
            İsPozisyonu = isPozisyonu;
        }
    }

    public class Musteri : Insan
    {
        public Musteri(string ad, string soyad, string telefon, string email)
        {
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
            Email = email;
        }
    }
}
