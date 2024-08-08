using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_NDP.Geometrik_Şekiller
{
    public class Silindir 
    {
        private Nokta3d nokta;
        private int yaricap;
        private int yukseklik;

        public Nokta3d Nokta { get => nokta; set => nokta = value; }
        public int Yaricap { get => yaricap; set => yaricap = value; }
        public int Yukseklik { get => yukseklik; set => yukseklik = value; }

        public Silindir()
        {

            Nokta = new Nokta3d();
            Yaricap = 0;
            Yukseklik = 0;
        }
        public Silindir(Nokta3d nokta, int yaricap, int yukseklik)
        {
            Nokta = nokta;
            Yaricap = yaricap;
            Yukseklik = yukseklik;
        }
    }
}
