using FluentAssertions;
using RocketTeamTeleporter.Maps;
using RocketTeamTeleporter.Models;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var map = new FirstTeleporterMap();
            var player = new Player(map);
            
            // Act
            var latestTeleporter = player.FindLatestTeleporter();

            // Assert
            latestTeleporter.Id.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var map = new SecondTeleporterMap();
            var player = new Player(map);

            // Act
            var latestTeleporter = player.FindLatestTeleporter();

            // Assert
            latestTeleporter.Id.Should().Be(5);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            var map = new ThirdTeleporterMap();
            var player = new Player(map);

            // Act
            var latestTeleporter = player.FindLatestTeleporter();

            // Assert
            latestTeleporter.Id.Should().Be(0);
        }
    }
}