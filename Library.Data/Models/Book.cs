﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlPath { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
