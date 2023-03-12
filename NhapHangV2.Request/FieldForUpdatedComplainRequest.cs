using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Request
{
    public class FieldForUpdatedComplainRequest
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int Status { get; set; }
    }
}
