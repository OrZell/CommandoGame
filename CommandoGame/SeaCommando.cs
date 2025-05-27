namespace CommandoGame.Models
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string codename) : base(name, codename)
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"SeaCommando CodeName - {this.CodeName} Attacking");
        }

        public void Swim()
        {
            Console.WriteLine("Swiming");
        }
    }
}
