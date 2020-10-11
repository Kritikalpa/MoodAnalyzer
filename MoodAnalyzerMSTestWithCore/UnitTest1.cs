using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerAppWithCore;

namespace MoodAnalyzerMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        private MoodAnalyzer moodAnalyzer;
        
        [TestMethod]
        [DataRow("I am very sad", "SAD")]
        [DataRow("I am very happy", "HAPPY")]
        public void TestMethod1(string message, string expected)
        {
            moodAnalyzer = new MoodAnalyzer(message);
            string result = moodAnalyzer.analyseMood();
            Assert.AreEqual(result, expected);
        }
    }
}
