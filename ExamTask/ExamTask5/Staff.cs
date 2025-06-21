using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask5
{
    public class Staff : Person
    {
        private string school;
        private double pay;

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        public string GetSchool()
        {
            return this.school;
        }

        public void SetSchool(string school)
        {
            this.school = school;
        }

        public double GetPay()
        {
            return this.pay;
        }

        public void SetPay(double pay)
        {
            this.pay = pay;
        }

        public override string ToString()
        {
            return $"Staff[Person[ {base.ToString()}, {this.school}, {this.pay}]]";
        }
    }
}
