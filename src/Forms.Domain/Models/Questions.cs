using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.Domain.Models
{
    public class Questions : Entity
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public string Note { get; set; }
        public int FormsId { get; set; }

        public Forms Forms { get; set; }
        public IEnumerable<Answers> Answers { get; set; }
    }
}
