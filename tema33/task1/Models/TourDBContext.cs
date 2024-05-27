using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
    public class TourDBContext
    {
        public TourDBContext(string fileOrServerOrConnection) : base(fileOrServerOrConnection)
        {
        }
        public Table<Tours> Tours { get; set; }
    }
}
