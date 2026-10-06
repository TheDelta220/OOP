using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer2
{
    public class Shape
    {
        public Color _color;
        public float _x;
        public float _y;
        public int _width;
        public int _height;
        public bool _selected;

        public Shape(int x, int y)
        {
            _color = Color.Azure;
            _x = x;
            _y = y;
            _width = 100;
            _height = 100;
        }
        public void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(_color, _x, _y,
            _width, _height);
            
        }
        public bool IsAt(Point2D pt)
        {
            return pt.X >= _x && pt.X <= _x + _width &&
           pt.Y >= _y && pt.Y <= _y + _height;
        }
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }
        public void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, _x -7, _y -7,
              _width +14, _height +14);  
        }
        
    }
}
