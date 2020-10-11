using System;
using System.Collections.Generic;
using System.Text;

namespace CAdvisor.Entities.Entities
{
    public class QuestionType
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public bool isMultiChoice { get; set; }
        public bool isTrueOrFalse { get; set; }
        public bool isSelect { get; set; }
    }
}
