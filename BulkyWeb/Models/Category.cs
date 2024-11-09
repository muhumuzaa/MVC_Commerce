using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Catee_Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int CategoryOrder { get; set; }
    }
}
