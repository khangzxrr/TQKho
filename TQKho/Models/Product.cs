using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQKho.Models
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class Product
    {
        [Key]
        public int productId { get; set; }


        [Required]
        [MaxLength(100)]

        public string poCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string productCode { get; set; }
        [Required]
        [MaxLength(400)]
        public string productName { get; set; }
        [Required]
        [Range(0, 99999)]
        public long quantity { get; set; }
        [Required]
        [MaxLength(100)]
        public string shelfCode { get; set; }
        
    }
}
