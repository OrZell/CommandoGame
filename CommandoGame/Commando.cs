using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoGame.Models
{
    public class Commando
    {
        public string Name;
        public string Nickname;
        public string[] Tools = new string[5];
        public string Status;

        public Commando(string name, string nickname)
        {
            this.Name = name;
            this.Nickname = nickname;
        }

        public void Wlak()
        {
            this.Status = "Walk";
            Console.WriteLine("Walking");
        }

        public void Hide()
        {
            this.Status = "Hide";
            Console.WriteLine("Hiding");
        }

        public void Attack()
        {
            Console.WriteLine($"Commando Nickname: {this.Nickname} Attacking");
        }
    }
}
