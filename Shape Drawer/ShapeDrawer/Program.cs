using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Shape myShape = new Shape(119);
            Window window = new Window("ShapeDrawer", 800, 600);
            SplashKit.MouseClicked(MouseButton.LeftButton);
            SplashKit.MouseX();
            
            do
            {
                SplashKit.ClearScreen();
                myShape.Draw();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myShape._x = SplashKit.MouseX();
                    myShape._y = SplashKit.MouseY();
                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey) && myShape.IsAt(SplashKit.MousePosition()))
                {
                     myShape._color = SplashKit.RandomColor();

                }
                
                SplashKit.ProcessEvents();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
            
        }

    }
}
