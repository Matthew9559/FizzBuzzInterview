using NUnit.Framework;

namespace FizzBuzzInterview.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void TestingBelowZeroAsInputFizzBuzz()
        {
            FizzBuzz belowZeroFizzBuzzExpected = new FizzBuzz();
            FizzBuzz belowZeroFizzBuzzActual = new FizzBuzz();

            belowZeroFizzBuzzExpected.fizzBuzzList.Add("Please enter a value that is greater than 0 and less than 2147483648");

             var resultExpectedBelowZero = belowZeroFizzBuzzExpected.fizzBuzzList;
             var resultActualBelowZero = belowZeroFizzBuzzActual.DoFizzBuzz(-10);

            CollectionAssert.AreEqual(resultExpectedBelowZero, resultActualBelowZero); 
        }

        [Test]
        public void TestingZeroAsInputFizzBuzz()
        {
            FizzBuzz zeroFizzBuzzExpected = new FizzBuzz();
            FizzBuzz zeroFizzBuzzActual = new FizzBuzz();

            zeroFizzBuzzExpected.fizzBuzzList.Add("Please enter a value that is greater than 0 and less than 2147483648");

            var resultExpectedZero = zeroFizzBuzzExpected.fizzBuzzList;
            var resultActualZero = zeroFizzBuzzActual.DoFizzBuzz(0);

            CollectionAssert.AreEqual(resultExpectedZero, resultActualZero);
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
