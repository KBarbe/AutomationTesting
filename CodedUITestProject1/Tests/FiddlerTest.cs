using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationTesting.SharedMethods;

namespace AutomationTesting.Tests
{
    /// <summary>
    /// Summary description for FiddlerTest
    /// </summary>
    [CodedUITest]
    public class FiddlerTest
    {
        [TestMethod]
        public void Fiddler_test()
        {
            FiddlerApi.GeneratePostBody("<fiddlerFile>");
            FiddlerApi fiddlerApi = new FiddlerApi(); //{parameters};
            string result = fiddlerApi.SubmitFiddler();

            //continue with codedui or selenium test steps...
        }
    }
}
