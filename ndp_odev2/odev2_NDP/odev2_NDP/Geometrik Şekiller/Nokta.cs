using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_NDP.Geometrik_Şekiller
{
    public class Nokta 
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Nokta()
        {
            x = 0;
            y = 0;
        }
        public Nokta(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
}
