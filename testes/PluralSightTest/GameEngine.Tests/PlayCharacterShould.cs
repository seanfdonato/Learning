using GameEngine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PluralSightTestTest
{
    public class PlayCharacterShould
    {
        [Fact]
        public void BeInexperienceWhenNew()
        {
            //Arrange
            var player = new PlayerCharacter();

            //Assert
            Assert.True(player.IsNoob);
        }
        [Fact]
        public void CalculateFullName()
        {
            //Arrange
            var player = new PlayerCharacter();

            //ACT
            player.FirstName = "Sarah";
            player.LastName = "Smith";

            //Assert
            Assert.Equal("Sarah Smith", player.FullName);
        }
        [Fact]
        public void CalculateFullName_IgnoreCase()
        {
            //Arrange
            var player = new PlayerCharacter();

            //ACT
            player.FirstName = "SARAH";
            player.LastName = "SMITH";

            //Assert
            Assert.Equal("Sarah Smith", player.FullName, ignoreCase: true);
        }
        [Fact]
        public void HaveFullNameStartingWithFirstName()
        {
            //Arrange
            var player = new PlayerCharacter();

            //ACT
            player.FirstName = "Sarah";
            player.LastName = "Smith";

            //Assert
            Assert.StartsWith("Sarah", player.FullName);
        }
        [Fact]
        public void HaveFullNameEndingWithLastName()
        {
            //Arrange
            var player = new PlayerCharacter();

            //ACT
            player.FirstName = "Sarah";
            player.LastName = "Smith";

            //Assert
            Assert.EndsWith("Smith", player.FullName);
        }
        [Fact]
        public void CalculateFullName_SubstringAssert()
        {
            //Arrange
            var player = new PlayerCharacter();

            //ACT
            player.FirstName = "Sarah";
            player.LastName = "Smith";

            //Assert
            Assert.Contains("ah Sm", player.FullName);
        }
        [Fact]
        public void CalculateFullName_WithTitleCase()
        {
            //Arrange
            var player = new PlayerCharacter();

            //ACT
            player.FirstName = "Sarah";
            player.LastName = "Smith";

            //Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", player.FullName);
        }
        [Fact]
        public void StartWithDefaultHealth()
        {
            //Arrange
            var player = new PlayerCharacter();

            //Assert
            Assert.Equal(100, player.Health);
        }
        [Fact]
        public void IncreaseHealthAfterSleeping()
        {
            //Arrange
            var player = new PlayerCharacter();

            //ACT
            player.Sleep();

            //Assert
            Assert.InRange(player.Health, 101, 200);
        }
        [Fact]
        public void NotHaveAnameByDeafault()
        {
            //Arrange
            var player = new PlayerCharacter();

            //Assert
            Assert.Null(player.Nickname);
        }
        [Fact]
        public void HaveAlongBow()
        {
            //Arrange
            var player = new PlayerCharacter();

            Assert.Contains("Long Bow", player.Weapons);
        }
        [Fact]
        public void DoNotHaveStaffWander()
        {
            //Arrange
            var player = new PlayerCharacter();

            Assert.DoesNotContain("Staff of Wonder", player.Weapons);
        }
        [Fact]
        public void HaveAtLeastOneKindOfSword()
        {
            //Arrange
            var player = new PlayerCharacter();

            Assert.DoesNotContain(player.Weapons, weapons => weapons.Contains("Sword"));
        }
        [Fact]
        public void HaveNoEMprtyDefaultWeapons()
        {
            var player = new PlayerCharacter();

            Assert.All(player.Weapons, weapon => Assert.False(string.IsNullOrWhiteSpace(weapon)));


        }
        [Fact]
        public void RaiseSlepEvent()
        {
            var player = new PlayerCharacter();

            Assert.Raises<EventArgs>(
                handler => player.PlayerSlept += handler,
                handler => player.PlayerSlept += handler,
                () => player.Sleep());
        }
    }
}
