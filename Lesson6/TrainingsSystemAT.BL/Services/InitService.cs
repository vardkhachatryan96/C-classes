using TrainingsSystemAT.DAL.Data;

namespace TrainingsSystemAT.BL.Services
{
    public class InitService
    {
        public static void Init()
        {
            DataSeeder.Initialize();
        }
    }
}
