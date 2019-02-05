using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class MarsRobotTests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [TestCase('N', 'R', 'E')]
        [TestCase('N', 'L', 'W')]
        [TestCase('E', 'R', 'S')]
        [TestCase('E', 'L', 'N')]
        [TestCase('S', 'L', 'E')]
        [TestCase('S', 'R', 'W')]
        public void Given_RobotHeadingNorth_When_RotateLeft_Then_RobotHeadingIsWest(char initialDirection, char rotationDirection, char expectedDirection)
        {
            // Arrange
            var robotCoordinates = new Robot(initialDirection);

            // Act
            var newCoordinates = robotCoordinates.Move(rotationDirection);

            // Assert
            newCoordinates.Heading.Should().Be(expectedDirection);
        }

        
        public class Robot
        {
            private List<RotationApplier> rotationAppliers = new List<RotationApplier>
            {
                new RotationApplier('N', 'L', 'W'),
                new RotationApplier('N', 'R', 'E'),
                new RotationApplier('E', 'L', 'N'),
                new RotationApplier('E', 'R', 'S'),
                new RotationApplier('S', 'L', 'E'),
                new RotationApplier('S', 'R', 'W'),
            };

            public char Heading { get; }

            public Robot(char heading)
            {
                Heading = heading;
            }

            public Robot Move(char rotationDirection)
            {
                var newHeading = this.rotationAppliers
                    .First(x => x.CanRotate(this.Heading, rotationDirection))
                    .Rotate(this.Heading, rotationDirection);

                return new Robot(newHeading);
            }
        }

        public class RotationApplier
        {
            private char heading;
            private char rotation;
            private char expectedDirection;

            public RotationApplier(char heading, char rotation, char expectedDirection)
            {
                this.heading = heading;
                this.rotation = rotation;
                this.expectedDirection = expectedDirection;

            }

            public bool CanRotate(char heading, char rotation)
            {
                return heading == this.heading && rotation == this.rotation;
            }

            public char Rotate(char heading, char rotation)
            {
                if (!this.CanRotate(heading, rotation))
                {
                    throw new InvalidOperationException();
                }

                return expectedDirection;
            }
        }
    }
}