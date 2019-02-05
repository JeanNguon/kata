using NUnit.Framework;
using System;

namespace FizzBuzzQixKata
{
    [TestFixture]
    public class FizzBuzzQixTests
    {
        private string DivisibleByThree(int input)
        {
            if(input > 0 && input % 3 == 0)
            {
                return "Fizz";
            }

            return "";
        }

        private string DivisibleByFive(int input)
        {
            if (input > 0 && input % 5 == 0)
            {
                return "Buzz";
            }

            return "";
        }

        private string ContainsThree(int input)
        {
            return input.ToString().Contains("3") ? "Fizz" : "";
        }

        private string ContainsFive(int input)
        {
            return input.ToString().Contains("5") ? "Buzz" : "";
        }

        private string Fizzbuzz(int input)
        {
            var text = "";

            if (input == 0) return "0";

            
                text = string.Concat(text, this.DivisibleByThree(input));
                text = string.Concat(text, this.DivisibleByFive(input));
                text = string.Concat(text, this.ContainsThree(input));
                text = string.Concat(text, this.ContainsFive(input));


            Console.WriteLine(text);
            return text;
        }

        [Test]
        public void GivenZeroThenReturnsZero()
        {
            var result = this.Fizzbuzz(0);

            Assert.That(result == "0");
        }

        [Test]
        public void GivenThreeThenReturnsFizzFizz()
        {
            var result = this.Fizzbuzz(3);

            Assert.That(result == "FizzFizz");
        }

        [Test]
        public void GivenFiveThenReturnsBuzz()
        {
            var result = this.Fizzbuzz(5);

            Assert.That(result == "Buzz");
        }

        [Test]
        public void GivenSixThenReturnsFizz()
        {
            var result = this.Fizzbuzz(6);
            Assert.That(result == "Fizz");
        }

        [Test]
        public void GivenTenThenReturnsBuzz()
        {
            var result = this.Fizzbuzz(10);

            Assert.That(result == "Buzz");
        }

        [Test]
        public void GivenThirteenThenReturnsFizz()
        {
            var result = this.Fizzbuzz(13);

            Assert.That(result == "Fizz");
        }

        [Test]
        public void GivenFifteenThenReturnsFizzBuzz()
        {
            var result = this.Fizzbuzz(15);

            Assert.That(result == "FizzBuzz");
        }
    }
}
