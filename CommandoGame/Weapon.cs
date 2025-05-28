namespace CommandoGame.Models
{
    public class Weapon
    {
        public string Name;
        public string Creator;
        public int Capacity;

        public Weapon(string name, string creator, int capacity)
        {
            this.Name = name;
            this.Creator = creator;
            this.Capacity = capacity;
        }

        public bool CheckAbility()
        {
             return this.Capacity > 1 ? true : false;
        }
    }
}
