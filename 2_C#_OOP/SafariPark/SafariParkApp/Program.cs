using System;

namespace SafariParkApp;

public class Program
{
    public static void Main()
    {
        #region oldcode
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


        //Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        //a.Ascend(500);
        //Console.WriteLine(a.Move(3)); // should output "Moving along 3 times at an altitude of 500 metres."
        //Console.WriteLine(a);         // should output "Thank you for flying JetsRUs: ClassesApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 300 altitude: 500."
        //a.Descend(200);
        //Console.WriteLine(a.Move());  // should output "Moving along at an altitude of 300 metres."
        //a.Move();
        //Console.WriteLine(a);         // should output "Thank you for flying JetsRUs: ClassesApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 500 altitude: 300."

        #endregion

        #region polymorphism

        // List<Object> gameObjects = new List<Object>()
        // {
        //    new Person("Nish", "Mandal"){Age = 32},
        //    new Airplane(400,200,"Boeing"),
        //    new Vehicle(12,20),
        //    new Hunter("Hunter","McHunty","Pentax")
        // };
        // foreach (var gameObj in gameObjects)
        // {
        //     Console.WriteLine(gameObj);
        // }

        // Person yolanda = new Person("Yolanda", "Young");
        // SpartaWrite(yolanda);

        // var a = new Person("Nish", "Mandal") { Age = 32 };
        // var b = new Hunter("Hunter", "McHunty", "Pentax");

        // SpartaWrite(a);
        // var c = (Person)b;  //Treat b as though its a person even though its a hunter
        // SpartaWrite(c);

        // var d = a as Hunter;    //This will not cast to a hunter as you cannot cast from a base class to a subclass (cannot downcast)
        // SpartaWrite(d);

        #endregion
        /*
        List<IShootable> imoveableUsing = new List<IShootable>()   //The items in the list are declared by the IMoveable interface (treats them as an IMoveable type, and so can only use IMoveable methods)
        {
            new Person("Nish", "Mandal"){Age = 32},
            new Hunter("Hunter", "McHunty", "Pentax"),
            new Vehicle(12,20),
            new Airplane(400,200,"Boeing")
        };

        foreach (var gameObj in imoveableUsing)
         {
             Console.WriteLine(gameObj.Move());
             Console.WriteLine(gameObj.Move(3));
        }
        */

        //  List<IShootable> ishootableUsing = new List<IShootable>() 
        //  {
        //      new WaterPistol("Blastoise"),
        //     new LaserGun ("Blammo"),
        //  };

        //  foreach (var gameObj in ishootableUsing)
        //  {
        //      Console.WriteLine(gameObj.Shoot());
        //  }
        /*
          Hunter hunter1 = new Hunter("Hunter", "McHunty", "Pentax");
          Hunter hunter2 = new Hunter("Dopey", "McHunty", "Sony");
          Hunter hunter3 = new Hunter("Sleepy", "McHunty", "Nikon");
          Hunter hunter4 = new Hunter("Sneezy", "McHunty", "Cannon");

          List<Hunter> hunterList = new List<Hunter>() { hunter1, hunter2, hunter3, hunter4 };

          foreach (var hunterObj in hunterList)
          {
              Console.WriteLine(hunterObj.Shoot());
          }
        */

        //Camera nigel = new Camera("Cannon");
        //Console.WriteLine(nigel.ToString());

        IShootable camera = new Camera("Cannon");
        IShootable laserGun = new LaserGun("Blammo");
        IShootable waterPistol = new WaterPistol("Squirtle");

        Hunter hunter1 = new Hunter("Hunter", "McHunty", camera);
       // Console.WriteLine(hunter1.Shoot());

        Console.WriteLine("Choose a shooter:");
        Console.WriteLine("Type A for camera");
        Console.WriteLine("Type B for Laser Gun");
        Console.WriteLine("Type C for Water Pistol");
        ConsoleKeyInfo chosenShooter;

        var shooterSelector = "";

        do {
            chosenShooter = Console.ReadKey();
            Console.WriteLine(" ");
            switch (chosenShooter.KeyChar)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("You have chosen a camera");
                    hunter1.Shooter = camera;
                    shooterSelector = "camera";
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine("You have chosen a Laser Gun"); 
                    hunter1.Shooter = laserGun;
                    shooterSelector = "Laser Gun";
                    break;
                case 'c':
                case 'C':
                    Console.WriteLine("You have chosen a Water Pistol");
                    hunter1.Shooter = waterPistol;
                    shooterSelector = "Water Pistol";
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }

        } while (chosenShooter.KeyChar != 'a' && chosenShooter.KeyChar != 'A' && chosenShooter.KeyChar != 'b' && chosenShooter.KeyChar != 'B' && chosenShooter.KeyChar != 'c' && chosenShooter.KeyChar != 'C');


        Console.WriteLine($"A rhino is charging at you. You defend yourself with your {shooterSelector}");
        Console.WriteLine(hunter1.Shoot());
        switch (shooterSelector)
        {
            case "Laser Gun":
                Console.WriteLine("Congratulations, you're alive! But the rhino is not.");
                break;
            case "camera":
                Console.WriteLine("You should have chosen a weapon! You are now deceased");
                break;
            case "Water Pistol":
                Console.WriteLine("You should have chosen a real weapon! You are now deceased");
                break;
            default:
                break;
        }


    }

    public static void SpartaWrite(Object obj)
    {
        Console.WriteLine(obj.ToString());  //This is runtime Polymorphism (the commonly understood form of Polymorphism)
        if (obj is Hunter)  //The is keyword is used to check if two objects are the same type
        {
            var hunterObj = (Hunter)obj;
            Console.WriteLine(hunterObj.Shoot);
        }
    }

    static void DemoMethod(Person p, Point3D pt)
    {
        pt.y = 1000;
        p.Age = 92;
    }
}