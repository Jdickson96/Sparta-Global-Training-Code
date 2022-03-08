using System;

namespace SafariParkApp;

public class Program
{
    public static void Main()
    {
        /*
        Person james = new Person("James", "Dickson", 26);  //new generates a new instance of an object by calling constructor
        Console.WriteLine(james.GetFullName);

        Person david = new Person("David", "Cull", -1);
        Console.WriteLine(david.GetFullName);
        david.Age = 1;
        

        var arr = new int[] { 1, 2, 3 };

        var marian = new Person("Marian", "Dumitriu") { Age = 90 };

        var shoppingBasket = new ShoppingBasket() { Bread = 2, Milk = 6, Potato = 2};
    */

        //   var nish = new Person("Nish","Mandal") {  Age = 32 };   //before init keyword

        /*
        var nish = new Person() { FirstName = "Nish", LastName = "Mandal", Age = 32 };
        Console.WriteLine($"{nish.FirstName}");

        var person = new Person() { FirstName = "Jay", LastName = "Z", Age = 50 };
        var pt3d = new Point3D(1, 2, 3);
        DemoMethod(person, pt3d);   //the person age changes as its a reference type, but the coordinate only edits a copy which is lost when the function ends
        */

        //Hunter h1 = new Hunter("Gaurav","Dogra","Nikon") { Age = 22};
        //Hunter h2 = new Hunter("Goncalo", "Nunes", "Leica") { Age = 28 };

        //Console.WriteLine(h1.Age);
        //Console.WriteLine(h1.Shoot());

        //Console.WriteLine(h2.GetHashCode());
        //Console.WriteLine(h2.GetType());
        //Console.WriteLine(h2.Equals(h1));

        //Console.WriteLine(h2.ToString());

        // var rec1 = new Rectangle(10, 10);
        // Rectangle rec2 = new Rectangle(11, 2);
        // Shape rec3 = new Rectangle(11, 2);

        // rec3.CalculateArea();


        Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        a.Ascend(500);
        Console.WriteLine(a.Move(3)); // should output "Moving along 3 times at an altitude of 500 metres."
        Console.WriteLine(a);         // should output "Thank you for flying JetsRUs: ClassesApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 300 altitude: 500."
        a.Descend(200);
        Console.WriteLine(a.Move());  // should output "Moving along at an altitude of 300 metres."
        a.Move();
        Console.WriteLine(a);         // should output "Thank you for flying JetsRUs: ClassesApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 500 altitude: 300."
    }

    static void DemoMethod(Person p, Point3D pt)
    {
        pt.y = 1000;
        p.Age = 92;
    }
}