namespace CommandoGame.Models
{
    public class EnemyFactory
    {
        public List<Enemy> FactoryEnemies = new List<Enemy>();

        public Enemy CreateEnemy(string name)
        {
            Enemy enemy = new Enemy(name);
            FactoryEnemies.Add(enemy);
            return enemy;
        }
    }

    public class CommandoFactory
    {
        public List<Commando> FactoryCommandos = new List<Commando>();

        public Commando CreateCommando(string name, string codename, string type = "")
        {
            Commando commando;
            switch (type.ToLower())
            {
                case "":
                    commando = new Commando(name, codename);
                    break;

                case "air":
                    commando = new AirCommando(name, codename);
                    break;

                case "sea":
                    commando = new SeaCommando(name, codename);
                    break;

                default:
                    Console.WriteLine("Type Not Exist, assined as regular");
                    commando = new Commando(name, codename);
                    break;
            }
            FactoryCommandos.Add(commando);
            return commando;
        }
    }

    public class WeaponFactory
    {
        public List<Weapon> FactoryWeapons = new List<Weapon>();

        public Weapon CreateWeapon(string name, string creator, int capacity)
        {
            Weapon weapon = new Weapon(name, creator, capacity);
            FactoryWeapons.Add(weapon);
            return weapon;
        }
    }

    public class ColdToolsFactory
    {
        public List<ColdTools> FactoryColdTools = new List<ColdTools>();

        public ColdTools CreateStone(string name, string color, int weight)
        {
            ColdTools coldtool = new Rock(name, color, weight);
            FactoryColdTools.Add(coldtool);
            return coldtool;
        }
        public ColdTools CreateKnife(string name, string creator, string color, int weight, string kind)
        {
            ColdTools coldtool = new Knife(name, creator, color, weight, kind);
            FactoryColdTools.Add(coldtool);
            return coldtool;
        }
    }
}
