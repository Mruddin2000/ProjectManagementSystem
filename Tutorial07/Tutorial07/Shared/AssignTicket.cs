using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial07.Shared
{
    public class AssignTicket
    {
        [Key]
        public Guid TicketID { get; set; }
        public Guid ProjectID { get; set; }
        




    }
}
