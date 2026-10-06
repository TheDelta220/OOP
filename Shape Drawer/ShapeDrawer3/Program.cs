using System;
using System.Security.Cryptography.X509Certificates;
using SplashKitSDK;

namespace ShapeDrawer3
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            ShapeKind kindToAdd = new ShapeKind();
            kindToAdd = ShapeKind.Circle;
            Drawing myDrawing = new Drawing();
            Window window = new Window("ShapeDrawer", 800, 600);
            SplashKit.MouseClicked(MouseButton.LeftButton);
            SplashKit.MouseX();
            int LineX = 9;
            int index = 0;

            do
            {
                SplashKit.ClearScreen();
                
                myDrawing.Draw();
                Console.WriteLine(index);
                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }
                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {

                    myDrawing.SelectShapesAt(SplashKit.MousePosition());
                }
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {

                    Shape newShape;
                    
                        

                  switch (kindToAdd)
                  {
                    case ShapeKind.Line:
                     newShape = new MyLine();
                     newShape.X = SplashKit.MouseX();
                     newShape.Y = SplashKit.MouseY();
                    break;
                    case ShapeKind.Circle:
                     newShape = new MyCircle();
                     newShape.X = SplashKit.MouseX();
                     newShape.Y = SplashKit.MouseY();
                    break;
                    default:
                     newShape = new MyRectangle();
                     newShape.X = SplashKit.MouseX();
                     newShape.Y = SplashKit.MouseY();
                    break;
                  }
                   if (index >= 9 && kindToAdd == ShapeKind.Line)
                    {
                   
                    }
                   else
                    {
                        myDrawing.AddShape(newShape);
                    }
                    if (index < 9)
                    {

                    }
                 
                    if (kindToAdd == ShapeKind.Line && index <= 9)
                    {
                        index++;
                    }
                    


                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.Background = SplashKit.RandomColor();
                }
                if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    if (kindToAdd == ShapeKind.Line)
                    {
                        index = index -1;
                        myDrawing.RemoveShape();
                    }
                    else
                    {

                    }
                       
                    
                }
                if (SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    if (kindToAdd == ShapeKind.Line)
                    {
                        index--;
                        myDrawing.RemoveShape();
                        
                        
                    }
                    else
                    {
                        myDrawing.RemoveShape();
                    }
                }


                SplashKit.ProcessEvents();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);

        }
    }
}
