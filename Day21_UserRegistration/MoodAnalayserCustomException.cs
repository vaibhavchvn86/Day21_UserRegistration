using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserAppWithCore
{
    public class MoodAnalyserCustomException: Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME, INVALID_LASTNAME, INVALID_MOBILE,
            INVALID_EMAIL, INVALID_PASSWORD
        }
        private readonly ExceptionType type;
        public MoodAnalyserCustomException(ExceptionType Type,string message) : base (message)
        {
            this.type = Type;
        }
    }
}
