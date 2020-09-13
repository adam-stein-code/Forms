using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.Domain.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
