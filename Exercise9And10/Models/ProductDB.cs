using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lab9.Models
{
    public class ProductDB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1000, 1999,
        ErrorMessage = "Product ID must be between 1000 and 1999")]
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Product name is required"),
        StringLength(100), Display(Name = "Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Description is required"),
        StringLength(10000), Display(Name = "Product Description"),
        DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Photo")]
        public string ImagePath { get; set; }
        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }
        [Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual CategoryDB CategoryDB { get; set; }
    }
}