using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CAdvisor.Entities.Entities
{
    public class OptionPicture
    {
        public string Id { get; set; }
        public string OptionId { get; set; }
        [ForeignKey("OptionId")]
        public Option Option { get; set; }
        public string PictureId { get; set; }
        [ForeignKey("PictureId")]
        public Picture Picture { get; set; }
    }
}
