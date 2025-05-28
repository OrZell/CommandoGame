namespace CommandoGame.Models
{
    public interface IShootable
    {
        public void Shoot();
        public int Capacity { get; set; }
    }

    public interface IBreakable
    {
        public void CheckAndUpdateStatus();
        public bool CheckAbility();
    }
}
