using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTest.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Pegou Emprestado")]
        public string Borrower { get; set; }
        [DisplayName("Emprestou")]
        public string Lender { get; set; }
        [DisplayName("Ítem")]
        public string ItemName { get; set; }
    }
}
