using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C_Company.DataBase.DataModels
{
    [Table("Payments")]
    public class Payment
    {
        [Key]
        public int Number { get; set; }
        public int OrderNumber { get; set; }
        public int? RefillNumber { get; set; }
        public decimal SumPay { get; set; }
        public int? UserId { get; set; }

    }
}
