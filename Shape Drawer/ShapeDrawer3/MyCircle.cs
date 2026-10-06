using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer3
{
    public class MyCircle : Shape
    {
        public int _radius;

        public MyCircle() : this (Color.Blue, 50 + 19)
        {
            _radius = 50;
            
        }
        public MyCircle(Color color, int radius) : base(color) 
        {
            Radius = radius;
            
        }

        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillCircle(_color, _x, _y,
            _radius);

        }
        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, _x, _y,
              _radius + 2);
        }
        public override bool IsAt(Point2D pt)
        {
            double a = (double)(pt.X - X);
            double b = (double)(pt.Y - Y);
            if (Math.Sqrt(a * a + b * b) < _radius)
            {
                return true;
            };
            return false;
        }
    }
}
