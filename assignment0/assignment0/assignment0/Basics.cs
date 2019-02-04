using System;

namespace Assignment0
{
    public class Basics
    {
        public void PrintHelloWorld()
        {
            Console.WriteLine("HelloWorld");
        }

        public int GetSum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        // Read if-else construct
        public int GetLargerNumber(int first, int second)
        {
            int LargerNumber = 0;
            if( first <= second)
            {
                LargerNumber = second;
            }
            else
            {
                LargerNumber = first;
            }

            return LargerNumber;
        }

        // Read nested if-else construct
        public int LargestNumber(int first, int second, int third)
        {
            int LargestNumber = 0;
            if( first <= second )
            {
                if( second <= third)
                {
                    LargestNumber = third;
                }
                else
                {
                    LargestNumber = second;
                }
            }
            else
            {
                LargestNumber = first;
            }
            return LargestNumber;
        }

        // Go through arrays in java and simple for loop and enhanced for loop
        public void PrintArray(int[] array)
        {
            Console.WriteLine("The array value is :");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
        }

        public int GetSumOfArrayElements(int[] array, int n)
        {
            int SumValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                SumValue = SumValue + array[i];
            }
            return SumValue;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1 || (number > 2 || number % 2 == 0) || (number > 3 || number % 3 == 0) || (number > 5 || number % 5 == 0) || (number > 7 || number % 7 == 0))
                return false;

