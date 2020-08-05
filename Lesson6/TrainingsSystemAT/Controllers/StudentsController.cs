using System;
using System.Collections.Generic;
using TrainingsSystemAT.BL.Services;
using TrainingsSystemAT.BL.ServicesAPI;
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

        internal IEnumerable<Student> GetAllStudentsByDisciplineName(string disciplineName)
        {
            return StudentsMapper.Map(this._studentsService.GetAllStudentsByDisciplineName(disciplineName));
        }
    }
}
