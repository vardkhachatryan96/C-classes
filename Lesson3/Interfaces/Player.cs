namespace Interfaces
{
    /// <summary>
    /// The player model
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Create player instance
        /// </summary>
        /// <param name="name">Player name</param>
        public Player(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// The player name
        /// </summary>
        public string Name { get; private set; }
    }
}
