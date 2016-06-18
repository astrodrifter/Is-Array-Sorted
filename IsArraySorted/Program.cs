using System;
namespace IsArraySorted {
    class Program {
        static void Main(string[] args) {
            // enter an array called numbers here
            int[] numbers = { 8, 2, 3, 4, 6 }; // this example will give False
            bool result = true;
            bool answer = IsArraySorted(numbers, result);
            DisplayResult(answer);
            Console.ReadKey();
        }
        /// <summary>
        /// Take an array called numbers, returns true if sorted,
        /// ascending or descending and false otherwise.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool IsArraySorted(int[] numbers, bool result) {
            int length = numbers.Length;          
            for (int i = 1; i < length; i++) {

                // accending
                if (numbers[i - 1] < numbers[numbers.Length-1]) {
                    if (numbers[i - 1] < numbers[i]) {
                         result = true;
                    }
               
                //decending
                } else if (numbers[i - 1] > numbers[numbers.Length-1]) {
                    if (numbers[i - 1] > numbers[i]) {
                        result = true;
                    }
                }
                result = false;           
            }
            return result;
        }// dispaly result
        public static void DisplayResult(bool answer) { 
            if(answer == true) {
                Console.WriteLine("True! The array is sorted");
            } else {
                Console.WriteLine("False! The array is not sorted");
            }
            
        }
    }
}
