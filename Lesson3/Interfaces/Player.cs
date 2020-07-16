using Interfaces.Weapons;
using System;
using System.Collections.Generic;

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
            weapons = new List<IWeapon>();
            weapons.Add(new Gun("Default"));
            weapons.Add(new Knife("Default"));
        }

        /// <summary>
        /// The player name
        /// </summary>
        public string Name { get; private set; }

        private readonly List<IWeapon> weapons;

        public ICollection<IWeapon> GetWeapons()
        {
            return this.weapons;
        }

        public void AddWeapon(IWeapon weapon)
        {
            this.weapons.Add(weapon);
        }
    }
}
