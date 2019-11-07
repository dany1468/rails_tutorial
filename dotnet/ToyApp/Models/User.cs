using System;
using System.Collections.Generic;

namespace ToyApp.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<MicroPost> MicroPosts { get; set; }
    }
}
