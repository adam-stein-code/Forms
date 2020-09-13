using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.Domain.Models
{
    public class Answers : Entity
    {
        public string Value { get; set; }
        public int QuestionsId { get; set; }

        public Questions Questions { get; set; }
    }
}
