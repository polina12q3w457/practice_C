using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
    [Table(Name ="Путевки")]
    public class Travelpackages
    {
        [Column(Name = "Код путевки", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Код туриста")]
        public string IdTurist { get; set; }
        [Column(Name = "Код сезона")]
        public string IdSeason { get; set; }
    }
}
