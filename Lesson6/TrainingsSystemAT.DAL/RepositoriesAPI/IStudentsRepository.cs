using System.Collections.Generic;
using TrainingsSystemAT.DAL.Models;

namespace TrainingsSystemAT.DAL.RepositoriesAPI
{
    public interface IStudentsRepository
    {
        int GetAllStudentsCount();

        IEnumerable<Person> GetAllStudentsByDisciplineId(int disciplineId, int roleId);
    }
}
