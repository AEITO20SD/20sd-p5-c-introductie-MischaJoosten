using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required, StringLength(40)]
        public string ProductName { get; set; }

        [ForeignKey("Categories")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [Required, StringLength(20)]
        public string QuantityPerUnit { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "smallint")]
        public int UnitsInStock { get; set; }

        [Column(TypeName = "smallint")]
        public int UnitsOnOrder { get; set; }

        [Column(TypeName = "smallint")]
        public int ReorderLevel { get; set; }
    }   
}