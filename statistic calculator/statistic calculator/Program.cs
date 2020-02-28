using System;
using System.Collections.Generic;
using System.Linq;

namespace statistic_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RandomInt());
            Console.WriteLine(RandomDoubles());
            Console.WriteLine(RnumbersInt());
            Console.WriteLine(RnumbersD());
            list();
            listR();
            listOfRand();
            listOfRandSeed();
            Console.WriteLine(mean());
            median();
            mode();
            variance();
            Console.WriteLine(standardD());
            quartiles();
            Console.WriteLine(skewness());
            Console.WriteLine(Coeff());
            Console.WriteLine(meanDev());
        }

        public static int RandomInt()
        {
            // Instantiate random number generator using 100 as seed.
            var rand = new Random(10);

            // Instantiate random number.
            var rand2 = new Random();

            // Generate and display 1 random integer.
            int temp = rand.Next(2);
            Console.WriteLine(temp);
            Console.WriteLine(rand2.Next(2));
            return temp;
          
        }

        public static double RandomDoubles()
        {
            // Instantiate random number generator using 100 as seed.
            var rand = new Random(10);

            // Instantiate random number.
            var rand2 = new Random();

            // Generate and display 1 random integer.
            double temp = rand.NextDouble()*2;
            Console.WriteLine(temp);
            Console.WriteLine(rand2.NextDouble()*2);
            return temp;
        }

        public static List<int> RnumbersInt()
        {
            var rand = new Random(10);
            var numbers = new List<int>();
            //Five random integer values
            for (int ctr = 0; ctr <= 4; ctr++)
                numbers.Add(rand.Next(50));
            return numbers;
        }

        public static List<double> RnumbersD()
        {
            var rand = new Random(10);
            var numbers = new List<double>();
            //Five random double values
            for (int ctr = 0; ctr <= 4; ctr++)
                numbers.Add(rand.NextDouble()*50);
            return numbers;
        }


        public static void list()
        {
            var rand = new Random();
            var numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            Console.WriteLine(numbers[rand.Next(3)]);
        }

        public static void listR()
        {
            var rand = new Random(10);
            var numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            Console.WriteLine(numbers[rand.Next(3)]);
        }

        public static void listOfRand()
        {
            var rand = new Random();
            var numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);

            Console.WriteLine(numbers[rand.Next(10)]);
            Console.WriteLine();
            Console.WriteLine(numbers[rand.Next(10)]);
            Console.WriteLine();
            Console.WriteLine(numbers[rand.Next(10)]);
            Console.WriteLine(numbers[rand.Next(10)]);
        }

        public static void listOfRandSeed()
        {
            var rand = new Random(10);
            var numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);

            Console.WriteLine(numbers[rand.Next(10)]);
            Console.WriteLine();
            Console.WriteLine(numbers[rand.Next(10)]);
            Console.WriteLine();
            Console.WriteLine(numbers[rand.Next(10)]);
            Console.WriteLine(numbers[rand.Next(10)]);
        }

        //Descriptive Statistics functions star here

        public static double mean()
        {
            List<double> numbers = new List<double>(RnumbersD());
            double sum = 0.0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return (sum / 5);
        }

        public static void median()
        {
            List<int> numbers = new List<int>(RnumbersInt());
            List<int> Newnumbers = new List<int>();
            // "gg" is the object oif class GFG 
            GFG gg = new GFG();
  
            // method. The comparer is "gg" 
            numbers.Sort(gg);

            foreach (int g in numbers)
            {
                Newnumbers.Add(g);

            }
            Console.WriteLine(Newnumbers[3]);

        }

        public static void mode()
        {

            List<int> numbers = new List<int>(RnumbersInt());
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (int num in numbers)
            {
                if (count.ContainsKey(num))
                    count[num] = count[num] + 1;
                else
                    count[num] = 1;
            }

            int result = int.MinValue;
            int max = int.MinValue;
            foreach (int key in count.Keys)
            {
                if (count[key] > max)
                {
                    max = count[key];
                    result = key;
                }
            }

            Console.WriteLine(result);
        }

        public static double variance() {
 
          // Get the average of the values
          double avg = mean();
          List<double> numbers = new List<double>(RnumbersD());

            // Now figure out how far each point is from the mean
            // So we subtract from the number the average
            // Then raise it to the power of 2
            double sumOfSquares = 0.0;
 
          foreach (int num in numbers) {
               sumOfSquares += Math.Pow((num - avg), 2.0);
          }
 
          // Finally divide it by n - 1 (for standard deviation variance)
          // Or use length without subtracting one ( for population standard deviation variance)
          return sumOfSquares / (double) (4);
        }

        public static double standardD()
        {
            return Math.Sqrt(variance());
        }

        public static void quartiles()
        {
            List<double> numbers = new List<double>(RnumbersD());
            int length = numbers.Count;

                Console.WriteLine("Q1 = " + numbers[length / 4]);
                Console.WriteLine("Q2 = " + numbers[length / 4]);
                Console.WriteLine("Q3 = " + numbers[length / 4]);
        }

        // Function to calculate skewness. 
        public static double skewness()
        {

            List<double> numbers = new List<double>(RnumbersD());
            double sum = 0;
            int count = numbers.Count;

            for (int i = 0; i < count; i++)
                sum = (numbers[i] - mean()) *
                      (numbers[i] - mean()) *
                      (numbers[i] - mean());

            return (double)sum / (count * standardD() *
                            standardD() *
                            standardD() *
                            standardD());
        }

        public static double Coeff()
        {
            // Instantiate random number generator using 100 as seed.
            var rand = new Random(10);

            // Instantiate random number.
            var rand2 = new Random(12);

            int[] num1 = { rand.Next(), rand.Next(), rand.Next(), rand.Next(), rand.Next() };
            int[] num2 = { rand2.Next(), rand2.Next(), rand2.Next(), rand2.Next(), rand2.Next() };


            var avg1 = num1.Average();
            var avg2 = num2.Average();

            var sum1 = num1.Zip(num2, (x1, y1) => (x1 - avg1) * (y1 - avg2)).Sum();

            var sumSqr1 = num1.Sum(x => Math.Pow((x - avg1), 2.0));
            var sumSqr2 = num2.Sum(y => Math.Pow((y - avg2), 2.0));

            var result = sum1 / Math.Sqrt(sumSqr1 * sumSqr2);

            return result;
        }

        public static double meanDev()
        {

            List<double> numbers = new List<double>(RnumbersD());
            // Calculate the sum of absolute 
            // deviation about mean. 
            double absSum = 0;
            int count = numbers.Count;

            for (int i = 0; i < count; i++)
                absSum = absSum + Math.Abs(numbers[i]- mean());
            return absSum / count;
        }









        //class gfg to sort number lists
        class GFG : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x == 0 || y == 0)
                {
                    return 0;
                }

                // CompareTo() method 
                return x.CompareTo(y);

            }
        }


    }
}

