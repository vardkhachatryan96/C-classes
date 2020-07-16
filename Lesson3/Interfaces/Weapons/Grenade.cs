namespace Interfaces.Weapons
{
    /// <summary>
    /// Grenade model
    /// </summary>
    public class Grenade : IWeapon
    {
        /// <summary>
        /// Create grenade instance
        /// </summary>
        /// <param name="name">Grenade name</param>
        public Grenade(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// The grenade name
        /// </summary>
        public string Name { get; private set; }

        public void Shoot()
        {
            System.Console.WriteLine("Shoot grenade");
        }
    }
}
