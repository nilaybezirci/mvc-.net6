﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Eczane.Infra.Validation;

namespace Eczane.Models
{
    public class Drug
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Please enter a value")]
        public string? Name { get; set; }

        public string? Slug { get; set; }

        [Required, MinLength(4, ErrorMessage = "Minimum length is 4")]
        public string? Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a value")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "The Categories field is required.")]
        public long CategoryId { get; set; }

        public Category? Category { get; set; }

        public string Image { get; set; } = "noimage.png";

        [NotMapped]
        [FileExtension]
        public IFormFile? ImageUpload { get; set; }

    }
}
