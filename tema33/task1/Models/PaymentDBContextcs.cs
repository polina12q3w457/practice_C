using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
    internal class PaymentDBContextcs
    {
        public PaymentDBContextcs(string fileOrServerOrConnection) : base(fileOrServerOrConnection)
        {
        }
        public Table<payment> payment { get; set; }
    }
}
