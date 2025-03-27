using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class Rectangulo : Figura
    {
        public static int Contador { get; private set; } = 0;

        public Rectangulo(int x, int y, Color color) : base(x, y, color)
        {
            Contador++;
        }
    }
}
