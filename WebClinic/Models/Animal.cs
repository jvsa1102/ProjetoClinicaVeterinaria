using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebClinic.Models
{
    public class Animal
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Espécie")]
        public string Especie { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Raça")]
        public string Raca { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Peso Aproximado")]
        public int PesoAproximado { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Cor")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Porte")]
        public string Porte { get; set; }

        // relacionamento -> proprietario
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Proprietário")]
        public int ProprietarioID { get; set; }
        public Proprietario Proprietario { get; set; }

        public ICollection<Procedimento> Procedimentos { get; set; }
        public ICollection<Consulta> Consultas { get; set; }
        public ICollection<Exame> Exames { get; set; }

    }
}
