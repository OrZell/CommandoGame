using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoGame.Models
{
    public class Commando
    {
        private string Name;
        private string CodeName { get; set; }
        public string[] Tools = new string[5];
        public string Status;

        public Commando(string name, string codename)
        {
            this.Name = name;
            this.CodeName = codename;
            this.Status = "Stand";
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
            Console.WriteLine($"Commando Nickname: {this.CodeName} Attacking");
        }

        public void SayName(string commanderRank)
        {
            if (commanderRank == "General")
            {
                Console.WriteLine(this.Name);
            }
            else if (commanderRank == "Colonel")
            {
                Console.WriteLine(this.CodeName);
            }
            else
            {
                Console.WriteLine("Classified Information");
            }
        }
    }
}
