using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask5
{
    public class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public Student(string name, string address, int year, double fee, string program) : base(name, address)
        {
            this.year = year;
            this.fee = fee;
            this.program = program;
        }

        public string GetProgram()
        {
            return this.program;
        }

        public void SetProgram(string program)
        {
            this.program = program;
        }

        public int GetYear()
        {
            return year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        public double GetFee()
        {
            return this.fee;
        }

        public void SetFee(double fee)
        {
            this.fee = fee;
        }

        public override string ToString()
        {
            return $"Student [Person[{base.ToString()},{this.year},{this.fee},{this.program}]]";
        }
    }
}
