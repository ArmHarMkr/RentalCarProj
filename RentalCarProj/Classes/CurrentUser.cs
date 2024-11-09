using RentalCarProj.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProj.Classes
{
    public static class CurrentUser
    {
        public static string Id { get; set; }
        public static string FullName { get; set; }
        public static string Email { get; set; }
        public static AppUser AppUser { get; set; }
    }
}
