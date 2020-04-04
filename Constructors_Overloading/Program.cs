using System;

namespace OOP
{
    class Student
    {
        int Id;
        string Name;
        double AP1, AP2;
        string contact;
        char Gender;
        double AP;

        Random R = new Random();



        #region Constructors Overloading simple
        //public Student(string Name)
        //{
        //    this.Id = R.Next();
        //    this.Name = Name;
        //}

        //public Student(string Name, string contact)
        //{
        //    this.Id = R.Next();
        //    this.Name = Name;
        //    this.contact = contact;
        //}

        //public Student(int Id, string Name, string contact)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.contact = contact;
        //}
        #endregion

        #region Constructors Overloading With "this"
        public Student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public Student(int Id, string Name, string contact) : this(Id, Name)
        {
            this.contact = contact;
        }

        public Student(int Id, string Name, string contact, char Gender) : this(Id, Name, contact)
        {
            this.Gender = Gender;
        }
        #endregion

        public void StudebtMarks( )
        {

            Console.WriteLine("Add the Ap1 value");
            this.AP1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add the Ap2 value");
            this.AP2 = Convert.ToDouble(Console.ReadLine());

            StudantResult();
        }

        public string StudantResult()
        {
             
            if (((AP1 + AP2) / 2) > 13.5)
            {

                return "Passed";
            }
            return "Failed";


        }

        public void GetDetails()
        {
            Console.WriteLine("ID: {0}, Name: {1}, Contact: {2}, Result: {4} , Gender: {3}", this.Id, this.Name, this.contact,this.Gender, StudantResult());
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            //Student f; // Creating Reference
            //f = new Student(); // creating object

            Student F = new Student(1, "Fáusio Luis Matsinhe", "123456", 'M');
            F.StudebtMarks();

            F.GetDetails();

            Console.ReadKey();
        }
    }
}
