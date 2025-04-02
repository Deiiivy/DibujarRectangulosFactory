using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public abstract class Figura
    {
        public static List<Figura> Figuras { get; } = new List<Figura>();

        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }

        public Figura(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public abstract void Dibujar(Graphics g);
    }
}
