using AutomationTesting.CodedUIMaps.Notepad_UIMapClasses;
using AutomationTesting.CodedUIMaps.SaveAs_UIMapClasses;

namespace AutomationTesting
{
    public class UIMaps
    {
        //notepad ui
        private static Notepad_UIMap notepad;

        public static Notepad_UIMap Notepad
        {
            get
            {
                return notepad ?? new Notepad_UIMap();
            }
            set
            {
                notepad = value;
            }
        }

        //save as ui
        private static SaveAs_UIMap saveAs;

        public static SaveAs_UIMap SaveAs
        {
            get
            {
                return saveAs ?? new SaveAs_UIMap();
            }
            set
            {
                saveAs = value;
            }
        }
    }
}
