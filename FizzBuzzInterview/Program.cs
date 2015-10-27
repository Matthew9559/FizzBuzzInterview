using System;

namespace FizzBuzzInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz startFizzBuzz = new FizzBuzz();

            startFizzBuzz.DoFizzBuzz(100);

            foreach(var fizzBuzz in startFizzBuzz.fizzBuzzList)
            {
                Console.WriteLine(fizzBuzz);
            }

            Console.ReadLine();
        }
    }
}
