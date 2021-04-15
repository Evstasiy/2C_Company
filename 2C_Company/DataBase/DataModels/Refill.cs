using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C_Company.DataBase.DataModels
{
    [Table("Refill")]
    public class Refill
    {
        [Key]
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public decimal Sum { get; set; }
        public decimal Balance { get; set; }

    }
}
