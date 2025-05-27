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
    }
}
