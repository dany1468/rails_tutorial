﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ToyApp.Models
{
    public class MicroPost
    {
        public int ID { get; set; }
        [StringLength(140)]
        public string Content { get; set; }
        public int UserID { get; set; }
    }
}
