using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AplicacionFiguras
{
    class Rectangulo : Figura
    {
        public Point P1 { set; get; }
        public Point P2 { set; get; }

        public Rectangulo(Point p1, Point p2)
        {
            P1 = p1;
            P2 = P2;
        }
        public int ancho()
        {
            return Math.Abs(P2.X - P1.X);
        }

        public int altura()
        {
            return Math.Abs(P1.Y - P2.Y);
        }

        public override double area()
        {
            return ancho() * altura();
        }
    }
}
