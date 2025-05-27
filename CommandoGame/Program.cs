using CommandoGame.Models;

namespace CommandoGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Commando Soldier = new Commando("Jack", "Jack_Reacher");
            Soldier.Wlak(); Soldier.Hide(); Soldier.Attack();

            Weapon Gun = new Weapon("Glock-17", "Glock", 15);
            Gun.Shoot();
        }
    }
}