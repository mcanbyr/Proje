using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_NDP.Geometrik_Şekiller
{
    public class Dikdortgen 
    {
        private Nokta nokta;
        private int en;
        private int boy;

        public Nokta Nokta { get => nokta; set => nokta = value; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }


        public Dikdortgen()
        {

            Nokta = new Nokta();
            En = 0;
            Boy = 0;
        }
        public Dikdortgen(Nokta nokta, int en, int boy)
        {
            Nokta = nokta;
            En = en;
            Boy = boy;
        }
    }
}
