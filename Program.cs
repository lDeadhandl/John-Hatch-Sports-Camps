using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem Definition: We need a Registration Book that can read registration forms of campers registered
// on a website. 
// It should then be able to sort the information into categories and count numbers in those categories 

namespace Registration_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var Child1 = new Profile("Stefan", 8);
            var Book1 = new RegistrationBook("Competitive Juniors");

            Book1.AddRegistration(Child1);

            Console.WriteLine(Book1.Name);
            //How can I get the name and age of the profile in the book?
            Console.WriteLine(Book1.Profiles[0].Name);  
        }

    }
}
