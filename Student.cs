using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.models
{
    internal class Student : Person
    {
        public string Branch {  get; set; }

        public Student() { }

        public Student(int id, string address, DateTime dateOfBirth, string branch) 
            : base(id, address, dateOfBirth)
        {
            Branch = branch;
        }

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}\nBranch: {Branch}";
        }
    }
}
