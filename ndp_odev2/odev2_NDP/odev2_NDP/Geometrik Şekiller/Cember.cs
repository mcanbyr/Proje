using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_NDP.Geometrik_Şekiller
{
    
        public class Cember 
    {
            Nokta nokta;
            int yaricap;

            public Nokta Nokta { get => nokta; set => nokta = value; }
            public int Yaricap { get => yaricap; set => yaricap = value; }

            public Cember()
            {
                Nokta = new Nokta();
                yaricap = 0;
            }
            public Cember(Nokta nokta, int yaricap)
            {
                Nokta = nokta;
                Yaricap = yaricap;
            }

        }
    
}
