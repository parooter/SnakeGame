using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_gd
{
    internal class Snake
    {
        int x;
        int y;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Snake()
        {
            X = 0;
            Y = 0;
        }

       
    }
}
