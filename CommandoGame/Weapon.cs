using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CommandoGame.Models
{
    public class Weapon
    {
        public string Name;
        public string Creator;
        public int Capacity;

        public Weapon(string name, string creator, int capacity)
        {
            this.Name = name;
            this.Creator = creator;
            this.Capacity = capacity;
        }

        public void Shoot()
        {
            this.Capacity--;
            Console.WriteLine("Bang");
        }
    }
}
