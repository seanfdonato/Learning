using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GameEngine.Tests
{
    public class EnemyFactoryShould

    {
        [Fact]
        public void CreatNormalEnemyByDefault()
        {
            EnemyFactory ef = new EnemyFactory();

            Enemy e = ef.Create("Zombie");

            Assert.IsType<NormalEnemy>(e);
        }
        [Fact]
        public void CreatNormalEnemyByDefault_CastReturn()
        {
            EnemyFactory ef = new EnemyFactory();

            Enemy e = ef.Create("Zombie King", true); // Boss Enemy

            Enemy n = ef.Create("Zombie"); // Normal Enemy

            BossEnemy eb = Assert.IsType<BossEnemy>(e);

            Assert.Equal("Zombie King", eb.Name);

            Assert.IsAssignableFrom<Enemy>(n);

            Assert.NotSame(e, n);
        }

        [Fact]
        public void NotAllowNullName()
        {
            EnemyFactory ef = new EnemyFactory();

            Assert.Throws<ArgumentNullException>(() => ef.Create(null));
            string name;
            Assert.Throws<ArgumentNullException>(nameof(name),() => ef.Create(null));
        }
    }
}
