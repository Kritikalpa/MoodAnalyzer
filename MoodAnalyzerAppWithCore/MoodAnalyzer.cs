using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerAppWithCore
{
    public class MoodAnalyzer
    {
        public string analyseMood(string message)
        {
            if (message.Contains("Sad", StringComparison.InvariantCultureIgnoreCase))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
