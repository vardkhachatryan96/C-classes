namespace Interfaces.Weapons
{
    /// <summary>
    /// Gun model
    /// </summary>
    public class Gun : IWeapon
    {
        /// <summary>
        /// Create gun instance
        /// </summary>
        /// <param name="name">Gun name</param>
        public Gun(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// The gun name
        /// </summary>
        public string Name { get; private set; }

        public void Shoot()
        {
            System.Console.WriteLine("Shoot gun");
        }
    }
}
