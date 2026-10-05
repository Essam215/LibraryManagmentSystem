using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagmentSystem.Models
{
    [Index(nameof(ISBN), IsUnique = true)]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string ISBN {  get; set; }
        [Range(0.1, double.MaxValue)]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; } = true;

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public List<Borrowing> borrowings { get; set; }
    }
}
