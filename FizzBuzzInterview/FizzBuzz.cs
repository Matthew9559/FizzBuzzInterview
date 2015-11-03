using System.Collections.Generic;

namespace FizzBuzzInterview
{
    public class FizzBuzz : FizzBuzzBase
    {
        public List<string> fizzBuzzList = new List<string>();

        public override List<string> DoFizzBuzz(int timesToRun)
        {
            if (timesToRun > 0 && timesToRun <= 2147483647)
            {
                for (int i = 1; i <= timesToRun; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        fizzBuzzList.Add("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        fizzBuzzList.Add("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        fizzBuzzList.Add("Buzz");
                    }
                    else
                    {
                        fizzBuzzList.Add(i.ToString());
                    }
                }
                return fizzBuzzList;
            }
            else
            {
                fizzBuzzList.Add("Please enter a value that is greater than 0 and less than 2147483648");
                return fizzBuzzList;
            }
        }
    }
}