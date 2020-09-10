using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.Infrastructure.Models
{
    public class Questions : Entity
    {
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public Boolean Active { get; set; }
        public string Description { get; set; }
        public string HelpText { get; set; }
        public int FieldType { get; set; }
        public int FormsID { get;set }


        /* EF Relation */
        public Forms Forms { get; set; }
    }
}
