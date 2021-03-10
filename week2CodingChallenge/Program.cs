using System;

namespace week2CodingChallenge
{
    /*
        Print the numbers 1 to 1000 to the console. 
        Print them in groups of 10 per line with a space separating each number.  
        When the number is multiple of three, print “sweet” instead of the number on the console.  
        If the number is a multiple of five, print “salty” (instead of the number) to the console.  
        For numbers which are multiples of three and five, print “sweet’nSalty” to the console (instead of the number).  
        After the numbers have all been printed, print out how many sweet’s, how many salty’s, and how many sweet’nSalty’s. 
        These are three separate groups, so sweet’nSalty does not increment sweet or salty (and vice versa). 
    */

    class Program
    {
        static void Main(string[] args)
        {
            // Init variables
            var start = 1;
            var end = 1000;
            var firstWord = "sweet";
            var secondWord = "salty";
            var thirdWord = "sweet'nsalty";
            var firstNum = 3;
            var secondNum = 5;
            var firstWordCounter = 0;
            var secondWordCounter = 0;
            var thirdWordCounter = 0;

            // loop
            for(int i = start; i < end + 1; i += 1)
            {
                // Check if the index is a multiple of first and second number, if so then print third word and increment third counter
                if(i % firstNum == 0 && i % secondNum == 0)
                {
                    Console.Write(thirdWord + " ");
                    thirdWordCounter += 1;
                }

                // Check if index is only a multiple of the first number
                else if(i % firstNum == 0)
                {
                    Console.Write(firstWord + " ");
                    firstWordCounter +=1;
                }

                // Check if index is only a multiple of the second number
                else if(i % secondNum == 0)
                {
                    Console.Write(secondWord + " ");
                    secondWordCounter += 1;
                }

                // else print the number
                else
                {
                    Console.Write(i + " ");
                }

                // check to see if ten numbers have been reached to print new line
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            // Print counters
            Console.WriteLine();
            Console.WriteLine("Number of times " + firstWord + " appears: " + firstWordCounter);
            Console.WriteLine("Number of times " + secondWord + " appears: " + secondWordCounter);
            Console.WriteLine("Number of times " + thirdWord + " appears: " + thirdWordCounter);
        }

    }
}
