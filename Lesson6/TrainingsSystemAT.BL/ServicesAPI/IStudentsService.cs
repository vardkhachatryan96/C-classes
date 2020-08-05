using System.Collections.Generic;
using TrainingsSystemAT.DAL.Models;

namespace TrainingsSystemAT.BL.ServicesAPI
{
    public interface IStudentsService 
    {
        int GetAllStudentsCount();
        
        IEnumerable<Person> GetAllStudentsByDisciplineName(string disciplineName);
    }
}
