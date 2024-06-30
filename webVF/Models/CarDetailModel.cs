using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using webVF.DataBase;

namespace webVF.Models
{
    public class CarDetailModel 
    {
        [Key]
        public int CarDetailID { get; set; }

        [Required]
        public int CarID { get; set; }

        [ForeignKey("CarID")]
        public Car Car { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(50)]
        public string Engine { get; set; }

        [StringLength(50)]
        public string Transmission { get; set; }

        [StringLength(int.MaxValue)]
        public string Features { get; set; }
    }
}
