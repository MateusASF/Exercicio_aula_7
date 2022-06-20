using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_aula_7;

namespace Exercício_aula_7
{
    public class ContratoPessoaJuridica : contrato
    {
        public string? Cnpj { get; set; }

        public string? inscricaoEstadual { get; set; }

        public override decimal CalcularPrestacao(decimal input)
        {
            return input + 3;
        }

        public override void ExibirInfo()
        {
            Console.Clear();
            Console.WriteLine("Informações do Contrato\n");

            Console.WriteLine(idContrato);
            Console.WriteLine(Contratante);
            Console.WriteLine(inscricaoEstadual);
            Console.WriteLine(Cnpj);
            Console.WriteLine(Valor);
            Console.WriteLine(Prazo);
            Console.WriteLine(Parcela);
        }
    }
}
