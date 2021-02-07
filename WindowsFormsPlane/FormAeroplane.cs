using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlane
{
    public partial class FormAeroplane : Form
    {
        private readonly Aeroplane<Plane> aeroplane;
        public FormAeroplane()
        {
            InitializeComponent();
            aeroplane = new Aeroplane<Plane>(pictureBoxAeroplane.Width, pictureBoxAeroplane.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAeroplane.Width, pictureBoxAeroplane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aeroplane.Draw(gr);
            pictureBoxAeroplane.Image = bmp;
        }

        private void buttonLandPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Plane(100, 1000, dialog.Color);
                if (aeroplane + plane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Мест нет");
                }
            }
        }

        private void buttonLandWarplane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Warplane(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    if (aeroplane + plane)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Мест нет");
                    }
                }
            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var plane = aeroplane - Convert.ToInt32(maskedTextBox.Text);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
