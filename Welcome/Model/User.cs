using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private string _names;
        private string _password;
        private UserRolesEnum _role;
        private string _facultyNumber;
        private string _email;
        private int _id;

        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Names
        {
            get { return _names; }
            set { _names = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = Mask(value); }
        }

        public UserRolesEnum Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public string FacultyNumber
        {
            get { return _facultyNumber; }
            set { _facultyNumber = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string Mask(string toBeMaskedString)
        {
            StringBuilder masked = new StringBuilder();
            foreach (char it in toBeMaskedString)
            {
                masked.Append((char)(it + 5));
            }

            // System.Console.WriteLine("Masked password");
            // System.Console.WriteLine(masked);

            return masked.ToString();
        }

        private string Unmask(string maskedString)
        {
            StringBuilder unmasked = new StringBuilder();
            foreach (char it in maskedString)
            {
                var result = it - 5;
                unmasked.Append((char)result);
            }

            // Console.WriteLine("Unmasked password");
            // Console.WriteLine(unmasked);

            return unmasked.ToString();
        }
    }
}