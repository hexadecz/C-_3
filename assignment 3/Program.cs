﻿using assignment_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    class Student               // class
    {
        private string studentId;
        private string firstName;
        private string lastName;
        private int yearOfBirth;
        private double gpa;


        public string StudentId         // properties (setters and getters)
        {
            get { return studentId; }
            set {  studentId = value; }
        }
        public string FirstName
        {
            set
            {
                if (value == null)
                    Console.WriteLine("please enter data.");
                else firstName = value;
            }
        }
        public string LastName
        {
            set
            {
                if (value == null)
                    Console.WriteLine("please enter data.");
                else lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - this.yearOfBirth;
                return age;
            }
        }
           public double GPA
        {
            set
            {
                if (value < 0.0 || value > 4.0)
                {
                    Console.WriteLine("invalid GPA");
                }
                else { gpa = value; }
            }
        }
        Student(int yearOfBirth, string studentId)      //constructors
        { }
 
        Student(int yearOfBirth, string studentId, string firstName, string lastName, double gpa)
        { }
     
        public Student(int x)                    //needed to create this constructor to input user year of birth
        { this.yearOfBirth = x; }
        public void Printstudentinfo ()                         //methods
        {
            Console.WriteLine("Student id: {0}  " + "Fullname: {1}  "  +"age: {2}   " + "GPA: {3}   ", studentId, FullName, Age, gpa);
        }

        public bool IsHonorStudent ()
        { if (gpa >= 3.5)
                return true;
         else return false; 
        }


    }
}
    
    internal class Program
    {
        static void Main(string[] args)
        {
        Student s1 = new Student(2003);
        s1.FirstName = "Ziad";              //instance of Student class
        s1.LastName = "Ahmed";
        s1.GPA = 3.7;
        s1.StudentId = Convert.ToString(007);

        s1.Printstudentinfo();              //calling methods
        s1.IsHonorStudent();    

        }
    }