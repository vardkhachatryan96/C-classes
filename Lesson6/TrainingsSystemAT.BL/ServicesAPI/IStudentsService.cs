using System.Collections.Generic;
using TrainingsSystemAT.BL.Models;
using TrainingsSystemAT.BL.Types;

namespace TrainingsSystemAT.BL.ServicesAPI
{
    public interface IStudentsService 
    {
        int GetAllStudentsCount();
        
        IEnumerable<PersonModel> GetAllStudentsByDisciplineName(DisciplineType disciplineName);
    }
}
