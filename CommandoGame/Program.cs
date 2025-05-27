using CommandoGame.Models;

namespace CommandoGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Commando Soldier = new Commando("Jack Reacher", "Jacky");
            SeaCommando SeaSoldier = new SeaCommando("Tim Roth", "Timmy");
            AirCommando AirSoldier = new AirCommando("Jhonthan Miller", "Jhonny");

            Commando[] Army = new Commando[3];
            Army[0] = Soldier; Army[1] = SeaSoldier; Army[2] = AirSoldier;

            foreach (Commando item in Army)
            {
                item.Attack();
            }
        }
    }
}