using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerAppWithCore;

namespace MoodAnalyzerMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        private MoodAnalyzer moodAnalyzer;
        public UnitTest1()
        {
            moodAnalyzer = new MoodAnalyzer();
        }
        [TestMethod]
        [DataRow("I am very sad", "SAD")]
        [DataRow("I am very happy", "HAPPY")]
        public void TestMethod1(string message, string expected)
        {
            string result = moodAnalyzer.analyseMood(message);
            Assert.AreEqual(result, expected);
        }
    }
}
