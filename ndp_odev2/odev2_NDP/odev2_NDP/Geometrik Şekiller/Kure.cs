using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_NDP.Geometrik_Şekiller
{
    public class Kure
    {
        private Nokta3d nokta;
        private int yaricap;

        public Nokta3d Nokta { get => nokta; set => nokta = value; }
        public int Yaricap { get => yaricap; set => yaricap = value; }

        public Kure()
        {
            Nokta = new Nokta3d();
            Yaricap = 0;
        }
        public Kure(Nokta3d nokta, int yaricap)
        {
            Nokta = nokta;
            Yaricap = yaricap;
        }
    }
}
