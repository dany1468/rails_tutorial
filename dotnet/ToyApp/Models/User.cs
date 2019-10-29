using System;
namespace ToyApp.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        ICollection<MicroPost> MicroPosts { get; set; }
    }
}
