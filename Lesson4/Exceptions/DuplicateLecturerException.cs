using System;

namespace Lesson4.Exceptions
{
    public class DuplicateLecturerException : Exception
    {
        public DuplicateLecturerException(string studentName)
            : base($"The student '{studentName}' already exists!")
        {

        }
    }
}
