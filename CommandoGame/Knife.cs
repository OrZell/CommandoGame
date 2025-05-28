namespace CommandoGame.Models
{
    public class Knife : ColdTools
    {
        public string Kind;
        public string Creator;

        public Knife(string name, string creator, string color, int weight, string kind) : base(name, color, weight)
        {
            this.Name = name;
            this.Creator = creator;
            this.Kind = kind;
        }

        public void Stab()
        {
            if (this.CheckAbility())
            {
                Console.WriteLine("Stab");
                this.CurrentHit++;
                this.CheckAndUpdateStatus();
            }
            else
            {
                Console.WriteLine("The Knife Is Broken");
            }
        }
    }
}
