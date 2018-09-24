using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Book
{
    class RegistrationBook
    {
        //Fields
        private List<Profile> _profiles;
        private string _name;

        //Properties
        public string Name
        {
            get { return _name; }
        }

        public List<Profile> Profiles
        {
            get { return _profiles; }
        }
            
        public RegistrationBook(string name = "There is no name")
        {
            _name = name;
            _profiles = new List<Profile>();
        }

        //Function
        public void AddRegistration(Profile arg)
        {
            _profiles.Add(arg);
        }
    }
}
