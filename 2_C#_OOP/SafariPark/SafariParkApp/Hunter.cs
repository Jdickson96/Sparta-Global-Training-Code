using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal class Hunter : Person //inherits from Person class
    {
        private string _camera;
        public Hunter(string fName, string lName, string camera = "") : base (fName,lName) //inherits from Person class
        {
            _camera = camera;
        }
        public string Shoot()
        {
            return $"{FullName} has taken a photo with their {_camera}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}";
        }
    }
}
