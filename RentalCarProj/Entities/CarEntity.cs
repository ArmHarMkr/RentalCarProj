using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProj.Entities
{
    public class CarEntity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CarName { get; set; }
        public int RentPricePerDay { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int CarSerialNumber { get; set; }
        public string ImagePath { get; set; } 
    }
}
