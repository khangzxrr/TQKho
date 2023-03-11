using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQKho.Models
{
    public class Shelf
    {
        [Key]
        public int shelfId { get; set; }
        [Required]
        [MaxLength(10)]
        public string shelfCode { get; set;}
        public List<Product> products { get; set; }

        public Shelf()
        {
            products = new List<Product>();
        }

        public override string ToString()
        {
            return this.shelfCode;
        }
    }
}
