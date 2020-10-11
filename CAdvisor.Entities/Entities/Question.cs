using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CAdvisor.Entities.Entities
{
    public class Question
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string QuestionTypeId { get; set; }
        [ForeignKey("QuestionTypeId")]
        public QuestionType QuestionType { get; set; }
    }
}
