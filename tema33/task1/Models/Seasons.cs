using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
    [Table(Name ="Сезоны")]
    public class Seasons
    {
        [Column(Name = "Код сезона", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Код тура")]
        public string IdTour { get; set; }
        [Column(Name = "Дата начала")]
        public string StartDate { get; set; }
        [Column(Name = "Дата конца")]
        public string EndDate { get; set; }
        [Column(Name = "Количество мест")]
        public string NumberOfSeats { get; set; }
    }
}
