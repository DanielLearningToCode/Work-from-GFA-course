﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class IndexViewModel
    {
        public ICollection<Post> Posts { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
        public string SortBy { get; set; }
        public List<string> Names { get; set; }
        public int PostsPerPage { get; set; }
        public string FilteredAuthor { get; set; }
        public IndexViewModel()
        {
            Posts = new List<Post>();
            Names = new List<string>() { "-" };
        }
    }
}
