﻿using System;
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
        private int ancho = 50;
        private int alto = 30;

        public Rectangulo(int x, int y, Color color) : base(x, y, color)
        {
            Contador++;
        }

        public override void Dibujar(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, Y, ancho, alto);
            }
        }
    }
}
