using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Book
{
    class Profile
    {
        //Field 
        private string _name;
        private int _age;

        //Properties
        public string Name
        {
            get { return _name; }

            set
            {
                //checking to see if the string is null or empty
                _name = value;
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter a name:");
                    Console.ReadLine();
                }
            }
        }
        public int Age
        {
            get { return _age; }

            set
            {
                //setting field parameter to given value then checking age to see if its appropriate
                _age = value;
                if (value <= 5)
                {
                    Console.WriteLine("Your child is too young for camp");
                }

                if (value >= 10)
                    Console.WriteLine("Your child is too old for camp");
            }
        }

        //Constructor
        public Profile(string name, int age)
        {
            _name = name;
            _age = age;
        }
    }
}
