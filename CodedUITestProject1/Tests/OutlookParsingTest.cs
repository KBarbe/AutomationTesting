using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AutomationTesting.Tests
{
    /// <summary>
    /// Summary description for OutlookParsingTest
    /// </summary>
    [CodedUITest]
    public class OutlookParsingTest
    {
        [TestMethod]
        public void OutlookParsing_test()
        {
            string emailSubstring = SharedMethods.SharedMethodExamples.ParseOutlook("emailSubject", "Unique Email", "ParseString", 5, 10);
        }
    }
}
