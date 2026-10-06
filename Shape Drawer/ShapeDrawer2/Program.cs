using System;
using SplashKitSDK;

namespace ShapeDrawer2
{
    public class Program
    {
        public static void Main()
        {
            Drawing myDrawing = new Drawing();
            Window window = new Window("ShapeDrawer", 800, 600);
            SplashKit.MouseClicked(MouseButton.LeftButton);
            SplashKit.MouseX();

            do
            {
                SplashKit.ClearScreen();
                myDrawing.Draw();
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    
                    myDrawing.SelectShapesAt(SplashKit.MousePosition());
                }
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    int X = (int)SplashKit.MouseX();
                    int Y = (int)SplashKit.MouseY();
                    myDrawing.AddShape(new Shape(X, Y));
                    
                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.Background = SplashKit.RandomColor();
                }
                if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    myDrawing.RemoveShape();
                }
                if (SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    
                    myDrawing.RemoveShape();
                }


                SplashKit.ProcessEvents();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);

        }
    }
}
