using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRobot
{
    public class NorthDirectionShould
    {
        [Test]
        public void RotateTowardsEast_When_InstructionIsRotateRight()
        {
            // Arrange
            var direction = new NorthDirection();

            // Act
            var finalDirection = direction.RotateRight();

            // Assert
            finalDirection.Should().BeOfType<EastDirection>();
        }
    }
}
