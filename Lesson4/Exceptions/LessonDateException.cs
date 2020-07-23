using System;

namespace Lesson4.Exceptions
{
    public class LessonDateException : Exception
    {
        public LessonDateException(string message)
        : base(message)
        {

        }
    }
}
