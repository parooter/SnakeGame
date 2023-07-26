using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace snake_gd
{
    class SnakeColor
    {
        public string Text { get; }
        public Color Color { get; }
        
        public SnakeColor(string text, Color color)
        {
            Text = text;
            Color = color;   
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
