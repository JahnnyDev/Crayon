using GLFW;
using static GLFW.Flags;
using static MathS.Float;


namespace Input
{
    public static class Keyboard
    {
        public static IntPtr ActiveWindow;
        public static List<int> keysPressed = new(16);
        public static bool GetKey(int key)
        {
            bool pressed = glfw.GetKey(ActiveWindow, key) == GLFW_PRESS;
            if (pressed && !keysPressed.Contains(key)) keysPressed.Add(key);
            else if (!pressed && keysPressed.Contains(key)) keysPressed.Remove(key);
                return pressed;
            
        }
        public static bool GetKeyInfo(int key, out bool pressStart, out bool pressEnd)
        {
            bool pressed = glfw.GetKey(ActiveWindow, key) == GLFW_PRESS;
            pressStart = false;
            pressEnd = false;
            if (pressed && !keysPressed.Contains(key))
            {
                pressStart = true;
                keysPressed.Add(key);
            }
            else if (!pressed && keysPressed.Contains(key))
            {
                pressEnd = true;
                keysPressed.Remove(key);
            }
            return pressed;

        }
        public static bool GetKeyDown(int key) => GetKeyInfo(key, out bool s, out bool e) && s;
        public static bool GetKeyUp(int key) => !GetKeyInfo(key, out bool s, out bool e) && e;
        public static float GetAxis(int posKey, int negKey) => (GetKey(posKey) ? 1f : 0f) + (GetKey(negKey) ? -1f : 0f);
        public static float GetAxisInfo(int posKey, int negKey, out bool pressStart, out bool pressEnd)
        {
            float val = (GetKeyInfo(posKey, out bool pressStartP, out bool pressEndP) ? 1f : 0f) + (GetKeyInfo(negKey, out bool pressStartN, out bool pressEndN) ? -1f : 0f);
            pressStart = pressStartP || pressStartN;
            pressEnd = pressEndP || pressEndN;
            return val;
        }

    } 
}
