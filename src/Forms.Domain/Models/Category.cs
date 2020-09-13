using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public IEnumerable<Form> Forms { get; set; }
    }
}
