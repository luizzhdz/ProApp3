using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionFiguras
{
    class Vista
    {
        Graphics g;
        Color colorlapiz, colorfondo;
        int anchura, altura;
        Pen lapiz;

        public Vista(Panel areadibujo, Color cl, Color cf)
        {
            g = areadibujo.CreateGraphics();
            colorlapiz = cl;
            colorfondo = cf;
            anchura = areadibujo.Width;
            altura = areadibujo.Height;
        }

        public void mostrar_rectangulo(Rectangulo r)
        {
            lapiz = new Pen(colorlapiz);
            lapiz.Width = 3;
            g.DrawRectangle(lapiz, r.P1.X, r.P1.Y, r.ancho(), r.altura());
        }

        public void mostrar_circulo(Circulo c)
        {
            lapiz = new Pen(colorlapiz);
            lapiz.Width = 3;
            g.DrawEllipse(lapiz, c.centro.X, c.centro.Y, c.radio, c.radio);
        }

        public void borrar()
        {
            SolidBrush fondo = new SolidBrush(Color.White);
            Rectangle rect = new Rectangle(0,0,anchura,altura);
            g.FillRectangle(fondo, rect);
        }



    }
}
