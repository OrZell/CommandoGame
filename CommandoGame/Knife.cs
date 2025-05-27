using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoGame.Models
{
    public class Knife : IStabable
    {
        public string Name;
        public string Kind { get; set; }
        public string Creator;
        public string Color;
        public int Weight { get; set; }
        public string Status { get; set; }

        public Knife(string name, string creator, string color, int weight)
        {
            this.Name = name;
            this.Creator = creator;
            this.Color = color;
            this.Weight = weight;
            this.Status = "Complete";
        }

        public void Stab()
        {
            Console.WriteLine("Stab");
        }
    }
}
