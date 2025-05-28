using CommandoGame.Models;

namespace CommandoGame
{
    public class AK47 : Weapon , IShootable
    {
        public AK47(string name, string creator, int capacity) : base(name, creator, capacity)
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
