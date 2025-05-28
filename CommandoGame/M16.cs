using CommandoGame.Models;

namespace CommandoGame
{
    public class M16 : Weapon, IShootable
    {
        public M16(string name, string creator, int capacity) : base(name, creator, capacity)
        {

        }

        public void Shoot()
        {
            if (this.CheckAbility())
            {
                Console.WriteLine("Bang");
                this.Capacity--;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
            }
        }
    }
}
