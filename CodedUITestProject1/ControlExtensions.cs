using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting
{
    public static class ControlExtensions
    {
        //sendkeys extension
        public static void SendKeys(this WinControl winControl, string text)
        {
            Keyboard.SendKeys(winControl, text);
        }

        //mouse click extension
        public static void Click(this WinControl winControl)
        {
            winControl.WaitForControlReady();
            Mouse.Click(winControl);
        }
    }
}
