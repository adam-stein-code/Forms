using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Forms.Domain.Models
{
    public class Form : Entity
    {
        public string Title { get; set;}
        public string Description { get; set; }
        public Boolean Active { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public IEnumerable<Questions> Questions { get; set; }

    }
}
