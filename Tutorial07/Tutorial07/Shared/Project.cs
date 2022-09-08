using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial07.Shared
{
   public class Project
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string ProjectName { get; set; }

        public string Description { get; set; }


    }
}
