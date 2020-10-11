using System;

namespace MoodAnalyzerAppWithCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer App");

            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string mood = moodAnalyzer.analyseMood("I am very Sad");
            Console.WriteLine("Mood : " + mood);
        }
    }
}
