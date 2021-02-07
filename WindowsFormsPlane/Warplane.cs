using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    public class Warplane
    {
      
        private float _startPosX;
        
        private float _startPosY;
       
        private int _pictureWidth;
       
        private int _pictureHeight;

        private readonly int planeWidth = 100;
       
        private readonly int planeHeight = 60;
       
        public int MaxSpeed { private set; get; }
       
        public float Weight { private set; get; }
       
        public Color MainColor { private set; get; }
       
        public Color DopColor { private set; get; }
       
        public bool Missele{ private set; get; }
       
        public Warplane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool missele)
        {
            MaxSpeed = maxSpeed;       
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Missele = missele;
        }
       
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth - 120)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight - 90)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Silver);
            Brush planeBody = new SolidBrush(MainColor);
            Brush airplaneCol = new SolidBrush(DopColor);

            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 40, 110, 40);
            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 50, 110, 20);
            g.DrawEllipse(pen, _startPosX + 20, _startPosY + 40, 15, 30);
            g.DrawEllipse(pen, _startPosX + 50, _startPosY + 50, 15, 30);
            g.DrawEllipse(pen, _startPosX + 80, _startPosY + 40, 15, 30);
            g.DrawEllipse(pen, _startPosX + 110, _startPosY + 50, 15, 30);
            g.DrawEllipse(pen, _startPosX + 140, _startPosY + 40, 15, 30);

            // Inside
            Brush brSilver = new SolidBrush(Color.Silver);
            g.FillRectangle(brSilver, _startPosX + 20, _startPosY + 40, 110, 41);
            g.FillEllipse(planeBody, _startPosX + 110, _startPosY + 39, 91, 42);
            g.FillEllipse(planeBody, _startPosX + 110, _startPosY + 40, 90, 40);

            // side
            g.DrawRectangle(pen, _startPosX + 35, _startPosY + 20, 15, 20);
            g.DrawRectangle(pen, _startPosX + 35, _startPosY + 80, 15, 20);
            g.DrawRectangle(pen, _startPosX + 130, _startPosY + 15, 20, 25);
            g.DrawRectangle(pen, _startPosX + 130, _startPosY + 80, 20, 25);

            g.FillRectangle(airplaneCol, _startPosX + 35, _startPosY + 20, 15, 20);
            g.FillRectangle(airplaneCol, _startPosX + 35, _startPosY + 80, 15, 20);
            g.FillRectangle(airplaneCol, _startPosX + 130, _startPosY + 15, 20, 25);
            g.FillRectangle(airplaneCol, _startPosX + 130, _startPosY + 80, 20, 25);

            Brush brSkyBlue = new SolidBrush(Color.SkyBlue);
            g.FillEllipse(brSkyBlue, _startPosX + 20, _startPosY + 40, 15, 30);
            g.FillEllipse(brSkyBlue, _startPosX + 50, _startPosY + 50, 15, 30);
            g.FillEllipse(brSkyBlue, _startPosX + 80, _startPosY + 40, 15, 30);
            g.FillEllipse(brSkyBlue, _startPosX + 110, _startPosY + 50, 15, 30);
            g.FillEllipse(brSkyBlue, _startPosX + 140, _startPosY + 40, 15, 30);

            //misseil
            if (Missele)
            {
                g.DrawRectangle(pen, _startPosX + 150, _startPosY + 15, 10, 5);
                g.DrawRectangle(pen, _startPosX + 150, _startPosY + 25, 10, 5);
                g.DrawRectangle(pen, _startPosX + 150, _startPosY + 90, 10, 5);
                g.DrawRectangle(pen, _startPosX + 150, _startPosY + 100, 10, 5);

                g.FillRectangle(airplaneCol, _startPosX + 150, _startPosY + 15, 10, 5);
                g.FillRectangle(airplaneCol, _startPosX + 150, _startPosY + 25, 10, 5);
                g.FillRectangle(airplaneCol, _startPosX + 150, _startPosY + 90, 10, 5);
                g.FillRectangle(airplaneCol, _startPosX + 150, _startPosY + 100, 10, 5);
            }

            //стекла
            g.DrawEllipse(pen, _startPosX + 164, _startPosY + 54, 25, 12);
            Brush brIvory = new SolidBrush(Color.Ivory);
            g.FillEllipse(brIvory, _startPosX + 164, _startPosY + 54, 25, 12);

            // frente
            g.DrawEllipse(pen, _startPosX + 199, _startPosY + 60, 4, 3);
            Brush brLawnGreen = new SolidBrush(Color.LawnGreen);
            g.FillEllipse(brLawnGreen, _startPosX + 199, _startPosY + 60, 4, 3);

            // back
            g.DrawRectangle(pen, _startPosX + 18, _startPosY + 45, 2, 10);
            g.DrawRectangle(pen, _startPosX + 18, _startPosY + 55, 2, 10);
            g.DrawRectangle(pen, _startPosX + 18, _startPosY + 65, 2, 10);
           
            g.FillRectangle(airplaneCol, _startPosX + 18, _startPosY + 45, 2, 9);
            g.FillRectangle(airplaneCol, _startPosX + 18, _startPosY + 55, 2, 10);
            g.FillRectangle(airplaneCol, _startPosX + 18, _startPosY + 65, 2, 11);
        }
    }
}
