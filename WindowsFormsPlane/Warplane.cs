using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{

    public class Warplane : Plane, IEquatable<Warplane>
    {
        public Color DopColor { private set; get; }

        public bool Missele { private set; get; }

        public bool Foguete{ private set; get; }
       

        public Warplane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool missele, bool foguete) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            Missele = missele;
            Foguete = foguete;
        }

        public Warplane(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Missele = Convert.ToBoolean(strs[4]);
                Foguete = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Silver);
            Brush dopBrush = new SolidBrush(DopColor);

            base.DrawTransport(g);

            //misseil
            if (Missele)
            {
                g.DrawRectangle(pen, _startPosX + 150, _startPosY + 15, 10, 5);
                g.DrawRectangle(pen, _startPosX + 150, _startPosY + 25, 10, 5);
                g.DrawRectangle(pen, _startPosX + 150, _startPosY + 90, 10, 5);
                g.DrawRectangle(pen, _startPosX + 150, _startPosY + 100, 10, 5);

                g.FillRectangle(dopBrush, _startPosX + 150, _startPosY + 15, 10, 5);
                g.FillRectangle(dopBrush, _startPosX + 150, _startPosY + 25, 10, 5);
                g.FillRectangle(dopBrush, _startPosX + 150, _startPosY + 90, 10, 5);
                g.FillRectangle(dopBrush, _startPosX + 150, _startPosY + 100, 10, 5);
            }

            // foguete
            if (Foguete)
            {
                g.DrawEllipse(pen, _startPosX + 160, _startPosY + 16, 6, 3);
                g.DrawEllipse(pen, _startPosX + 160, _startPosY + 26, 6, 3);
                g.DrawEllipse(pen, _startPosX + 160, _startPosY + 91, 6, 3);
                g.DrawEllipse(pen, _startPosX + 160, _startPosY + 101, 6, 3);

                Brush brRed = new SolidBrush(Color.Red);
                g.FillEllipse(brRed, _startPosX + 160, _startPosY + 16, 6, 3);
                g.FillEllipse(brRed, _startPosX + 160, _startPosY + 26, 6, 3);
                g.FillEllipse(brRed, _startPosX + 160, _startPosY + 91, 6, 3);
                g.FillEllipse(brRed, _startPosX + 160, _startPosY + 101, 6, 3);
            }

            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 50, 110, 20);
            g.FillRectangle(dopBrush, _startPosX + 20, _startPosY + 50, 110, 20);
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Missele}{separator}{Foguete}";
        }

        public bool Equals(Warplane other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Missele != other.Missele)
            {
                return false;
            }
            if (Foguete != other.Foguete)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Warplane planObj))
            {
                return false;
            }
            else
            {
                return Equals(planObj);
            }
        }
    }
}
