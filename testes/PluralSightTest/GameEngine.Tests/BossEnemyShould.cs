using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GameEngine.Tests
{
    public class BossEnemyShould
    {
        [Fact]
        public void HaveCorrePower()
        {

            BossEnemy boss = new BossEnemy();

            Assert.Equal(166.667, boss.TotalSpecialAttackPower, 3);
        }
    }
}
