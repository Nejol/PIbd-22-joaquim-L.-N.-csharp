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
        private readonly AeroplaneCollection aeroplaneCollection;
        public FormAeroplane()
        {
            InitializeComponent();
            aeroplaneCollection = new AeroplaneCollection(pictureBoxAeroplane.Width, pictureBoxAeroplane.Height);
            Draw();
        }

        private void ReloadLevels()
        {
            int index = listBoxAeroplanes.SelectedIndex;
            listBoxAeroplanes.Items.Clear();
            for (int i = 0; i < aeroplaneCollection.Keys.Count; i++)
            {
                listBoxAeroplanes.Items.Add(aeroplaneCollection.Keys[i]);
            }
            if (listBoxAeroplanes.Items.Count > 0 && (index == -1 || index >= listBoxAeroplanes.Items.Count))
            {
                listBoxAeroplanes.SelectedIndex = 0;
            }
            else if (listBoxAeroplanes.Items.Count > 0 && index > -1 && index < listBoxAeroplanes.Items.Count)
            {
                listBoxAeroplanes.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxAeroplanes.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAeroplane.Width, pictureBoxAeroplane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aeroplaneCollection[listBoxAeroplanes.SelectedItem.ToString()].Draw(gr);
                pictureBoxAeroplane.Image = bmp;
            }
        }

        private void buttonAddAeroplane_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название аэроплана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            aeroplaneCollection.AddAeroplane(textBoxNewLevelName.Text);
            textBoxNewLevelName.Text = "";
            ReloadLevels();
        }

        private void buttonDeleteAeroplane_Click(object sender, EventArgs e)
        {
            if (listBoxAeroplanes.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить аэроплан {listBoxAeroplanes.SelectedItem.ToString()}?",
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    aeroplaneCollection.DelAeroplane(listBoxAeroplanes.Text);
                    textBoxNewLevelName.Text = "";
                    ReloadLevels();
                }
            }
        }

        private void buttonLandPlane_Click(object sender, EventArgs e)
        {
            if (listBoxAeroplanes.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Plane(100, 1000, dialog.Color);
                    if (aeroplaneCollection[listBoxAeroplanes.SelectedItem.ToString()] + plane)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Аэроплан переполнен");
                    }
                }
            }
        }

        private void buttonLandWarplane_Click(object sender, EventArgs e)
        {
            if (listBoxAeroplanes.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var aircraft = new Warplane(100, 1000, dialog.Color,dialogDop.Color, true, true);
                        if (aeroplaneCollection[listBoxAeroplanes.SelectedItem.ToString()] + aircraft)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Парковка переполнена");
                        }
                    }
                }
            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxAeroplanes.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var plane = aeroplaneCollection[listBoxAeroplanes.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void listBoxAeroplanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
