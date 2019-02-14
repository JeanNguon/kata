using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace MarsRobot
{
    public class MarsRobotShould
    {
        private Dictionary<string, IDirection> directionConversion = new Dictionary<string, IDirection>
        {
            { "N", new NorthDirection() },
            { "S", new SouthDirection() },
            { "E", new EastDirection() },
            { "W", new WestDirection() },
        };

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
            var robot = new Robot(new NorthDirection(), Position.Origin);

            // Act
            var positionAndOrientation = robot.Execute(instructions);

            // Assert
            positionAndOrientation.Should().Be(output);
        }

        [TestCase("N", "F", "0:1:N")]
        [TestCase("S", "F", "0:-1:S")]
        [TestCase("E", "F", "1:0:E")]
        [TestCase("W", "F", "-1:0:W")]
        public void MoveForward_When_InstructionIsForward(string originalDirection, string instruction, string output)
        {
            // Arrange
            var robot = new Robot(this.directionConversion[originalDirection], Position.Origin);

            // Act 
            var position = robot.Execute(instruction);

            // Assert
            position.Should().Be(output);
        }

        [TestCase("N", "B", "0:-1:N")]
        //[TestCase("S", "B", "0:1:S")]
        //[TestCase("E", "B", "-1:0:E")]
        //[TestCase("W", "B", "1:0:W")]
        public void MoveBackward_When_InstructionIsForward(string originalDirection, string instruction, string output)
        {
            // Arrange
            var robot = new Robot(this.directionConversion[originalDirection], Position.Origin);

            // Act 
            var position = robot.Execute(instruction);

            // Assert
            position.Should().Be(output);
        }
    }
}
