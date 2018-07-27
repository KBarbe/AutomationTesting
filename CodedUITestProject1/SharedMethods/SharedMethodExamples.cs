using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.SharedMethods
{
    public class SharedMethodExamples
    {
        public static Process LaunchNotepad(string filePath = @"C:\WINDOWS\system32\notepad.exe")
        {
            if (File.Exists(filePath))
            {
                Process process = new Process();
                process.StartInfo.FileName = filePath;
                process.Start();
                return process;
            }
            Assert.Fail("File not found. Please check filepath.");
            return null;
        }

        public static void DeleteFile(string filepath)
        {
            if(File.Exists(filepath))
            {
                File.Delete(filepath);
            }
        }
    }
}
