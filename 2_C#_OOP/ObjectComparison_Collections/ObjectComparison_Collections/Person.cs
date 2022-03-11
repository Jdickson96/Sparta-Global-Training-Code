using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparison_Collections
{
        public class Person : IEquatable<Person?>, IComparable<Person>   //right click on person, quick actions and refactorings, generate equals and gethash, tick both boxes
    {
            private string _firstName;
            private string _lastName;
            private int _age;
            public Person() { }
            public Person(string fName, string lName)
            {
                _firstName = fName;
                _lastName = lName;
            }

            public int Age
            {
                get { return _age; }
                set { if (value >= 0) _age = value; }
            }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            if (this._lastName != other._lastName) return this._lastName.CompareTo(other._lastName);
            else if (this._firstName != other._firstName) return this._firstName.CompareTo(other._firstName);
            else return this._age.CompareTo(other._age);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other != null &&
                   _firstName == other._firstName &&
                   _lastName == other._lastName &&
                   _age == other._age;
        }

        public override int GetHashCode()   //by default this uses the memory address but here it is the data
        {
            return HashCode.Combine(_firstName, _lastName, _age);
        }

        public static bool operator ==(Person? left, Person? right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} is {_age}";
        }
    }
}

