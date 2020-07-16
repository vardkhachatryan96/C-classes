namespace Interfaces.Weapons
{
    /// <summary>
    /// Knife model
    /// </summary>
    public class Knife : IWeapon    
    {
        /// <summary>
        /// Create knife instance
        /// </summary>
        /// <param name="name">Knife name</param>
        public Knife(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// The knife name
        /// </summary>
        public string Name { get; private set; }

        public void Shoot()
        {
            System.Console.WriteLine("Shoot knife");
        }
    }
}
