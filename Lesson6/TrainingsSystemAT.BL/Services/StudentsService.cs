using System.Collections.Generic;
using TrainingsSystemAT.BL.Mappers;
using TrainingsSystemAT.BL.Models;
using TrainingsSystemAT.BL.ServicesAPI;
using TrainingsSystemAT.BL.Types;
using TrainingsSystemAT.DAL.Repositories;
using TrainingsSystemAT.DAL.RepositoriesAPI;

namespace TrainingsSystemAT.BL.Services
{
    public class StudentsService : IStudentsService
    {
        private readonly IStudentsRepository _studentsRepo;
        private readonly StudentsMapper _studentsMapper;

        public StudentsService()
        {
            this._studentsRepo = new StudentsRepository();
            this._studentsMapper = new StudentsMapper();
        }

        public IEnumerable<PersonModel> GetAllStudentsByDisciplineName(DisciplineType discipline)
        {
            return this._studentsMapper.Map(this._studentsRepo.GetAllStudentsByDisciplineId((int)discipline, (int)RoleType.Student));
        }

        public int GetAllStudentsCount()
        {
            return this._studentsRepo.GetAllStudentsCount();
        }
    }
}
