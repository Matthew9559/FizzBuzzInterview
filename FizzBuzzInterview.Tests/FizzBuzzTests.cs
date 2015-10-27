using NUnit.Framework;

namespace FizzBuzzInterview.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void TestingBelowZeroAsInputFizzBuzz()
        {
            FizzBuzz belowZeroFizzBuzz = new FizzBuzz();

            var result = belowZeroFizzBuzz.DoFizzBuzz(-1);

            //Made check for null since fizzBuzzList would be empty if didn't hit else condition in FizzBuzz.cs
            Assert.That(result, Is.Null); 
        }

        [Test]
        public void TestingZeroAsInputFizzBuzz()
        {
            FizzBuzz zeroFizzBuzz = new FizzBuzz();

            var result = zeroFizzBuzz.DoFizzBuzz(0);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void TestingToFifteenAsInputFizzBuzz()
        {
            //Fifteen tests all current possible output scenarios
            FizzBuzz fifteenFizzBuzzExpected = new FizzBuzz();
            FizzBuzz fifteenFizzBuzzActual = new FizzBuzz();

            fifteenFizzBuzzExpected.fizzBuzzList.Add("1");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("2");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("Fizz");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("4");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("Buzz");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("Fizz");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("7");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("8");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("Fizz");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("Buzz");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("11");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("Fizz");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("13");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("14");
            fifteenFizzBuzzExpected.fizzBuzzList.Add("FizzBuzz");

            var resultExpected = fifteenFizzBuzzExpected.fizzBuzzList;
            var resultActual = fifteenFizzBuzzActual.DoFizzBuzz(15);

            CollectionAssert.AreEqual(resultExpected, resultActual);
        }
    }
}
