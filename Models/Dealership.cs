using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealershipReviews.Models
{
    public class Dealership
    {
        public Dealership()
        {

        }

        [Key]
        [Required]
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string St { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }

    }
}
