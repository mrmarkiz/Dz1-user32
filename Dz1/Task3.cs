using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dz1
{
    public enum beepType : uint
    {
        /// <summary>
        /// A simple windows beep
        /// </summary>            
        SimpleBeep = 0xFFFFFFFF,
        /// <summary>
        /// A standard windows OK beep
        /// </summary>
        OK = 0x00,
        /// <summary>
        /// A standard windows Question beep
        /// </summary>
        Question = 0x20,
        /// <summary>
        /// A standard windows Exclamation beep
        /// </summary>
        Exclamation = 0x30,
        /// <summary>
        /// A standard windows Asterisk beep
        /// </summary>
        Asterisk = 0x40,
    }
    public static class Task3
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern bool MessageBeep(beepType uType);

        public static void Run()
        {
            MessageBeep(beepType.SimpleBeep);
            Thread.Sleep(1000);
            MessageBeep(beepType.OK);
            Thread.Sleep(1000);
            MessageBeep(beepType.Question);
            Thread.Sleep(1000);
            MessageBeep(beepType.Exclamation);
            Thread.Sleep(1000);
            MessageBeep(beepType.Asterisk);
        }
    }
}
