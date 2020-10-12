using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerAppWithCore
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_FIELDS, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }

        private readonly ExceptionType type;

        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
