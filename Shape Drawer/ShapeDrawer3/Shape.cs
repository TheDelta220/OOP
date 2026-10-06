using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer3
{
    public abstract class Shape
    {
        public Color _color;
        public float _x;
        public float _y;
        public bool _selected;

        public Shape()
        {
            _color = Color.Azure;
            _x = X;
            _y = Y;
            
        }
        public Shape(Color color)
        { 
            _color = color;
            _x = 0.0f;
            _y = 0.0f;
        }
        abstract public void Draw();

        public abstract bool IsAt(Point2D pt);
        
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }
        public abstract void DrawOutline();
        
        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        
    }

}
