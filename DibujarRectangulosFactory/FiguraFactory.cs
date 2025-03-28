using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DibujarRectangulosFactory
{
    public static class FiguraFactory
    {
        public static Figura CrearFigura(int x, int y, Color color)
        {
            return new Rectangulo(x, y, color);
        }
    }
}
