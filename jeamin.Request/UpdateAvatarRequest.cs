using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Request
{
    public class UpdateAvatarRequest
    {
        public int UserId { get; set; }
        public string? AvatarIMG { get; set; }
    }
}
