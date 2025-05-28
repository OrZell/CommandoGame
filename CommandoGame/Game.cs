namespace CommandoGame.Models
{
    public class Game
    {
        private CommandoFactory commandoFactory;
        private EnemyFactory enemyFactory;
        private WeaponFactory weaponFactory;
        private ColdToolsFactory coltoolsFactory;

        public Game()
        {
            this.commandoFactory = new CommandoFactory();
            this.enemyFactory = new EnemyFactory();
            this.weaponFactory = new WeaponFactory();
            this.coltoolsFactory = new ColdToolsFactory();
        }

        public Commando CommandoCreator(string name, string codename, string type="")
        {
            Commando commando = this.commandoFactory.CreateCommando(name, codename, type);
            return commando;
        }

        public Enemy EnemyCreator(string name)
        {
            Enemy enemy = this.enemyFactory.CreateEnemy(name);
            return enemy;
        }

        public Weapon WeaponCreator(string name, string creator, int capacity, string type)
        {
            Weapon weapon = this.weaponFactory.CreateWeapon(name, creator, capacity, type);
            return weapon;
        }

        public ColdTools KnifeCreator(string name, string creator, string color, int weight, string kind)
        {
            ColdTools knife = this.coltoolsFactory.CreateKnife(name, creator, color, weight, kind);
            return knife;
        }

        public ColdTools RockCreator(string name, string color, int weight)
        {
            ColdTools rock = this.coltoolsFactory.CreateStone(name, color, weight);
            return rock;
        }
    }
}
