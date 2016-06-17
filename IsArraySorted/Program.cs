using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsArraySorted {
    class Program {
        static void Main(string[] args) {
            int[] numbers = { 5, 4, 3, 2, 1 };
            bool result = IsArraySorted(numbers);
            DisplayResult(result);
            Console.ReadKey();


        }
        public static bool IsArraySorted(int[] numbers) {
            int length = numbers.Length;
            for(int i = 0; i < length; i++) {
                if (numbers[i] < numbers[i+1] && numbers[i] > numbers[i+2]) {
                    Console.WriteLine("numbers is not sorted #1");
                    return false;
                } else if (numbers[i] > numbers[i+1] && numbers[i] < numbers[i+2]) {
                    Console.WriteLine("numbers is not sorted #2");
                    return false;
                }              
            }
            return true;
        }
        public static bool DisplayResult(bool result) {
            if(result == true) {
                Console.WriteLine("The array is sorted");
            }
            return true;
        }
    }
}
