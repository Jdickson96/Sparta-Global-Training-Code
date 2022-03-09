using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person : IMoveable
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public virtual string Move()
        {
            return "Walking along";
        }
        public virtual string Move(int times)
        {
            return $"Walking along {times} times";
           
        }


        private readonly string _firstName; //readonly means this can only be changed when constructed
        private string _lastName;
        private int _age;
        public int Age {
            get { return _age; }
            set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Age must be over 0");
                }
                else
                {
                    _age = value;
                }
            } 
        }
        public Person(string firstName, string lastName, int age = 0) 
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }

        
        public string FirstName { get; init; }
        public string LastName { get; init; }
        
        public Person(){    }

        public Person(int age)
        {
            Age = age;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {FullName} Age: {Age}";
        }

        public string FullName => $"{_firstName} {_lastName}";
    }
}
