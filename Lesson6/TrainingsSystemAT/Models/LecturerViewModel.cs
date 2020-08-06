namespace TrainingsSystemAT.Models
{
    /// <summary>
    /// The Lecturer model
    /// </summary>
    public class LecturerViewModel : PersonViewModel
    {
        /// <summary>
        /// Init the lecturer
        /// </summary>
        /// <param name="name">The lecturer name</param>
        /// <param name="surname">The lecturer surname</param>
        public LecturerViewModel(string name, string surname)
            : base(name, surname)
        {

        }
    }
}
