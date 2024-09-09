﻿using Microsoft.AspNetCore.Antiforgery;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
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

        public String? BookName { get; set; }
        [Required]
        public double Price { get; set; }
        public String? Image {  get; set; }

        [Required]
        public int GenreId { get; set; }
        public Genre Genre {  get; set; }

        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }
    }
}
