using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoGame.Models
{
    public interface IShootable
    {
        public void Shoot();
        public int Capacity { get; set; }
    }

    public interface IBreakable
    {
        public string Status { get; set; }
        public int MaxHits { get; set; }
        public int CurrentHit { get; set; }
    }

    public interface IStabable
    {
        public string Kind { get; set; }
        public int Weight { get; set; }
        public string Status { get; set; }
    }
}
