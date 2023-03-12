using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Request
{
    public class FieldForUpdatedOutStockSessionRequest
    {
        public int Id { get; set; }

        public int Status { get; set; }

        public bool isPaymentWallet { get; set; } = true;
    }
}
