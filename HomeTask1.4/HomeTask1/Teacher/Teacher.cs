using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask14.HomeTask1.Person.Teacher
{
    internal class Teacher : Person
    {
        private int numCourses = 0;
        private string[] courses = new string[30];


        public Teacher(string name, string address) : base(name, address)
        { }

        public bool addCourse(string course)
        {
            for (int i = 0; i < numCourses; i++)
            {
                if (courses[i] == course)
                {
                    return false;
                }
            }
            courses[numCourses] = course;
            numCourses++;
            return true;
        }
        public bool removeCourse(string course) 
        {
            for (int i = 0; i < numCourses; i++) 
            {
                if (courses[i] == course) 
                {
                    for (int j = i; j < numCourses - 1; j++) 
                    {
                        courses[j] = courses[j + 1];
                    }
                    courses[numCourses - 1] = null;
                    numCourses--;
                    return true;
                }
            }
            return false;
        }

        public string toString() 
        {
            return $"Teacher: {getName()}({getAddress()})";
        }
    }
}