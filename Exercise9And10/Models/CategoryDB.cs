using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lab9.Models
{
    public class CategoryDB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Category name is required"),
        StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }
        public virtual ICollection<ProductDB> Products { get; set; }
    }
}