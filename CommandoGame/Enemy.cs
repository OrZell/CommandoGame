using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoGame.Models
{
    public class Enemy
    {
        private string Name;
        public int Health;
        private string Status;

        public Enemy(string name)
        {
            this.Name = name;
            this.Health = 100;
            this.Status = "Alive";
        }

        public void Scream()
        {
            Console.WriteLine("I'm Enemy");
        }
    }
}
