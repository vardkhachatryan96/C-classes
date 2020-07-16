namespace Collections.LinkedLists
{
    /// <summary>
    /// The playlist item
    /// </summary>
    public class PlaylistItem
    {
        /// <summary>
        /// Create Playlit Item instance
        /// </summary>
        /// <param name="name">The playlist item name</param>
        public PlaylistItem(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// The playlist item name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The playlist item author
        /// </summary>
        public string Author { get; set; }
    }
}
