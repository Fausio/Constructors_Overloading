using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Constructors_Overloading
{
    public class Student
    {

        #region explicity (manual) proprerty get and set code
        //public int Id
        //{
        //    get { return Id; }
        //    set { Id = value; }
        //}
        #endregion
        #region implicity (Automatic) proprerty get and set code

            [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(40,ErrorMessage = "please add name that have les then 40 caracters")]
        public string Name { get; set; }
        public double AP1 { get; set; }
        public double AP2 { get; set; }
        public string contact { get; set; }
        public char Gender { get; set; }
        public double AP { get; set; }
        #endregion

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

        public void StudebtMarks()
        {
            Console.WriteLine("Add the Ap1 value");
            this.AP1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add the Ap2 value");
            this.AP2 = Convert.ToDouble(Console.ReadLine());

            StudantResult();
        }

        #region StudantResult Overloading simple
        public string StudantResult()
        {
            if (((AP1 + AP2) / 2) > 13.5)
            {
                return "Passed";
            }
            return "Failed";
        }

        public string StudantResult(int MinResult)
        {
            if (((AP1 + AP2) / 2) >= MinResult)
            {
                return "Passed";
            }
            return "Failed";
        }
        #endregion 
        public void GetDetails()
        {
            Console.WriteLine("ID: {0}, Name: {1}, Contact: {2}, Result: {4} , Gender: {3}", this.Id, this.Name, this.contact, this.Gender, StudantResult());
            Console.WriteLine("_______________________________");
            Console.WriteLine("The Length of the names is {0}", this.Name.Length);
        }


    }
}
