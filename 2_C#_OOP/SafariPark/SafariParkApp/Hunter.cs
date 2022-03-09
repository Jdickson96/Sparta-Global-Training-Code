using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal class Hunter : Person, IShootable //inherits from Person class
    {
        //private string _camera;

        private IShootable _shooter;
        public IShootable Shooter { get => _shooter; set => _shooter = value; }
        
        public Hunter(string fName, string lName, IShootable shooter) : base (fName,lName) //inherits from Person class
        {
            if (shooter is Hunter)
            {
                throw new ArgumentException("You cannot use the Hunter to shoot");
            }
            else 
            {
             Shooter = shooter;  
            }
            
           // _camera = camera;
        }

        public string Shoot()
        {
            return $"{_shooter.Shoot()} has been shot by {FullName} ";
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }

    }
}
