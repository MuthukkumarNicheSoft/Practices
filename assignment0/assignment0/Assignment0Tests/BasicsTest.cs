using Assignment0;
using NUnit.Framework;
using System;

namespace Assignment0Tests
{
    [TestFixture()]
    public class BasicsTest
    {
        [Test()]
        public void LargerNumberTest()
        {
            Basics assignm0 = new Basics();
            Assert.AreEqual(2, assignm0.GetLargerNumber(1, 2));

            assignm0 = new Basics();
            Assert.AreEqual(-1, assignm0.GetLargerNumber(-1, -3));

            assignm0 = new Basics();
            Assert.AreEqual(3, assignm0.GetLargerNumber(0, 3));
        }

        [Test()]
        public void LargestNumberTest()
        {
            Basics assignm0 = new Basics();
            Assert.AreEqual(3, assignm0.LargestNumber(1, 2, 3));

            Assert.AreEqual(3, assignm0.LargestNumber(1, 3, 2));

            Assert.AreEqual(3, assignm0.LargestNumber(2, 1, 3));

            Assert.AreEqual(3, assignm0.LargestNumber(2, 3, 1));

            Assert.AreEqual(3, assignm0.LargestNumber(3, 1, 2));

            Assert.AreEqual(3, assignm0.LargestNumber(3, 2, 1));
        }

        [Test()]
        public void SumOfArrayElementsTest()
        {

            Basics assignm0 = new Basics();
            Assert.AreEqual(10, assignm0.GetSumOfArrayElements(new int[] { 0, 1, 2, 3, 4 }, 5));

            Assert.AreEqual(-2, assignm0.GetSumOfArrayElements(new int[] { -1, 1, -2 }, 3));
        }

        [Test()]
        public void PrimeTest()
        {
            Basics assignm0 = new Basics();

            Assert.True(assignm0.IsPrime(5));

            Assert.False(assignm0.IsPrime(10));

            Assert.False(assignm0.IsPrime(0));

            Assert.False(assignm0.IsPrime(1));


        }

        [Test()]
        public void NumbersInARangeTest()
        {
            Basics assignm0 = new Basics();
            Assert.AreEqual(new int[] { 3, 4, 5, 6, 7, 8, 9 },

            assignm0.GetArrayOfRangeOfNumbers(3, 9));

            Assert.AreEqual(new int[] { -3, -2, -1 },

            assignm0.GetArrayOfRangeOfNumbers(-3, -1));

            Assert.AreEqual(new int[] { -3, -2, -1, 0, 1 },

            assignm0.GetArrayOfRangeOfNumbers(-3, 1));
        }

        [Test()]
        public void PrimeNumbersInARangeTest()
        {
            Basics assignm0 = new Basics();
            /*Assert.AreEqual(new int[] { 2, 3, 5, 7 }, assignm0.primeNumbersInARange( 0,9));

            Assert.AreEqual(new int[] { 3, 5, 7 }, assignm0.primeNumbersInARange( 3,9));*/
            assignm0.PrimeNumbersInARange(0, 2000000);

        }

        [Test()]
        public void SumTest()
        {
            Basics assignm0 = new Basics();
            Assert.AreEqual(12, assignm0.GetSum(3, 9));

            Assert.AreEqual(6, assignm0.GetSum(-3, 9));

            Assert.AreEqual(-12, assignm0.GetSum(-3, -9));
        }

        [Test()]
        public void ReverseDigitsTest()
        {
            Basics assignm0 = new Basics();
            Assert.AreEqual(12, assignm0.ReverseDigits(21));

            Assert.AreEqual(4321, assignm0.ReverseDigits(1234));
        }

        /*
         * @Test public void helloWorldTest() { Assignm0 assignm0 = new Assignm0();
         * }
         */

        [Test()]
        public void FactorialTest()
        {
            Basics ass0 = new Basics();
            Assert.AreEqual(6, ass0.GetFactorial(3));

            Assert.AreEqual(1, ass0.GetFactorial(0));

            Assert.AreEqual(1, ass0.GetFactorial(1));
        }
        [Test()]
        public void GetFactorialWithoutLoop()
        {
            Basics ass0 = new Basics();
            Assert.AreEqual(6, ass0.GetFactorialWithoutLoop(3));

            Assert.AreEqual(1, ass0.GetFactorialWithoutLoop(0));

            Assert.AreEqual(1, ass0.GetFactorialWithoutLoop(1));

        }
        [Test()]
        public void TestFindNumberOfOccurences()
        {
            Basics ass0 = new Basics();
            Assert.AreEqual(3, ass0.FindNumberOfOccurences(new int[] { 1, 1, 1 }, 1));

            Assert.AreEqual(2, ass0.FindNumberOfOccurences(new int[] { 1, 2, 1 }, 1));
            Assert.AreEqual(1, ass0.FindNumberOfOccurences(new int[] { 1, 2, 3 }, 1));
            Assert.AreEqual(0, ass0.FindNumberOfOccurences(new int[] { 2, 3, 4 }, 1));

        }

        [Test()]
        public void TestFindFirstOccurence()
        {
            Basics ass0 = new Basics();

            Assert.AreEqual(-1, ass0.FindFirstOccurence(new int[] { 2, 2, 2 }, 1));
            Assert.AreEqual(0, ass0.FindFirstOccurence(new int[] { 1, 1, 1 }, 1));
            Assert.AreEqual(2, ass0.FindFirstOccurence(new int[] { 2, 2, 1 }, 1));



        }

        [Test()]
        public void TestGetNumberLessThanTenInWords()
        {
            Basics ass0 = new Basics();
            Assert.AreEqual("one", ass0.GetNumberLessThanTenInWords(1).ToLower());
            Assert.AreEqual("four", ass0.GetNumberLessThanTenInWords(4).ToLower());
            Assert.AreEqual("four", ass0.GetNumberLessThanTenInWords(4).ToLower());
            Assert.AreEqual("four", ass0.GetNumberLessThanTenInWords(4).ToLower());
            Assert.AreEqual("four", ass0.GetNumberLessThanTenInWords(4).ToLower());
            Assert.AreEqual("four", ass0.GetNumberLessThanTenInWords(4).ToLower());

            Assert.AreEqual("four", ass0.GetNumberLessThanTenInWords(4).ToLower());
        }
        [Test()]
        public void TestGetNumberInWords()
        {
            Basics ass0 = new Basics();
            Assert.AreEqual("thirty four", ass0.GetNumberInWords(34).ToLower());
            Assert.AreEqual("two hundred and thirty four", ass0.GetNumberInWords(234).ToLower());
            Assert.AreEqual("one thousand two hundred and thirty four", ass0.GetNumberInWords(1234).ToLower());
            Assert.AreEqual("forty five thousand six hundred and fifty two", ass0.GetNumberInWords(45652).ToLower());

            /*      Assert.AreEqual("two hundred and nine", ass0.getNumberInWords(209).ToLower());
                    Assert.AreEqual("one thousand and five", ass0.getNumberInWords(1005).ToLower());
                    Assert.AreEqual("thirty five thousand seven hundred and four", ass0.getNumberInWords(35704).ToLower());

                    Assert.AreEqual("five hundred and fifty thousand four hundred and ninety two", ass0.getNumberInWords(550492).ToLower());
            */
        }
    }
}
