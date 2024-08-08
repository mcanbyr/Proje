using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_NDP.Geometrik_Şekiller
{
    public class DikdortgenPrizma 
    {
        private Nokta3d nokta;
        private int en;
        private int boy;
        private int derinlik;

        public Nokta3d Nokta { get => nokta; set => nokta = value; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }
        public int Derinlik { get => derinlik; set => derinlik = value; }

        public DikdortgenPrizma()
        {
            Nokta = new Nokta3d();
            En = 0;
            Boy = 0;
            Derinlik = 0;
        }
        public DikdortgenPrizma(Nokta3d nokta, int en, int boy, int derinlik)
        {
            Nokta = nokta;
            En = en;
            Boy = boy;
            Derinlik = derinlik;
        }
    }
}
