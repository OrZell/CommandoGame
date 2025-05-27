namespace CommandoGame.Models
{
    public class AirCommando : Commando
    {
        public AirCommando(string name, string codename) : base(name, codename)
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"AirCommando CodeName - {this.CodeName} Attacking");
        }

        public void Parachute()
        {
            Console.WriteLine("Parachuting");
        }
    }
}
