using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class Point
    {
        public int x;
        public int y;

        //Constructor
        public Point(int xe, int ye){
            x = xe; y = ye;
        }

        public override string ToString() {
            return $"x = {x} , y = {y}";
        }

    }
}
