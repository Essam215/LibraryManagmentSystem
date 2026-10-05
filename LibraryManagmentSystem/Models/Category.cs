using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagmentSystem.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Description { get; set; } 
        public List<Book> books { get; set; }
    }
}
