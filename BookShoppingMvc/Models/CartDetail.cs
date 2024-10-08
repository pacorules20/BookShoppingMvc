﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingMvc.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int Id { get; set; }

        [Required]
        public int ShoppingCart_Id { get; set; }

        [Required]

        public int BookId { get; set; }

        [Required]

        public int Quantity {  get; set; }
        public Book book { get; set; }

        public ShoppingCart shoppingCart { get; set; }

    }
}
