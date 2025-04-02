using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;




namespace DibujarRectangulosFactory
{
    public partial class Form1 : Form
    {
        private Color selectedColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
            drawingPanel.Paint += drawingPanel_Paint;
            cmbFigura.Items.AddRange(new string[] { "Rectángulo", "Círculo", "Línea", "Triángulo" });
            cmbFigura.SelectedIndex = 0;
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

        private void btnDraw_Click(object sender, EventArgs e)
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

                string tipoFigura = cmbFigura.SelectedItem.ToString();
                Figura nuevaFigura = FiguraFactory.CrearFigura(tipoFigura, x, y, selectedColor);

                // Debugging
                Debug.WriteLine($"Se agregó una figura, total: {Figura.Figuras.Count}");
                foreach (var fig in Figura.Figuras)
                {
                    Debug.WriteLine($"Figura en X: {fig.X}, Y: {fig.Y}");
                }

                drawingPanel.Invalidate(); // Redibujar el panel
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
                figura.Dibujar(e.Graphics);
            }
        }
    }
}
