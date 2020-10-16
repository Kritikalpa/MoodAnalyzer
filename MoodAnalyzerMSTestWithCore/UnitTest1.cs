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


        /// <summary>
        /// TC 4.1-Givens the mood analyzer class name should return mood analyzer object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyzerClassNameShouldReturnMoodAnalyzerObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            object obj = MoodAnalyzerFactory.createMoodAnalyzer("MoodAnalyzerAppWithCore.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC 4.2-Givens the mood analyzer class name improper should throw mood analysis exception.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyzerClassNameImproperShouldThrowMoodAnalysisException()
        {
            try
            {
                object obj = MoodAnalyzerFactory.createMoodAnalyzer("MoodAnalyzerAppWithCore.WrongClassName", "WrongClassName");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }

        /// <summary>
        /// TC 4.3- Givens the mood analyzer class name constructor improper should throw mood analysis exception.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyzerClassNameConstructorImproperShouldThrowMoodAnalysisException()
        {
            try
            {
                object obj = MoodAnalyzerFactory.createMoodAnalyzer("MoodAnalyzerAppWithCore.MoodAnalyzer", "WrongConstructorName");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Constructor is Not Found", e.Message);
            }
        }

        /// <summary>
        /// TC 5.1- Givens the mood analyzer class name should return mood analyzer object using parameterized constructor.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyzerClassNameShouldReturnMoodAnalyzerObjectUsingParameterizedConstructor()
        {
            object expected = new MoodAnalyzer("Happy");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyzerUsingParameterizedConstructor("MoodAnalyzerAppWithCore.MoodAnalyzer", "MoodAnalyzer", "Happy");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC 5.2- Givens the mood analyzer class name improper should throw mood analysis exception.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyzerClassNameImproperShouldThrowMoodAnalysisEdxception()
        {
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyzerUsingParameterizedConstructor("MoodAnalyzerAppWithCore.WrongClassName", "MoodAnalyzer", "Happy");
            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }

        /// <summary>
        /// TC 5.3- Givens the mood analyzer class constructor improper should throw mood analysis exception.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyzerClassConstructorImproperShouldThrowMoodAnalysisEdxception()
        {
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyzerUsingParameterizedConstructor("MoodAnalyzerAppWithCore.MoodAnalyzer", "WrongConstructorName", "Happy");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Constructor is Not Found", e.Message);
            }
        }


        /// <summary>
        /// TC 6.1- Invokes the analyse mood using reflection.
        /// </summary>
        [TestMethod]
        public void InvokeAnalyseMoodUsingReflection()
        {
            MoodAnalyzer instance = new MoodAnalyzer("I am Sad");
            string expected = instance.analyseMood();
            string result = MoodAnalyzerFactory.invokeAnalyseMood("I am Sad", "analyseMood");

            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// TC 6.2- Givens the improper method should throw mood analysis exception.
        /// </summary>
        [TestMethod]
        public void GivenImproperMethodShouldThrowMoodAnalysisException()
        {
            try
            {
                string result = MoodAnalyzerFactory.invokeAnalyseMood("I am Sad", "wrongMethod");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Method Not Found", e.Message);
            }    
        }

        /// <summary>
        /// TC 6.3- Givens the null message should throw mood analysis exception.
        /// </summary>
        [TestMethod]
        public void GivenNullMessageShouldThrowMoodAnalysisException()
        {
            try
            {
                string result = MoodAnalyzerFactory.invokeAnalyseMood(null, "analyseMood");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }

        }
    }
}
