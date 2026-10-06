using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer3
{
    public class MyRectangle : Shape 
    {
        public int _width;
        public int _height;

        public MyRectangle(Color color, float x, float y, int width, int height) : base(color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        public MyRectangle() : this (Color.Green, 0.0f, 0.0f, 100 + 19, 100 + 19)
        {

        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(_color, _x, _y,
            _width, _height);

        }
        public override bool IsAt(Point2D pt)
        {
            return pt.X >= X && pt.X <= X + _width &&
           pt.Y >= Y && pt.Y <= Y + _height;
        }
        public override void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, _x - 7, _y - 7,
              _width + 14, _height + 14);
        }
    }
}
