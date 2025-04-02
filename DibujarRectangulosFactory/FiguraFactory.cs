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
        public static Figura CrearFigura(string tipo, int x, int y, Color color)
        {
            switch (tipo)
            {
                case "Rectángulo": return new Rectangulo(x, y, color);
                case "Círculo": return new Circulo(x, y, color);
                case "Línea": return new Linea(x, y, color);
                case "Triángulo": return new Triangulo(x, y, color);
                default: throw new ArgumentException("Tipo de figura no válido");
            }
        }

    }
}
