using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
    [Table(Name ="Туры")]
    public class Tours
    {
        [Column(Name ="Код_Тура", IsPrimaryKey =true, IsDbGenerated =true)]
        public int Id { get; set; }
        [Column(Name ="Назввание")]
        public int Name { get; set; }
        [Column(Name = "Цена")]
        public int Price { get; set; }
        [Column(Name = "Информация")]
        public string Information { get; set; }
    }
}
