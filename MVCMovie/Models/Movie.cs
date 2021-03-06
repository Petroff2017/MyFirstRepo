﻿using System;
using System.ComponentModel.DataAnnotations;
namespace MVCMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60,MinimumLength=3)]
        [Required]
        public string Title { get; set; }

        [Display(Name ="Release Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z}+[a-zA-Z]*$")]
        public string Genre { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(5)]
        [RegularExpression(@"^[A-Z}+[a-zA-Z]*$")]
        public string Rating { get; set; }
    }
}