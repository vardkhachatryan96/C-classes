using System.Collections.Generic;
using TrainingsSystemAT.BL.ServicesAPI;
using TrainingsSystemAT.DAL.Models;
using TrainingsSystemAT.DAL.Repositories;
using TrainingsSystemAT.DAL.RepositoriesAPI;

namespace TrainingsSystemAT.BL.Services
{
    public class StudentsService : IStudentsService
    {
        private readonly IStudentsRepository _studentsRepo;

        public StudentsService()
        {
            this._studentsRepo = new StudentsRepository();
        }

        public IEnumerable<Person> GetAllStudentsByDisciplineName(string disciplineName)
        {
            return this._studentsRepo.GetAllStudentsByDisciplineName(disciplineName);
        }

        public int GetAllStudentsCount()
        {
            return this._studentsRepo.GetAllStudentsCount();
        }
    }
}
