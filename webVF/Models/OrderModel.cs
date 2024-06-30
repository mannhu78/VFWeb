using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using webVF.DataBase;

namespace webVF.Models
{
    public class OrderModel 
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Range(0, 1000000)]
        public decimal TotalAmount { get; set; }
    }
}
