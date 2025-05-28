namespace CommandoGame.Models
{
    public interface IShootable
    {
        public void Shoot();
    }

    public interface IBreakable
    {
        public void CheckAndUpdateStatus();
        public bool CheckAbility();
    }
}
