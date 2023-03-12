using jeamin.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static jeamin.Utilities.CoreContants;

namespace jeamin.Models
{
    public class ContactUsModel : AppDomainModel
    {
        /// <summary>
        /// Họ và tên
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Nội dung
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Trạng thái: true: đã xử lý, false: chưa xử lý
        /// </summary>
        public bool Status { get; set; }
    }
}
