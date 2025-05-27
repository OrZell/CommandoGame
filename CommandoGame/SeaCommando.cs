using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandoGame.Models;

namespace CommandoGame.Models
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string codename) : base(name, codename)
        {

        }

        public void Attack()
        {
            Console.WriteLine($"SeaCommando CodeName - {this.CodeName} Attacking");
        }

        public void Swim()
        {
            Console.WriteLine("Swiming");
        }
    }
}
