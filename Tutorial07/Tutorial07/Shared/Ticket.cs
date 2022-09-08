using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial07.Shared
{
   public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string TicketName { get; set; }

        public string Description { get; set; }


    }
}
