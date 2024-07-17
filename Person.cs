using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace StudentApp.models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person() { }
        public Person(int id, string address, DateTime dateOfBirth)
        {
            Id = id;
            Address = address;
            DateOfBirth = dateOfBirth;
        }
        public virtual string PrintDetails()
        {
            return $"Person ID: {Id}\n" +
                   $"Person Address: {Address}\n" +
                   $"Person Date of Birth: {DateOfBirth}";
        }

    }
}
