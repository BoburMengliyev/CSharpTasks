using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask14.HomeTask1.Person.Student
{
    internal class Student : Person
    {
        private int numCourses = 0;
        private string[] courses = new string[30];
        private int[] grades = new int[30];

        public Student (string name, string addres) : base (name, addres)
        { }

        public void addCourseGrade(string course, int grade) 
        {
            courses[numCourses] = course;
            grades[numCourses] = grade;
            numCourses++;
        }

        public void printGrades() 
        {
            for (int i = 0; i < numCourses; i++) 
            {
                Console.WriteLine($"{courses[i]}: {grades[i]}");
            }
        }

        public double getAverageGrade() 
        {
            int sum = 0;
            for (int i = 0; i < numCourses; i++) 
            {
                sum += grades[i];
            }
            return numCourses > 0 ? (double)sum / numCourses : 0.0;
        }

        public string toString()
        {
            return $"Student: {getName()}({getAddress()})";
        }
    }
}