using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoGame.Models
{
    public class Knife : ColdTools, IBreakable
    {
        public string Name;
        public string Kind;
        public string Creator;
        public string Color;
        public int Weight;
        public string Status { get; set; }
        public int MaxHits { get; set; }
        public int CurrentHit { get; set; }

        public Knife(string name, string creator, string color, int weight, string kind)
        {
            this.Name = name;
            this.Creator = creator;
            this.Color = color;
            this.Weight = weight;
            this.Status = "Complete";
            this.MaxHits = 5;
            this.CurrentHit = 0;
            this.Kind = kind;
        }

        public void Stab()
        {
            if (this.check())
            {
                Console.WriteLine("Stab");
                if (this.CurrentHit == this.MaxHits-1)
                {
                    this.Status = "Broken";
                }
            }
            else
            {
                Console.WriteLine("The Knife is Broken");
            }
        }

        public bool check()
        {
            if (this.CurrentHit < this.MaxHits)
            {
                return true;
            }
            return false;
        }
    }
}
