using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Circles
{
    class CCircle
    {
        public int x, y;
        private const int radius = 30;

        public CCircle()
        {

        }

        public CCircle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int get_rad()
        {
            return radius;
        }
    }
}
