using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerAppWithCore;

namespace MoodAnalyzerMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        private MoodAnalyzer moodAnalyzer;
        
        /// <summary>
        /// TC1.1 - Given Happy Mood Should Return Happy
        /// TC1.2 - Given Sad Mood Should Return Sad
        /// </summary>
        /// <param name="message"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("I am very sad", "SAD")]
        [DataRow("I am very happy", "HAPPY")]
        public void GivenHappyOrSadMoodShouldReturnHappyOrSad(string message, string expected)
        {
            moodAnalyzer = new MoodAnalyzer(message);
            string result = moodAnalyzer.analyseMood();
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// TC 3.2 - Given Empty Mood Should throw Mood Analysis Exception
        /// </summary>
        [TestMethod]
        public void GivenEmptyMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = "";
                moodAnalyzer = new MoodAnalyzer(message);
                string mood = moodAnalyzer.analyseMood();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }

        /// <summary>
        /// TC 3.1 - Given Null Mood Should throw Mood Analysis Exception
        /// </summary>
        [TestMethod]
        public void GivenNullMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = null;
                moodAnalyzer = new MoodAnalyzer(message);
                string result = moodAnalyzer.analyseMood();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
            
        }
    }
}
