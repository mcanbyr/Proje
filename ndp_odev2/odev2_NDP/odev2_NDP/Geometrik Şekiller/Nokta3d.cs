using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_NDP.Geometrik_Şekiller
{
    public class Nokta3d : Nokta
    {
        private Nokta nokta;
        private int z;

        public int Z { get => z; set => z = value; }

        public Nokta3d()
        {
            z = 0;
        }
        public Nokta3d(Nokta nokta, int z)
        {
            X = nokta.X;
            Y = nokta.Y;
            Z = z;
        }
    }
}
