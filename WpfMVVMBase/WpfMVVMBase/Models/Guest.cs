using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMBase.Models
{
    public class Guest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Comment { get; set; }

        public Guest(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Guest p = (Guest)obj;
                return (Name == p.Name) && (Surname == p.Surname) && (Age == p.Age);
            }
        }
    }
}
