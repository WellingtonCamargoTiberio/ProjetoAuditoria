using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Codigo")]

        public int Id { get; set; }

        [Column("RazaoSocial")]
        [Display(Name = "Razão Social")]

        public string RazaoSocial { get; set; }

        [Column("CNPJ")]
        [Display(Name = "CNPJ")]

        public string CNPJ { get; set; }
    }
}
