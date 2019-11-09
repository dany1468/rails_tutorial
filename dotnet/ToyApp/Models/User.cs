using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToyApp.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

        public ICollection<MicroPost> MicroPosts { get; set; }
    }
}
