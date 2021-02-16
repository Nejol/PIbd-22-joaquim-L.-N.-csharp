﻿using System;
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

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            var formPlaneConfig = new FormPlaneConfig();
            formPlaneConfig.AddEvent(AddPlane);
            formPlaneConfig.Show();
        }

        private void AddPlane(Vehicle plane)
        {
            if (plane != null && listBoxAeroplanes.SelectedIndex > -1)
            {
                if ((aeroplaneCollection[listBoxAeroplanes.SelectedItem.ToString()]) + plane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Самолёт не удалось посадить");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (aeroplaneCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (aeroplaneCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }
    }
}
