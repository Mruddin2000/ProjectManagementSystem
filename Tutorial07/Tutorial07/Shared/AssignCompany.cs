using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial07.Shared
{
    public class AssignCompany

    {
        [Key]
        public Guid ProjectID { get; set; }
        public Guid CompanyID { get; set; }
        




    }
}
