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
    public partial class FormPlaneConfig : Form
    {
        Vehicle plane = null;

        private event Action<Vehicle> eventAddPlane;
        public FormPlaneConfig()
        {
            InitializeComponent();
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelAqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelFuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(10, 50, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawTransport(gr);
                pictureBoxPlane.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }

        private void labelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelWarplane_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarplane.DoDragDrop(labelWarplane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный самолёт":
                    plane = new Plane((int)numericUpDownMaxSpeed.Value,
                        (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Самолёт войны":
                    plane = new Warplane((int)numericUpDownMaxSpeed.Value,(int)numericUpDownWeight.Value, 
                        Color.White, Color.Black, checkBoxMissele.Checked, checkBoxFoguete.Checked);
                    break;
            }
            DrawPlane();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null && plane is Warplane)
            {
                (plane as Warplane).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }
    }
}
