using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CAdvisor.Entities.Entities
{
    public class Option
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        public string QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
        public bool isSelected { get; set; }
        public bool isAbort { get; set; }
        public string OptionPictureId { get; set; }
        [ForeignKey("OptionPictureId")]
        public OptionPicture OptionPicture { get; set; }
    }
}
