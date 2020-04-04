using Constructors_Overloading;
using System;

namespace OOP
{




    class Program
    {
        static void Main(string[] args)
        {


            Student F = new Student(1, "Fáusio Luis Matsinhe", "123456", 'M');
            F.StudebtMarks();

            F.GetDetails();

            Console.ReadKey();
        }
    }
}
