using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class Circulo : Figura
    {
        private int radio = 25;

        public Circulo(int x, int y, Color color) : base(x, y, color) { }

        public override void Dibujar(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(Color))
            {
                g.FillEllipse(brush, X - radio, Y - radio, radio * 2, radio * 2);
            }
        }
    }
}

