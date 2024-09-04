using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingMvc.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(40)]

        public string BookName { get; set; }
    }
}
