using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer3
{
    public class MyLine : Shape
    {
        public float endX;
        public float endY;

        public MyLine(Color color, float startX, float startY, float endX, float endY) : base(color)
        {
            X = startX;
            Y = startY;
            EndX = endX;
            EndY = endY;
        }
        public MyLine() : this(Color.Red, 0.0f, 0.0f, 100, 100)
        {

        }
        public float EndX
        {
            get
            {
                return endX;
            }
            set
            {
                endX = value;
            }
        }

        public float EndY
        {
            get
            {
                return endY;
            }
            set
            {
                endY = value;
            }
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(_color, _x, _y,
            endX, endY);

        }
        public override bool IsAt(Point2D pt)
        {
            return pt.X >= X && pt.X <= X + EndX &&
           pt.Y >= Y && pt.Y <= Y + EndY;
        }
        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, _x -2, _y -2,
              endX + 5, endY +5);
        }

    }
}

