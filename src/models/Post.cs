using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Bogus.DataSets;

namespace catedra3_API.src.models
{
    public class Post
    {   
        [Key]    
        public int id { get; set; }
        public string title { get; set; } = null!;
        public DateTime date { get; set; }
        public string image { get; set; } = null!;

        public string userId { get; set; }
        public User user { get; set; } = null!;
    }
}