            return true;
        }

        // Say, first = 5 and second = 10, this function should print "5 6 7 8 9 10"
        public int[] GetArrayOfRangeOfNumbers(int first, int second)
        {
            int Length = second - first;
            int[] RangeValues = new int[Length + 1];
            RangeValues[0] = first;
            for (int i = 1; i < RangeValues.Length; i++)
            {
                RangeValues[i] = first + 1;
                first += 1;
            }
            return RangeValues;
        }

        public int GetFactorial(int n)
        {
            int Factorial = 0;
            int temp = 0;
            if (n == 0 || n == 1)
                return Factorial = 1;
            for(int i=1; i<n; i++)
            {
                if(temp ==0)
                {
                    temp = n * (n - i);
                    Factorial = temp;
                }
                else
                {
                    Factorial = temp * (n - i);
                    temp = Factorial;
                }

            }
            return Factorial;
        }

        public int GetFactorialWithoutLoop(int n)
        {
            if (n <= 1)
                return 1;
            return n * GetFactorialWithoutLoop(n - 1);

        }

        // 1234 should give 4321
        public int ReverseDigits(int n)
        {
            int ReversedDigits = 0;
            int LastNumber = 0;
            while(n > 0)
            {
                LastNumber = n % 10;
                ReversedDigits = (ReversedDigits * 10) + LastNumber;
                n = n / 10;
            }
            return ReversedDigits;
        }

        // In between 1 to 10, the prime numbers are 1, 2, 3, 5, 7
        public int[] PrimeNumbersInARange(int lowerLimit, int upperLimit)
        {
            int[] PrimeNumbers = new int[upperLimit];
            int j = 0;
            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                if ((i != 2 && i % 2 == 0) || (i != 3 && i % 3 == 0) || (i != 5 && i % 5 == 0) || (i != 7 && i % 7 == 0))
                {

                }
                else
                {
                    PrimeNumbers[j] = i;
                    j += 1;
                }

            }
            return PrimeNumbers;
        }

        public int FindNumberOfOccurences(int[] array, int n)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (n == array[i]) 
                {
                    count++;
                }
            }
            return count;
        }

        public static void Main(String[] args)
        {
            int[] value = new int[5] { 1, 2, 3, 4, 5 };
            Basics obj = new Basics();

            //PrintHelloWorld
            Console.WriteLine("****Start HelloWord****");
            obj.PrintHelloWorld();
            Console.WriteLine("****End HelloWord****");
            Console.WriteLine("\n");

            //GetSum
            Console.WriteLine("****Start GetSum****");
            Console.WriteLine(obj.GetSum(10, 20));
            Console.WriteLine("****End GetSum****");
            Console.WriteLine("\n");

            //GetLargerNumber
            Console.WriteLine("****Start GetLargerNumber****");
            Console.WriteLine(obj.GetLargerNumber(10,20));
            Console.WriteLine("****End GetLargerNumber****");
            Console.WriteLine("\n");

            //LargestNumber
            Console.WriteLine("****Start LargestNumber****");
            Console.WriteLine(obj.LargestNumber(10, 20, 30));
            Console.WriteLine("****End LargestNumber****");
            Console.WriteLine("\n");

            //PrintArray
            Console.WriteLine("****Start PrintArray****");
            obj.PrintArray(value);
            Console.WriteLine("****End PrintArray****");
            Console.WriteLine("\n");

            //GetSumOfArrayElements
            Console.WriteLine("****Start GetSumOfArrayElements****");
            Console.WriteLine(obj.GetSumOfArrayElements(value, 5));
            Console.WriteLine("****End GetSumOfArrayElements****");
            Console.WriteLine("\n");

            //IsPrime Number
            Console.WriteLine("****Start IsPrime Number****");
            if (obj.IsPrime(5))
                Console.WriteLine("Its Prime Number: True");
            else
                Console.WriteLine("Its Prime Number: False");
            Console.WriteLine("****End IsPrime Number****");
            Console.WriteLine("\n");

            //GetArrayOfRangeOfNumbers
            Console.WriteLine("****Start GetArrayOfRangeOfNumbers****");
            foreach (int num in obj.GetArrayOfRangeOfNumbers(3, 9))
            {
                if (num != 0)
                    Console.WriteLine(num);
            }
            Console.WriteLine("****End GetArrayOfRangeOfNumbers****");
            Console.WriteLine("\n");

            //Factorial Number
            Console.WriteLine("****Start Factorial****");
            Console.WriteLine(obj.GetFactorial(3));
            Console.WriteLine("****End Factorial****");
            Console.WriteLine("\n");

            //Factorial Number without Looping
            Console.WriteLine("****Start Factorial Without Looping****");
            Console.WriteLine(obj.GetFactorialWithoutLoop(3));
            Console.WriteLine("****End Factorial Without Looping****");
            Console.WriteLine("\n");

            //ReverseDigits 
            Console.WriteLine("****Start ReverseDigits****");
            Console.WriteLine(obj.ReverseDigits(1234));
            Console.WriteLine("****End ReverseDigits****");
            Console.WriteLine("\n");

            // PrimeNumbersInARange
            Console.WriteLine("****Start PrimeNumbersInARange****");
            foreach (int num in obj.PrimeNumbersInARange(0, 10))
            {
                if (num != 0)
                    Console.WriteLine(num);
            }
            Console.WriteLine("****End PrimeNumbersInARange****");
            Console.WriteLine("\n");

            //FindNumberOfOccurences
            Console.WriteLine("****Start FindNumberOfOccurences****");
            int[] Occurences = new int[] { 1, 1, 1 };
            Console.WriteLine(obj.FindNumberOfOccurences(Occurences, 1));
            Console.WriteLine("****End FindNumberOfOccurences****");
            Console.WriteLine("\n");

            //FindFirstOccurence
            Console.WriteLine("****Start FindFirstOccurence****");
            int[] FirstOccure = new int[] { 2, 2, 1 };
            Console.WriteLine(obj.FindFirstOccurence(FirstOccure, 1));
            Console.WriteLine("****End FindFirstOccurence****");
            Console.WriteLine("\n");

            //PrintRhombus
            Console.WriteLine("****Start PrintRhombus****");
            obj.PrintRhombus(5);
            Console.WriteLine("****End PrintRhombus****");
            Console.WriteLine("\n");

            //GetNumberLessThanTenInWords
            Console.WriteLine("****Start GetNumberLessThanTenInWords****");
            Console.WriteLine(obj.GetNumberLessThanTenInWords(6));
            Console.WriteLine("****End GetNumberLessThanTenInWords****");
            Console.WriteLine("\n");

            //GetNumberInWords
            Console.WriteLine("****Start GetNumberInWords****");
            Console.WriteLine(obj.GetNumberInWords(6715));
            Console.WriteLine("****End GetNumberInWords****");
            Console.WriteLine("\n");

            //PrintTrianglePointingRight
            Console.WriteLine("****Start PrintTrianglePointingRight****");
            obj.PrintTrianglePointingRight(10);
            Console.WriteLine("****End PrintTrianglePointingRight****");
            Console.WriteLine("\n");

            Console.ReadLine();

        }

        public int FindFirstOccurence(int[] array, int number)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                if (number == array[i]) 
                {
                    return count = i;
                }
                else
                {
                    count = -1;
                }
            }

            return count;
        }

        public void PrintRhombus(int size)
        {
            for (int i = 0; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine("\n");
            }
            for (int i = size - 1; i >= 1; i--)
            {
                for (int j = 1; j <= size - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine("\n");
            }
        }

        public String GetNumberLessThanTenInWords(int number)
        {
            string Name = "";
            switch(number)
            {
                case 1:
                    Name = "One";
                    break;
                case 2:
                    Name = "Two";
                    break;
                case 3:
                    Name = "Three";
                    break;
                case 4:
                    Name = "Four";
                    break;
                case 5:
                    Name = "Five";
                    break;
                case 6:
                    Name = "Six";
                    break;
                case 7:
                    Name = "Seven";
                    break;
                case 8:
                    Name = "Eight";
                    break;
                case 9:
                    Name = "Nine";
                    break;
                case 10:
                    Name = "Ten";
                    break;
            }
            return Name;
        }

        public String GetNumberInWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + GetNumberInWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += GetNumberInWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += GetNumberInWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += GetNumberInWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;

            //if (number == 0)
            //    return "zero";

            //if (number < 0)
            //    return "minus " + GetNumberInWords(Math.Abs(number));

            //string words = "";

            //int intPortion = (int)number;
            //decimal fraction = (number - intPortion) * 100;
            //int decPortion = (int)fraction;

            //words = NumericToWords(intPortion);
            //if (decPortion > 0)
            //{
            //    words += " and ";
            //    words += NumericToWords(decPortion);
            //}
            //return words
        }

        public void PrintTrianglePointingRight(int size)
        {
            Console.WriteLine("\n");
            for (int i = 1; i <= size - 1; i++)
            {
                Console.WriteLine("*");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine("*");
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("*");
                }
            }
        }

    }
}
