﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
