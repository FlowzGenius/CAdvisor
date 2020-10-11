using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CAdvisor.Entities.Entities
{
    public class AnswerOption
    {
        public string Id { get; set; }
        public string AnswerId { get; set; }
        [ForeignKey("AnswerId")]
        public Answer Answer { get; set; }
        public string OptionId { get; set; }
        [ForeignKey("OptionId")]
        public Option Option { get; set; }
    }
}
