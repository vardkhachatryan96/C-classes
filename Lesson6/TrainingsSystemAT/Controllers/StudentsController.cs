using System;
using System.Collections.Generic;
using TrainingsSystemAT.BL.Services;
using TrainingsSystemAT.BL.ServicesAPI;
using TrainingsSystemAT.BL.Types;
using TrainingsSystemAT.Mappers;
using TrainingsSystemAT.Models;

namespace TrainingsSystemAT.Controllers
{
    public class StudentsController
    {
        private readonly IStudentsService _studentsService;

        public StudentsController()
        {
            this._studentsService = new StudentsService();
        }

        public int GetAllStudentsCount()
        {
            return this._studentsService.GetAllStudentsCount();
        }

        internal IEnumerable<StudentViewModel> GetAllStudentsByDisciplineName(DisciplineType discipline)
        {
            return StudentsMapper.Map(this._studentsService.GetAllStudentsByDisciplineName(discipline));
        }
    }
}
