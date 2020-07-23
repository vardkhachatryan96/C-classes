using System;

namespace Lesson4.Exceptions
{
    public class AddingToLessonsCollectionException : Exception
    {
        public AddingToLessonsCollectionException(string message)
            : base(message)
        {

        }
    }
}
