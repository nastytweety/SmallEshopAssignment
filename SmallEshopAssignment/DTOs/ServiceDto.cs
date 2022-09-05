﻿using System.ComponentModel.DataAnnotations;

namespace SmallEshopAssignment.DTOs
{
    public class ServiceDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
