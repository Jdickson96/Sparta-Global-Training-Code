using NUnit.Framework;
using SafariParkApp;
using System;

namespace SafariParkTest
{
    public class PersonTests
    {

        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var subject = new Person(fName, lName);
            var result = subject.FullName;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }
    }
    public class VehicleTests
    {

            [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }
        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [Test]
        public void WhenAVehicleWithNegativeSpeedIsMovedOnceItsPositionIsPositive()
        {
            Vehicle v = new Vehicle(5, -40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [Test]
        public void WhenAVehicleIsMovedANegativeNoOfTimesItsPositionIsNegative()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move(-2);
            Assert.AreEqual(-80, v.Position);
            Assert.AreEqual("Moving backwards 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithImpossibleCapacityIsMovedOnceItsPositionIsNegative()
        {
            Assert.Throws(Is.TypeOf<ArgumentException>().And.Message.EqualTo("100 people cannot be in this 10 person capacity vehicle"),
                () => new Vehicle(10, 40) { NumPassengers = 100 });
        }

        [Test]
        public void WhenAVehicleHas5OutOf9PeopleGetOut()
        {
            Vehicle v = new Vehicle(10, 40) { NumPassengers = 9};
            var result = v.ChangeOccupancy(-5);
            Assert.AreEqual("The number of people left in the car is 4", result);
        }

        [Test]
        public void WhenAVehicleHasTooManyPeopleGetOut()
        {
            Vehicle v = new Vehicle(10, 40) { NumPassengers = 10 };
            Assert.Throws(Is.TypeOf<ArgumentException>().And.Message.EqualTo("-5 people cannot be in this 10 person capacity vehicle"),
                () => v.ChangeOccupancy(-15));
        }

        [Test]
        public void WhenAVehicleHasTooManyPeopleGetIn()
        {
            Vehicle v = new Vehicle(9, 40) { NumPassengers = 9 };
            Assert.Throws(Is.TypeOf<ArgumentException>().And.Message.EqualTo("24 people cannot be in this 9 person capacity vehicle"),
                () => v.ChangeOccupancy(15));
        }

    }
    public class AirplaneTests
    { 
        [Test]
        public void AirplaneMoving4_Altitude700()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(700);
            var result = a.Move(4);
            Assert.AreEqual("Moving along 4 times at an altitude of 700 meters", result);
        }

        [Test]
        public void AirplaneMoving3_Altitude500()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            var result = a.Move(3);
            Assert.AreEqual("Moving along 3 times at an altitude of 500 meters", result);
        }
    }
}