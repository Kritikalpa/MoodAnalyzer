using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerAppWithCore
{
    public class MoodAnalyzer
    {
        public string message;

        public MoodAnalyzer()
        {
            this.message = "I am happy";
        }
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string analyseMood()
        {
            try
            {
                if (this.message.Contains("Sad", StringComparison.InvariantCultureIgnoreCase))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException e)
            {
                return "HAPPY";
            }
            
        }
    }
}
