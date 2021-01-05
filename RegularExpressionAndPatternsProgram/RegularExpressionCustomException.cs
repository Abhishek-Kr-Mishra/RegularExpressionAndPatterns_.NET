using System;
using System.Collections.Generic;
using System.Text;

namespace RegularExpressionAndPatternsProgram
{
    public class RegularExpressionCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_VALUE,
        }
        public ExceptionType type;
        public RegularExpressionCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
