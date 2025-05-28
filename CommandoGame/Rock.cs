namespace CommandoGame.Models
{
    public class Rock : ColdTools, IBreakable
    {
        public Rock(string name, string color, int weight) : base(name, color, weight)
        {

        }

        public void Throw()
        {
            if (this.CheckAbility())
            {
                Console.WriteLine("Throw Rock");
                this.CurrentHit++;
                this.CheckAndUpadteStatus();
            }
            else
            {
                Console.WriteLine("The Rock is Broken");
            }
        }
    }
}
