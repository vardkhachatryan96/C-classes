using Interfaces.Weapons;

namespace Interfaces
{
    /// <summary>
    /// The start of the program
    /// </summary>
    public class ConsoleHost
    {
        /// <summary>
        /// Run the application
        /// </summary>
        public void Run()
        {
            var player = new Player("player1");

            var gun1 = new Gun("gun1");
            player.AddWeapon(gun1);

            player.AddWeapon(new Knife("knife"));

            var weapons = player.GetWeapons();

            foreach (var item in weapons)
            {
                if (item is Gun)
                {
                    var gun = (Gun)item;
                }
                item.Shoot();
            }
        }
    }
}