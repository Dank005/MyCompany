using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Name page (title)")]
        public override string Title { get; set; } = "Info page";

        [Display(Name = "Content page (title)")]
        public override string Text { get; set; } = "Admin writes content ";
    }
}
