using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Online_Book_Store.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
