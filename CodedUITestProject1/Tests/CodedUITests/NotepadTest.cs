using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using AutomationTesting.SharedMethods;
using System.Windows.Forms;
using System;
using System.IO;

namespace AutomationTesting.Tests.CodedUITests
{
    /// <summary>
    /// This uses the Notepad to display 3 methods of entering text and saving/deleting a file
    /// </summary>
    [CodedUITest]
    public class NotepadTest
    {
        private static string fileName = "NotepadTest.txt";

        [TestMethod]
        public void Notepad_test()
        {
            try
            {
                //Launching windows app
                using (Process notepadProcess = SharedMethodExamples.LaunchNotepad())
                {
                    //wait for text area to be ready
                    UIMaps.Notepad.Notepad.TextEditor.WaitForControlReady();

                    //send text
                    UIMaps.Notepad.Notepad.TextEditor.TextEditor_txt.SendKeys("This is an example of sending keys directly");

                    //keyboard shortcut -- select all
                    UIMaps.Notepad.Notepad.TextEditor.TextEditor_txt.SendKeys("^A");

                    //send from clipboard
                    Clipboard.SetText("This is an example of pasting text from the clipboard");
                    UIMaps.Notepad.Notepad.TextEditor.TextEditor_txt.SendKeys("^V");

                    //save example
                    SaveFile(fileName);

                    //delete example
                    string filepath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/{fileName}";
                    SharedMethodExamples.DeleteFile(filepath);

                    //assert file was deleted
                    Assert.IsTrue(!File.Exists(filepath));
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private static void SaveFile(string fileName)
        {
            //click save menu item
            UIMaps.Notepad.NotepadMenus.NotepadMenuBar.FileMenu.Save_menu.Click();
            //set file destination
            UIMaps.SaveAs.SaveAsWindow.SaveAsAddress.SaveAsAddress_bar.Click();
            Keyboard.SendKeys(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "{ENTER}");
            //set file name
            UIMaps.SaveAs.SaveAsWindow.FileName.FileName_txt.Text = fileName;
            UIMaps.SaveAs.SaveAsWindow.Save.Save_btn.Click();
        }
    }
}
