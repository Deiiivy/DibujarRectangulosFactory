using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class Triangulo : Figura
    {
        private int lado = 50;

        public Triangulo(int x, int y, Color color) : base(x, y, color) { }

        public override void Dibujar(Graphics g)
        {
            Point[] puntos =
            {
                new Point(X, Y - lado / 2),
                new Point(X - lado / 2, Y + lado / 2),
                new Point(X + lado / 2, Y + lado / 2)
            };

            using (SolidBrush brush = new SolidBrush(Color))
            {
                g.FillPolygon(brush, puntos);
            }
        }
    }
}
