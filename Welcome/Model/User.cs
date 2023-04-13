using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Names { get; set; }
        
        public string Password { get ; set; }

        public UserRolesEnum Role { get; set; }

        public string FacultyNumber { get; set; }
        
        public string Email { get; set; }

        private static string Mask(string toBeMaskedString)
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