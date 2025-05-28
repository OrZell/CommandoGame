namespace CommandoGame.Models
{
    public class ColdTools
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Color;
        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        private int _Weight;
        public int Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

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



        public ColdTools(string name, string color, int weight)
        {
            this._Name = name;
            this._Color = color;
            this._Weight = weight;
            this._MaxHits = 5;
            this._CurrentHit = 0;
            this._Status = "Complete";
        }

        public void CheckAndUpadteStatus()
        {
            if (this._CurrentHit >= this._MaxHits)
            {
                this._Status = "Broken";
            }
        }

        public bool CheckAbility()
        {
            if (this._CurrentHit < this._MaxHits)
            {
                return true;
            }
            return false;
        }
    }
}
