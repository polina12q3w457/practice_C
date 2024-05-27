using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
    public class TravelPackagesDBContext
    {
        public TravelPackagesDBContext(string fileOrServerOrConnection) : base(fileOrServerOrConnection)
        {
        }
        public Table<Travelpackages> Travelpackages { get; set; }
    }
}
