using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubExtensionTestDrive
{
    class Cars
    {
        private int year;
        private string make;
        private int speed;

        public Cars()
        {
            this.year = 1994;
            this.make = "Ford";
            this.speed = 0;
        }

        public Cars(string make, int year, int speed)
        {
            this.year = year;
            this.make = make;
            this.speed = speed;
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Year
        {
            get { return Year; }
            set { Year = value; }
        }

        public int Speed
        {
            get { return Speed; }
            set { Speed = value; }
        }
    }
}
