namespace CommandoGame.Models
{
    public class Commando
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _CodeName;
        public string CodeName
        {
            get { return _CodeName; }
            set { _CodeName = value; }
        }

        public string[] Tools = new string[5];
        public string Status;

        public Commando(string name, string codename)
        {
            this._Name = name;
            this._CodeName = codename;
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

        public virtual void Attack()
        {
            Console.WriteLine($"Commando CodeName: {this.CodeName} Attacking");
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
