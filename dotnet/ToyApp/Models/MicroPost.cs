using System;
using System.ComponentModel.DataAnnotations;

namespace ToyApp.Models
{
    public class MicroPost
    {
        public int ID { get; set; }
        [StringLength(140), Required]
        public string Content { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
    }
}
