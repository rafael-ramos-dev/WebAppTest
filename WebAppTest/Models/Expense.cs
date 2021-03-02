using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTest.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Despesa")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Despesa deve ser maior que 0")]
        [DisplayName("Valor")]
        public int Amount { get; set; }
    }
}
