using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CAdvisor.Entities.Entities
{
    public class CourseScore
    {
        public string Id { get; set; }
        public string CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        public int Points { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }
    }
}
