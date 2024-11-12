﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Domain
{
    public class Reader
    {
        [Key]
        public int id_reader { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
    }
}