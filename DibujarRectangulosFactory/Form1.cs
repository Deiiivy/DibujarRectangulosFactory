using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujarRectangulosFactory
{
    public partial class Form1 : Form
    {
        private Color selectedColor = Color.Black;
        public Form1()
        {
            InitializeComponent();
            drawingPanel.Paint += drawingPanel_Paint;
        }



        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedColor = colorDialog.Color;
                    picColorPreview.BackColor = selectedColor;
                }
            }
        }

        private void btnDrawRectangle_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtX.Text);
                int y = int.Parse(txtY.Text);

                if (x < 0 || y < 0 || x > drawingPanel.Width || y > drawingPanel.Height)
                {
                    MessageBox.Show("Las coordenadas deben estar dentro del panel de dibujo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FiguraFactory.CrearFigura(x, y, selectedColor);

                drawingPanel.Invalidate();

                txtCounter.Text = Rectangulo.Contador.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Las coordenadas deben ser números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (var figura in Figura.Figuras)
            {
                using(SolidBrush brush = new SolidBrush(figura.Color))
                {
                    e.Graphics.FillRectangle(brush, figura.X, figura.Y, 50, 30);
                }
            }
        }
    }
}
