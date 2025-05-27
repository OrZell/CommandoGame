using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoGame.Models
{
    public class Rock : IBreakable
    {
        public string Status { get; set; }
        public int MaxHits { get; set; }
        public int CurrentHit { get; set; }

        public string Name;
        public int Weight;
        public string Color;

        public Rock(string name, string color, int weight)
        {
            this.Name = name;
            this.Color = color;
            this.Weight = weight;
            this.Status = "Complete";
            this.MaxHits = 5;
            this.CurrentHit = 0;
        }

        public void Throw()
        {
            if (this.Check())
            {
                Console.WriteLine("Throw Rck");
                this.CurrentHit++;
                if (this.CurrentHit == this.MaxHits-1)
                {
                    this.Status = "Broken";
                }
            }
            else
            {
                Console.WriteLine("The Rock is Broken");
            }
        }

        private bool Check()
        {
            if (this.CurrentHit < this.MaxHits)
            {
                return true;
            }
            return false;
        }
    }
}
