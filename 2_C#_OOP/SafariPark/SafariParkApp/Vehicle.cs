using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Vehicle
    {
        public int _capacity = 10;
        public int _numPassengers;
        public int NumPassengers { get { return _numPassengers; }
                                   set {
                if (value >= 0 && value <= _capacity)
                {
                    _numPassengers = value;
                } 
                else throw new ArgumentException($"{value} people cannot be in this {_capacity} person capacity Vehicle"); 
            } 
        }
        public int Position { get; set; }
        public int Speed { get; init; } = 10;

        public Vehicle() { }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = Math.Abs(speed);    
        }

        public virtual string Move()
        {
            Position = Speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position = Speed * times;   //The Move Method is in control of Forward/Backward movement
            if (times >= 0) return $"Moving along {times} times";
            else return $"Moving backwards {Math.Abs(times)} times";
        }

        public string ChangeOccupancy(int peopleDifference)
        {
            int currentPassengers = NumPassengers;
            NumPassengers = currentPassengers + peopleDifference;
            return $"The number of people left in the car is {NumPassengers}";
        }
        public override string ToString() => base.ToString() + $" capacity: {_capacity} passengers: {_numPassengers} speed: {Speed} position: { Position}";
    }


}
