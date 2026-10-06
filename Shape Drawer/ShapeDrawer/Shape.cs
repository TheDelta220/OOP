using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Shape
    {
        public Color _color;
        public float _x;
        public float _y;
        public int _width;
        public int _height;

        public Shape(int param)
        {
            _color = Color.Azure;
            _x = 0.0f;
            _y = 0.0f;
            _width = param;
            _height = param;
        }
        public void Draw()
        {
                SplashKit.FillRectangle(_color, _x, _y,
                _width, _height);
        }
        public bool IsAt(Point2D pt)
        {
            return pt.X >= _x && pt.X <= _x +_width &&
           pt.Y >= _y && pt.Y <= _y + _height;
        }

        
    }
}
