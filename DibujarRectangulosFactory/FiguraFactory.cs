using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DibujarRectangulosFactory;

public static class FiguraFactory
{
    public static Figura CrearFigura(string tipo, int x, int y, Color color)
    {
        Figura nuevaFigura;

        if (tipo == "Rectángulo")
        {
            nuevaFigura = new Rectangulo(x, y, color);
        }
        else if (tipo == "Círculo")
        {
            nuevaFigura = new Circulo(x, y, color);
        }
        else if (tipo == "Línea")
        {
            nuevaFigura = new Linea(x, y, color);
        }
        else if (tipo == "Triángulo")
        {
            nuevaFigura = new Triangulo(x, y, color);
        }
        else
        {
            throw new ArgumentException("Tipo de figura no válido");
        }

        Figura.Figuras.Add(nuevaFigura); 
        return nuevaFigura;
    }
}
