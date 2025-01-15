using GLFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MathS.Float;
using static GLFW.Flags;

namespace Input
{
    public static class Mouse
    {
       
        public static IntPtr ActiveWindow;
        public static List<int> buttonsPressed = new(8);

        public static unsafe Vec2 position { 
            get
            {
                double x = 0.0;
                double y = 0.0;
                glfw.GetMousePos(ActiveWindow, &x, &y);
                return new((float)x, (float)y);
            }
        }

        public static bool GetButton(int button)
        {
            bool pressed = glfw.GetMouseButton(ActiveWindow, button) == GLFW_PRESS;
            if (pressed && !buttonsPressed.Contains(button)) buttonsPressed.Add(button);
            else if (!pressed && buttonsPressed.Contains(button)) buttonsPressed.Remove(button);
            return pressed;
        }
        public static bool GetButtonInfo(int button, out bool pressStart, out bool pressEnd)
        {
            bool pressed = glfw.GetMouseButton(ActiveWindow, button) == GLFW_PRESS;
            pressStart = false;
            pressEnd = false;
            if (pressed && !buttonsPressed.Contains(button))
            {
                pressStart = true;
                buttonsPressed.Add(button);
            }
            else if (!pressed && buttonsPressed.Contains(button))
            {
                pressEnd = true;
                buttonsPressed.Remove(button);
            }
            return pressed;

        }
        public static bool GetButtonDown(int key) => GetButtonInfo(key, out bool s, out bool e) && s;
        public static bool GetButtonUp(int key) => !GetButtonInfo(key, out bool s, out bool e) && e;

        
    }
}
