using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dz1
{
    public class Task2
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int FindWindow(string windowName, bool wait);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, nuint wParam, StringBuilder lParam);

        public static void Run()
        {
            int res = FindWindow("Notepad", false);
            SendMessage((IntPtr)res, 0, 0, new StringBuilder("Window found"));
        }
    }
}
