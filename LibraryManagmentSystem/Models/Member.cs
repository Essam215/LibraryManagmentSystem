using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagmentSystem.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string Phone { get; set; }

        public List<Borrowing> borrowings { get; set; }
    }
}
