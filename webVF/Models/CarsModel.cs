using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace webVF.Models
{
    public class CarsModel 
    {
        [Key]
        public int CarID { get; set; }

        [Required]
        [StringLength(50)]
        public string CarName { get; set; }

        [Required]
        [Range(0, 1000000)]
        public decimal Price { get; set; }

        [StringLength(int.MaxValue)]
        public string Description { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }
    }
}
