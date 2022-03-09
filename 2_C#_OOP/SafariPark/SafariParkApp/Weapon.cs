using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Weapon : IShootable
    {
        private string _brand;
        public virtual string Shoot()
        {
            return "Weapon fired!";
        }
        public virtual string ToString()
        {
            return $"Brand: {_brand}";
        }

        public Weapon() { }

        public Weapon(string brand)
        {
            _brand = brand;
            
        }
    }
}
