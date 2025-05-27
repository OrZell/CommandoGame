using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandoGame.Models;

namespace CommandoGame.Models
{
    public class AirCommando : Commando
    {
        public AirCommando(string name, string codename) : base(name, codename)
        {

        }

        public void Parachute()
        {
            Console.WriteLine("Parachuting");
        }
    }
}
