using System.Collections.Generic;
using TrainingsSystemAT.BL.Services;
using TrainingsSystemAT.BL.ServicesAPI;
using TrainingsSystemAT.Mappers;
using TrainingsSystemAT.Models;

namespace TrainingsSystemAT.Controllers
{
    public class LessonsController
    {
        private readonly ILessonsService _lessonsService;
        private readonly LessonsMapper _lessonsMapper;

        public LessonsController()
        {
            this._lessonsService = new LessonsService();
            this._lessonsMapper = new LessonsMapper();
        }

        public IEnumerable<LessonViewModel> GetEarliestLesson()
        {
            return this._lessonsMapper.Map(this._lessonsService.GetEarliestLesson());
        }
    }
}
