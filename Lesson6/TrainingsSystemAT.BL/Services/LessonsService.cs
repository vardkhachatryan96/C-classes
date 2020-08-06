using System.Collections.Generic;
using TrainingsSystemAT.BL.Mappers;
using TrainingsSystemAT.BL.Models;
using TrainingsSystemAT.BL.ServicesAPI;
using TrainingsSystemAT.DAL.Repositories;
using TrainingsSystemAT.DAL.RepositoriesAPI;

namespace TrainingsSystemAT.BL.Services
{
    public class LessonsService : ILessonsService
    {
        private readonly ILessonsRepository _lessonsRepo;
        private readonly LessonsMapper _lessonsMapper;

        public LessonsService()
        {
            this._lessonsRepo = new LessonsRepository();
            this._lessonsMapper = new LessonsMapper();
        }

        public IEnumerable<LessonModel> GetEarliestLesson()
        {
            return this._lessonsMapper.Map(this._lessonsRepo.GetEarliestLesson());
        }
    }
}
