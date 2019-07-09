using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebClinic.Models
{
    public class Procedimento
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        [DisplayName("Data de realização")]
        public DateTime DataRealizacao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Pagamento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Tipo de procedimento")]
        public int TipoProcedimentoID { get; set; }
        public TipoProcedimento TipoProcedimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Médico")]
        public int MedicoID { get; set; }
        public Medico Medico { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Animal")]
        public int AnimalID { get; set; }
        public Animal Animal { get; set; }
    }
}
