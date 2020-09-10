using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.Infrastructure.Models
{
    public class Forms : Entity
    {
        public string Title { get; set; }
        public Boolean Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public IEnumerable<Questions> Question { get; set; }
    }
}
