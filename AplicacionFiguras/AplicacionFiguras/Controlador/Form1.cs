using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionFiguras
{
    public partial class Form1 : Form
    {
        Vista v;
        Circulo c;
        Rectangulo r;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
            btnDibujar.Enabled = true;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            dibujar();
        }

        public void calcular()
        {
            if (rbrec.Checked)
            {
                Point punto1 = new Point(Convert.ToInt16(txtrP1X.Text), Convert.ToInt16(txtrP1Y.Text));
                Point punto2 = new Point(Convert.ToInt16(txtrP2X.Text), Convert.ToInt16(txtrP2Y.Text));
                r = new Rectangulo(punto1, punto2);
                lbAreaR.Text = r.area().ToString();
            }
            else
            {
                Point puntoCirculo = new Point(Convert.ToInt16(txtCX.Text), Convert.ToInt16(txtCY.Text));
                int radio = int.Parse(txtCRadio.Text);
                c = new Circulo(radio, puntoCirculo);
                lbAreaC.Text = c.area().ToString();
            }
        }

        public void dibujar()
        {
            v = new Vista(panel1, Color.Blue, Color.White);
            if (rbrec.Checked)
                v.mostrar_rectangulo(r);
            else
                if (rbcirc.Checked)
                    v.mostrar_circulo(c);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            lbCoordenada.Text = String.Format("{0} , {1}", e.X, e.Y); 
        }

        private void txtCP2Y_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbrec.Checked)
            {
                txtrP1X.Text = e.X.ToString();
                txtrP1Y.Text = e.Y.ToString();
            }
            else
            {
                txtCX.Text = e.X.ToString();
                txtCY.Text = e.Y.ToString();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (rbrec.Checked)
            {
                txtrP2X.Text = e.X.ToString();
                txtrP2Y.Text = e.Y.ToString();
                calcular();
                dibujar();
            }
            else
            {
                txtCRadio.Text = Math.Abs(Convert.ToInt32(txtCX.Text) - e.X).ToString();
                calcular();
                dibujar();
            }
        }

        private void rbrec_CheckedChanged(object sender, EventArgs e)
        {
            gbrec.Enabled = true;
            gbCir.Enabled = false;
        }

        private void rbcirc_CheckedChanged(object sender, EventArgs e)
        {
            gbCir.Enabled = true;
            gbrec.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            v.borrar();
        }

    }
}
