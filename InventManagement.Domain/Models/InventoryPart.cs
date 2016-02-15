using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InventManagement.Domain.Models
{
    public class InventoryPart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PartName { get; set; }
        [Required]
        public DateTime ManufDate { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
                
        public decimal Price { get; set; }
        
        [MaxLength(2000)]
        public string Comments { get; set; }
    }
}
