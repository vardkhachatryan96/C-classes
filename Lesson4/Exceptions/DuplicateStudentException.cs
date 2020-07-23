using System;

namespace Lesson4.Exceptions
{
    public class DuplicateStudentException : Exception
    {
        public DuplicateStudentException(string studentName)
            : base($"The student '{studentName}' already exists!")
        {

        }
    }
}
