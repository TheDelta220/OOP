using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer3
{
    internal class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        public Drawing(Color background)
        {
            _background = background;
            _shapes = new List<Shape>();
        }
        public Drawing() : this(Color.White)
        {

        }
        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }
        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }

        public void AddShape(Shape shape)
        {
            if (shape != null)
            {
                _shapes.Add(shape);
            }
        }

        public void RemoveShape()
        {
            foreach (Shape _shape in _shapes.ToList())
            {
                if (_shape.Selected)
                {
                    _shapes.Remove(_shape);
                }
            }
        }


        public void Draw()
        {

            SplashKit.ClearScreen(_background);
            foreach (Shape _shape in _shapes)
            {

                _shape.Draw();
            }

        }
        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape _shape in _shapes)
                if (_shape.IsAt(pt))
                    _shape.Selected = true;
                else
                    _shape.Selected = false;
        }
        public void SelectedShapes()
        {
            foreach (Shape _shape in _shapes)
                if (_shape.Selected)
                    AddShape(_shape);
            return;
        }



    }
}
