using Interfaces.Weapons;
using System.Collections.Generic;

namespace Interfaces
{
    /// <summary>
    /// The player model
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Player weapons
        /// </summary>
        private readonly List<IWeapon> weapons;

        /// <summary>
        /// Create player instance
        /// </summary>
        /// <param name="name">Player name</param>
        public Player(string name)
        {
            this.Name = name;

            // create default weapons
            weapons = new List<IWeapon>();
            weapons.Add(new Gun("Default"));
            weapons.Add(new Knife("Default"));
        }

        /// <summary>
        /// The player name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Get player weapons collection
        /// </summary>
        /// <returns></returns>
        public ICollection<IWeapon> GetWeapons()
        {
            return this.weapons;
        }

        /// <summary>
        /// Add weapon to player's collection
        /// </summary>
        /// <param name="weapon">The weapon to add</param>
        public void AddWeapon(IWeapon weapon)
        {
            this.weapons.Add(weapon);
        }
    }
}
