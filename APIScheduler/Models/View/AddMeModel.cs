using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIScheduler.Models.View
{
    public class AddMeModel
    {
        [Required]
        public string Name { get; set; }
    }
}
