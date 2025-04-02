using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class Linea : Figura
    {
        private int longitud = 50;

        public Linea(int x, int y, Color color) : base(x, y, color) { }

        public override void Dibujar(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                g.DrawLine(pen, X, Y, X + longitud, Y);
            }
        }
    }
}
