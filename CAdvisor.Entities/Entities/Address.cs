using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CAdvisor.Entities.Entities
{
    public class Address
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }
        public string CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public string SuburbId { get; set; }

        [ForeignKey("SuburbId")]
        public Suburb Suburb { get; set; }
        public string StateId { get; set; }
        [ForeignKey("StateId")]
        public State State { get; set; }
    }
}
