using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dz1
{

    public static class Task1
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr intPtr, string text, string caption, uint type);

        public static void Run()
        {
            MessageBox(IntPtr.Zero, "Maxym", "Caption", 0);
            MessageBox(IntPtr.Zero, "18 y.o.", "Caption", 0);
            MessageBox(IntPtr.Zero, "live in Ukraine", "Caption", 0);
        }
    }
}
