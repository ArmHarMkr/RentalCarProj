using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProj.Classes
{
    public static class ValidityCheker
    {
        public static bool CheckEmail(string email)
        {
            return email != null && email.Contains('@') && email.Contains('.');
        }

        public static bool CheckName(string name)
        {
            return name != null && name.Length > 6;
        }

        public static bool CheckPassword(string password)
        {
            return password != null && password.Length > 6;
        }
    }
}
