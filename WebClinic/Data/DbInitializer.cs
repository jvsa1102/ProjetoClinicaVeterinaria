using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClinic.Models;

namespace WebClinic.Models
{
    public class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            if (context.TipoProcedimento.Any())
            {
                return;
            }

            var tiposProcedimento = new TipoProcedimento[]
            {
                new TipoProcedimento{Nome="Consulta", Descricao="Consulta com médico para avaliação do Animal", Custo=100},
                new TipoProcedimento{Nome="Retorno", Descricao="Consulta de retorno com médico após consulta comum ou outro procedimento para avalição do caso do animal", Custo=80},
                new TipoProcedimento{Nome="Cirurgia Ortopédica", Descricao="Cirurgia para correção ou tratamento de quaisquer lesões ortopédicas, sejam elas ósseas ou musculares", Custo=500},
                new TipoProcedimento{Nome="Neurocirurgia", Descricao="Cirurgia para coluna vertebral, hérnias de disco, estabilização de vértebras ou craniotomia", Custo=800},
                new TipoProcedimento{Nome="Cirurgia Oncológica", Descricao="Cirurgia para remoção de tumores e tratamento de câncer", Custo=900},
                new TipoProcedimento{Nome="Castração", Descricao="Procedimento cirúrgico de prevenção de gravidez e doenças relacionadas às gônadas animais", Custo=500}
            };

            foreach (TipoProcedimento t in tiposProcedimento)
            {
                context.TipoProcedimento.Add(t);
            }
            context.SaveChanges();
        }
    }
}