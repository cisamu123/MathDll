/*
 MathDll
 Dynamic-link library
 Created by Cisamu
 (c) 2022 All right's reserved
 contact: cisamusuppo@gmail.com
 my git - https://github.com/cisamu123
 Thanks for read it!
 */
using System;

namespace MathDll
{
    public class Addition {
        public static void Main(int firstNumber, int secondNumber) {
            Console.WriteLine(firstNumber + secondNumber);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
    public class Subtraction {
        public static void Main(int firstNumber, int secondNumber) {
            Console.WriteLine(firstNumber - secondNumber);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
    public class Multiplication {
        public static void Main(int firstNumber, int secondNumber) {
            Console.WriteLine(firstNumber * secondNumber);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
    public class Division {
        public static void Main(int firstNumber, int secondNumber) {
            Console.WriteLine(firstNumber / secondNumber);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
