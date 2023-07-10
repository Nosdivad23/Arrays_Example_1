using System;

namespace My_Application
{
     class Program
    {
        static void Main(string[] args)
        {
            /*
             * You can store multiple variables of the same type in an array data structure. 
             * You declare an array by specifying the type of its elements.
             * The variables in the array are ordered, and each has an index beginning with 0. 
             * C# array is an object of base type System.Array
             */

            // Declare a single-dimensional array of 5 integers.
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[0]);

            // Create an array of four elements, and add values later
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);

            // Update the value of a specific element
            cars[0] = "Kia";
            Console.WriteLine(cars[0]);

            // Declare and set array element values.
            int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(multiDimensionalArray[0, 0]);

            // Properties
            int len = numbers.Length;
            int Dim = multiDimensionalArray.Rank;
            Console.WriteLine("numbers length is: " + len.ToString());
            Console.WriteLine("multiDimensionalArray dimensions are: " + Dim.ToString());

            // Loop Through an Array
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // There is also a foreach loop, which is used exclusively to loop through elements in an array
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            int idx = 0;
            foreach (int number in numbers)
            {

                numbers[idx] = 2 * number + 1;
                Console.WriteLine(numbers[idx]);
                idx++;
            }

            // Sorting
            // Sort a string
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            // Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace
            Console.WriteLine("The max value in myNumbers is " + myNumbers.Max().ToString());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

        }   
    }
}