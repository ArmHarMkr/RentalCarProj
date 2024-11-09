using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProj.Entities
{
    public class RentEntity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        //public string RentUserId { get; set; }
        public AppUser RentUser { get; set; }
        public double RentPrice { get; set; }
        //public string CarId { get; set; }   
        public CarEntity? Car { get; set; }
        public int RentSerialNumber { get; set; }
        public bool IsFinished { get; set; }
        public DateTime RentStartTime { get; set; } = DateTime.Now;
        public int RentDuration { get; set; }
    }
}
