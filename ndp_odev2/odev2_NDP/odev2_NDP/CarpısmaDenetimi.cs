/*******************************************************************************************************************
**				                                      	SAKARYA ÜNİVERSİTESİ
**				                                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				                                    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				                                 NESNEYE DAYALI PROGRAMLAMA DERSİ
**					                                    2023-2024 BAHAR DÖNEMİ
**	
**				                                      ÖDEV NUMARASI..........: 2
**				                                      ÖĞRENCİ ADI............: MEHMET CAN BAYAR
**				                                      ÖĞRENCİ NUMARASI.......: B231210042
**                                                    DERSİN ALINDIĞI GRUP...: A
******************************************************************************************************************/
using odev2_NDP.Geometrik_Şekiller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_NDP
{
    public static class carpismadenetimi
    {
        public static bool NoktaDikdortgen(Nokta nokta, Dikdortgen dikdortgen)
        {
            if (nokta.X >= dikdortgen.Nokta.X &&
                nokta.X <= dikdortgen.Nokta.X + dikdortgen.En &&
                nokta.Y >= dikdortgen.Nokta.Y &&
                nokta.Y <= dikdortgen.Nokta.Y + dikdortgen.Boy)

            {
                return true;
            }

            return false;
        }

        public static bool NoktaCember(Nokta nokta, Cember cember)
        {
            if ((nokta.X - cember.Nokta.X) * (nokta.X - cember.Nokta.X) +
                (nokta.Y - cember.Nokta.Y) * (nokta.Y - cember.Nokta.Y) <= cember.Yaricap * cember.Yaricap)
            {
                return true;
            }

            return false;
        }


        public static bool DikdortgenDikdortgen(Dikdortgen dikdortgen1, Dikdortgen dikdortgen2)
        {
            // İlk dikdörtgenin merkezi
            Nokta merkez1 = new Nokta();
            merkez1.X = dikdortgen1.Nokta.X + dikdortgen1.En / 2;
            merkez1.Y = dikdortgen1.Nokta.Y + dikdortgen1.Boy / 2;

            // İkinci dikdörtgenin merkezi
            Nokta merkez2 = new Nokta();
            merkez2.X = dikdortgen2.Nokta.X + dikdortgen2.En / 2;
            merkez2.Y = dikdortgen2.Nokta.Y + dikdortgen2.Boy / 2;

            // Merkez noktaları arasındaki mesafe, her iki dikdörtgenin boy ve en değerlerinin toplamından küçükse,
            // dikdörtgenler çarpışmaktadır.
            if (Math.Abs(merkez1.X - merkez2.X) <= (dikdortgen1.En / 2 + dikdortgen2.En / 2) &&
                Math.Abs(merkez1.Y - merkez2.Y) <= (dikdortgen1.Boy / 2 + dikdortgen2.Boy / 2))
            {
                return true;
            }

            return false;
        }

        public static bool DikdortgenCember(Dikdortgen dikdortgen, Cember cember)
        {
            // Dikdörtgenin sınırları
            int dikdortgenSol = dikdortgen.Nokta.X;
            int dikdortgenSag = dikdortgen.Nokta.X + dikdortgen.En;
            int dikdortgenUst = dikdortgen.Nokta.Y;
            int dikdortgenAlt = dikdortgen.Nokta.Y + dikdortgen.Boy;

            // Çemberin merkezi
            int cemberX = cember.Nokta.X;
            int cemberY = cember.Nokta.Y;

            // Dikdörtgenin içinde mi kontrol et
            if (cemberX >= dikdortgenSol && cemberX <= dikdortgenSag && cemberY >= dikdortgenUst && cemberY <= dikdortgenAlt)
            {
                return true;
            }

            // Dikdörtgenin köşelerinden birine yakın mı kontrol et
            double dx = cemberX - Math.Max(dikdortgenSol, Math.Min(cemberX, dikdortgenSag));
            double dy = cemberY - Math.Max(dikdortgenUst, Math.Min(cemberY, dikdortgenAlt));
            return (dx * dx + dy * dy) <= (cember.Yaricap * cember.Yaricap);
        }

        public static bool CemberCember(Cember cember1, Cember cember2)
        {
            // Çemberlerin merkez noktaları arasındaki uzaklık
            double dx = cember1.Nokta.X - cember2.Nokta.X;
            double dy = cember1.Nokta.Y - cember2.Nokta.Y;

            // Eğer çemberlerin merkez noktaları arasındaki uzaklık, çemberlerin yarıçaplarının toplamından küçük veya eşitse, çarpışma vardır.
            if ((dx * dx + dy * dy) <= ((cember1.Yaricap + cember2.Yaricap) * (cember1.Yaricap + cember2.Yaricap)))
            {
                return true;
            }

            return false;
        }

        public static bool NoktaKure(Nokta3d nokta, Kure kure)
        {
            double mesafe = Math.Sqrt(Math.Pow(nokta.X - kure.Nokta.X, 2) +
                          Math.Pow(nokta.Y - kure.Nokta.Y, 2) +
                          Math.Pow(nokta.Z - kure.Nokta.Z, 2));

            // Eğer noktanın kürenin merkezine olan mesafesi, kürenin yarıçapından küçük veya eşitse, nokta küre içindedir
            // Ayrıca, eşitlik durumunda da çarpışma kontrolü olmalıdır
            if (mesafe <= kure.Yaricap)
            {
                return true;
            }

            return false;
        }

        public static bool NoktaDikdortgenlerPrizma(Nokta3d nokta, DikdortgenPrizma prizma)
        {
            // Dikdörtgenler prizmasının köşe noktalarını hesapla
            double minX = prizma.Nokta.X;
            double maxX = prizma.Nokta.X + prizma.En;
            double minY = prizma.Nokta.Y;
            double maxY = prizma.Nokta.Y + prizma.Boy;
            double minZ = prizma.Nokta.Z;
            double maxZ = prizma.Nokta.Z + prizma.Derinlik;

            // Noktanın dikdörtgenler prizmasının içinde olup olmadığını kontrol et
            if (nokta.X >= minX && nokta.X <= maxX &&
                nokta.Y >= minY && nokta.Y <= maxY &&
                nokta.Z >= minZ && nokta.Z <= maxZ)
            {
                return true;
            }

            return false;

        }

        public static bool NoktaSilindir(Nokta3d nokta, Silindir silindir)
        {
            // Noktanın silindirin merkezine olan uzaklığının karesi
            double uzaklikKare = Math.Pow(nokta.X - silindir.Nokta.X, 2) + Math.Pow(nokta.Y - silindir.Nokta.Y, 2);

            // Eğer noktanın silindirin merkezine olan uzaklığının karesi, silindirin yarıçapının karesinden küçük veya eşitse, nokta silindirin içindedir
            if (uzaklikKare <= Math.Pow(silindir.Yaricap, 2))
            {
                // Noktanın z koordinatı, silindirin yüksekliği aralığında ise, nokta silindirin içindedir
                if (nokta.Z >= silindir.Nokta.Z && nokta.Z <= silindir.Nokta.Z + silindir.Yukseklik)
                {
                    return true; // Çarpışma var
                }
            }

            return false;

        }

        public static bool SilindirSilindir(Silindir silindir1, Silindir silindir2)
        {
            // Eğer silindirlerin merkez noktaları arasındaki uzaklık, silindirlerin yarıçaplarının toplamından küçük veya eşitse ve z konumları çakışıyorsa, çarpışma vardır
            if (silindir1.Nokta.X + 2*silindir1.Yaricap >= silindir2.Nokta.X && silindir1.Nokta.X <= silindir2.Nokta.X + 2*silindir2.Yaricap && silindir1.Nokta.Y + silindir1.Yukseklik >= silindir2.Nokta.Y && silindir1.Nokta.Y <= silindir2.Nokta.Y+silindir2.Yukseklik && silindir1.Nokta.Z + 2*silindir1.Yaricap >=silindir2.Nokta.Z &&silindir1.Nokta.Z <= silindir2.Nokta.Z + 2*silindir2.Yaricap)
            {
                return true;
            }

            return false;
        }

        public static bool KureKure(Kure kure1, Kure kure2)
        {
            // Kürelerin merkez noktaları arasındaki 3D uzaklık
            double dx = kure1.Nokta.X - kure2.Nokta.X;
            double dy = kure1.Nokta.Y - kure2.Nokta.Y;
            double dz = kure1.Nokta.Z - kure2.Nokta.Z;

            // Eğer kürelerin merkez noktaları arasındaki 3D uzaklık, kürelerin yarıçaplarının toplamından küçük veya eşitse, çarpışma vardır
            if ((dx * dx + dy * dy + dz * dz) <= (kure1.Yaricap + kure2.Yaricap) * (kure1.Yaricap + kure2.Yaricap))
            {
                return true;
            }

            return false;
        }

        public static bool KureSilindir(Kure kure, Silindir silindir)
        {
            // Kürenin merkezi ile silindirin merkezi arasındaki 3D uzaklık
            double uzaklik = Math.Sqrt(Math.Pow(kure.Nokta.X - silindir.Nokta.X, 2) +
                                       Math.Pow(kure.Nokta.Y - silindir.Nokta.Y, 2) +
                                       Math.Pow(kure.Nokta.Z - silindir.Nokta.Z, 2));

            // Eğer kürenin merkezi ile silindirin merkezi arasındaki uzaklık, kürenin yarıçapı ile silindirin yarıçapı toplamından küçük veya eşitse ve kürenin z konumu, silindirin yüksekliği aralığında ise, çarpışma vardır
            if (uzaklik <= silindir.Yaricap + kure.Yaricap &&
                kure.Nokta.Z >= silindir.Nokta.Z &&
                kure.Nokta.Z <= silindir.Nokta.Z + silindir.Yukseklik)
            {
                return true;
            }

            return false;
        }

        public static bool KureYuzey(Kure kure, Yuzey yuzey)
        {
            // Yüzeyin bir noktasından kürenin merkezine olan doğrudan uzaklık
            double closestX = Math.Max(yuzey.Nokta.X, Math.Min(kure.Nokta.X, yuzey.Nokta.X + yuzey.En));
            double closestY = Math.Max(yuzey.Nokta.Y, Math.Min(kure.Nokta.Y, yuzey.Nokta.Y + yuzey.Boy));
            double closestZ = Math.Max(yuzey.Nokta.Z, Math.Min(kure.Nokta.Z, yuzey.Nokta.Z + yuzey.Derinlik));

            // Kürenin merkezi ile yüzeyin en yakın noktası arasındaki uzaklık
            double uzaklık = Math.Sqrt(Math.Pow(kure.Nokta.X - closestX, 2) +
                                       Math.Pow(kure.Nokta.Y - closestY, 2) +
                                       Math.Pow(kure.Nokta.Z - closestZ, 2));

            // Eğer bu uzaklık, kürenin yarıçapından küçük veya eşitse, çarpışma var
            if (uzaklık <= kure.Yaricap)
            {
                return true;
            }

            return false;
        }

        public static bool YuzeyDikdortgenlerPrizma(Yuzey yuzey, DikdortgenPrizma prizma)
        {
            if (yuzey.Nokta.Z <= prizma.Derinlik + prizma.Nokta.Z && yuzey.Nokta.Z + yuzey.Derinlik >= prizma.Nokta.Z && yuzey.Nokta.Y <= prizma.Nokta.Y + prizma.Boy && yuzey.Nokta.Y + yuzey.Boy >= prizma.Nokta.Y && yuzey.Nokta.X <= prizma.Nokta.X + prizma.En && yuzey.Nokta.X >= prizma.Nokta.X)
            {
                return true;
            }

            return false;

        }
        public static bool YuzeySilindir(Yuzey yuzey, Silindir silindir)
        {
            // Yüzeyin bir noktasından silindirin merkezine olan doğrudan uzaklık
            double closestX = Math.Max(yuzey.Nokta.X, Math.Min(silindir.Nokta.X, yuzey.Nokta.X + yuzey.En));
            double closestY = Math.Max(yuzey.Nokta.Y, Math.Min(silindir.Nokta.Y, yuzey.Nokta.Y + yuzey.Boy));
            double closestZ = Math.Max(yuzey.Nokta.Z, Math.Min(silindir.Nokta.Z, yuzey.Nokta.Z + yuzey.Derinlik));

            // Silindirin merkezi ile yüzeyin en yakın noktası arasındaki 2D uzaklık
            double uzaklik = Math.Sqrt(Math.Pow(silindir.Nokta.X - closestX, 2) +
                                       Math.Pow(silindir.Nokta.Y - closestY, 2));

            // Eğer bu uzaklık, silindirin yarıçapından küçük veya eşitse ve yüzeyin z konumu, silindirin yüksekliği aralığında ise, çarpışma vardır
            if (uzaklik <= silindir.Yaricap &&
                closestZ >= silindir.Nokta.Z &&
                closestZ <= silindir.Nokta.Z + silindir.Yukseklik)
            {
                return true;
            }

            return false;

        }

        public static bool DikdortgenPrizmaKure(Kure kure,DikdortgenPrizma prizma)
        {
            // Dikdörtgen prizmanın sınırlayıcı kutularının koordinatlarını hesapla
            double prizmaMinX = prizma.Nokta.X;
            double prizmaMaxX = prizma.Nokta.X + prizma.En;
            double prizmaMinY = prizma.Nokta.Y;
            double prizmaMaxY = prizma.Nokta.Y + prizma.Boy;
            double prizmaMinZ = prizma.Nokta.Z;
            double prizmaMaxZ = prizma.Nokta.Z + prizma.Derinlik;

            // Kürenin sınırlayıcı kutusunun koordinatlarını hesapla
            double kureMinX = kure.Nokta.X - kure.Yaricap;
            double kureMaxX = kure.Nokta.X + kure.Yaricap;
            double kureMinY = kure.Nokta.Y - kure.Yaricap;
            double kureMaxY = kure.Nokta.Y + kure.Yaricap;
            double kureMinZ = kure.Nokta.Z - kure.Yaricap;
            double kureMaxZ = kure.Nokta.Z + kure.Yaricap;

            // AABB çarpışma tespiti
            bool carpisirMiX = prizmaMinX <= kureMaxX && prizmaMaxX >= kureMinX;
            bool carpisirMiY = prizmaMinY <= kureMaxY && prizmaMaxY >= kureMinY;
            bool carpisirMiZ = prizmaMinZ <= kureMaxZ && prizmaMaxZ >= kureMinZ;

            // Eğer sınırlayıcı kutular çarpışıyorsa, çarpışma var
            if (carpisirMiX && carpisirMiY && carpisirMiZ)
            {
                return true;
            }

            return false;
        }

        public static bool DikdortgenPrizmaDikdortgenPrizma(DikdortgenPrizma prizma1, DikdortgenPrizma prizma2)
        {
            // İki dikdörtgen prizmanın x, y ve z koordinatları
            int x1 = prizma1.Nokta.X;
            int y1 = prizma1.Nokta.Y;
            int z1 = prizma1.Nokta.Z;
            int x2 = prizma2.Nokta.X;
            int y2 = prizma2.Nokta.Y;
            int z2 = prizma2.Nokta.Z;

            // İki dikdörtgen prizmanın x, y ve z boyutları
            int genislik1 = prizma1.En;
            int boy1 = prizma1.Boy;
            int derinlik1 = prizma1.Derinlik;
            int genislik2 = prizma2.En;
            int boy2 = prizma2.Boy;
            int derinlik2 = prizma2.Derinlik;

            // Çarpışma kontrolü
            if (x1 + genislik1 >= x2 &&
                x1 <= x2 + genislik2 &&
                y1 + boy1 >= y2 &&
                y1 <= y2 + boy2 &&
                z1 + derinlik1 >= z2 &&
                z1 <= z2 + derinlik2)
            {
                // Çarpışma varsa true döndürülür
                return true;
            }


            return false;
        }

    }
}
