namespace CommandoGame.Models
{
    public class Enemy
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Status;
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public int Health;


        public Enemy(string name)
        {
            this._Name = name;
            this._Status = "Alive";
            this.Health = 100;

        }

        public void Scream()
        {
            Console.WriteLine("I'm Enemy");
        }

        public void CheckHealthAndUpdateStatus()
        {
            if (this.Health <= 0 && this.Status == "Alive")
            {
                this.Status = "Dead";
            }
            else
            {
                Console.WriteLine($"The Enemy {this.Name} is Dead");
            }
        }
    }
}
