using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public String Name { get; set; }    

    }
}
