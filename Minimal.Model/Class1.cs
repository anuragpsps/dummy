﻿using System.ComponentModel.DataAnnotations;

namespace Minimal.Model
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}