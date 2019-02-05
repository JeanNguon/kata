using FluentAssertions;
using NUnit.Framework;

namespace MarsRobot
{
    public class MarsRobotShould
    {
        [TestCase("", "0:0:N")]
        [TestCase("L", "0:0:W")]
        [TestCase("LL", "0:0:S")]
        [TestCase("LLL", "0:0:E")]
        [TestCase("LLLL", "0:0:N")]
        [TestCase("R", "0:0:E")]
        [TestCase("RR", "0:0:S")]
        [TestCase("RRR", "0:0:W")]
        [TestCase("RRRR", "0:0:N")]
        public void Rotate_When_InstructionsIsRotate(string instructions, string output)
        {
            // Arrange
            var robot = new Robot();

            // Act
            var direction = robot.Execute(instructions);

            // Assert
            direction.Should().Be(output);
        }
    }
}
