using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebClinic.Models
{
    public class Medico
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string CRMV { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string CPF { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Especialidade { get; set; }

        [DisplayName("Especializações")]
        public string Especializacoes { get; set; }

        public ICollection<Procedimento> Procedimentos { get; set; }
        public ICollection<Exame> Exames { get; set; }
        public ICollection<Consulta> Consultas { get; set; }
    }
}
