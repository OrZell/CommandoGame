using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoGame.Models
{
    public class Game
    {
        private CommandoFactory commandoFactory;
        private EnemyFactory enemyFactory;
        private WeaponFactory weaponFactory;

        public Game()
        {
            this.commandoFactory = new CommandoFactory();
            this.enemyFactory = new EnemyFactory();
            this.weaponFactory = new WeaponFactory();
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

        public Weapon WeaponCreator(string name, string creator, int capacity)
        {
            Weapon weapon = this.weaponFactory.CreateWeapon(name, creator, capacity);
            return weapon;
        }
    }
}
