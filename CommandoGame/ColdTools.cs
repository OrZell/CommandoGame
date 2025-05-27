using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoGame.Models
{
    public class ColdTools
    {
        private string _Status;
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private int _MaxHits;
        public int MaxHits
        {
            get { return _MaxHits; }
            set { _MaxHits = value; }
        }

        private int _CurrentHit;
        public int CurrentHit
        {
            get { return _CurrentHit; }
            set { _CurrentHit = value; }
        }
    }
}
