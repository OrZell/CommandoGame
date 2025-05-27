using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoGame.Models
{
    interface IShootable
    {
        public void Shoot();
        public int Capacity { get; set; }
    }

    interface IBreakable
    {
        public string Status { get; set; }
        public int MaxHits { get; set; }
        public int CurrentHit { get; set; }
    }
}
