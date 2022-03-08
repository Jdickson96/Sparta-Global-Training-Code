using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal class Airplane : Vehicle
    {
        private string _airline;
        public Airplane(int _capacity, int speed, string airline = "") : base(_capacity, speed) //inherits from Person class
        {
            _airline = airline;
        }
        public Airplane(int capacity) : base(capacity)
        {
            base._capacity = capacity;
        }

        public int Altitude { get; set; }
        public void Ascend(int distance)
        {
            Altitude = Altitude + distance;
        }
        public void Descend(int distance)
        {
            Altitude = Altitude - distance;
        }

        public override string Move()
        {
            Position = Speed;
            return $"Moving along at an altitude of {Altitude} meters";
        }

        public override string Move(int times)
        {
            Position = Speed * times;   //The Move Method is in control of Forward/Backward movement
            if (times >= 0) return $"Moving along {times} times at an altitude of {Altitude} meters";
            else return $"Moving backwards {Math.Abs(times)} times at an altitude of { Altitude} meters";
        }

        public override string ToString() => $"Thank you for flying {_airline}: " + base.ToString() + $" altitude: { Altitude}";
    }
}
