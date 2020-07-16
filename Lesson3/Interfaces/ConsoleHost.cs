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
            // create player
            var player = new Player("player1");

            // add a gun to player weapon collection
            player.AddWeapon(new Gun("gun1"));

            // add a knife to player weapon collection
            player.AddWeapon(new Knife("knife"));

            // get player weapons
            var weapons = player.GetWeapons();

            foreach (var item in weapons)
            {
                if (item is Gun gun)
                {
                    var gunName = gun.Name;
                    System.Console.WriteLine(gunName);
                }

                item.Shoot();
            }
        }
    }
}