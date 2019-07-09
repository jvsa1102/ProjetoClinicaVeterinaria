using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebClinic.Models
{
    public class TipoProcedimento
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Currency)]
        [RegularExpression(@"^\d+(\.|\,)\d{2}$", ErrorMessage = "O campo requer um valor numérico.")]
        public decimal Custo { get; set; }
    }
}
