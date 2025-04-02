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
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }


        public static List<Figura> Figuras = new List<Figura>();

        protected Figura(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
            Figuras.Add(this); 
        }

        public abstract void Dibujar(Graphics g);
    }

}

