using System;

namespace MoodAnalyzerAppWithCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer App");

            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am very Sad");
            string mood = moodAnalyzer.analyseMood();
            Console.WriteLine("Mood : " + mood);
        }
    }
}
