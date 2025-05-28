namespace CommandoGame.Models
{
    public class Rock : ColdTools
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
                this.CheckAndUpdateStatus();
            }
            else
            {
                Console.WriteLine("The Rock is Broken");
            }
        }
    }
}
