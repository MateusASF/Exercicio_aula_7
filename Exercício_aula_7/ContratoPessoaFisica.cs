using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_aula_7;

namespace Exercício_aula_7
{
    public class ContratoPessoaFisica : contrato
    {
        public string? Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public int idade { get { return CalculadoraIdade(); } set { } }

        public override decimal CalcularPrestacao(decimal input)
        {
            if (idade <= 30)
            {
                return input + 1;
            }
            else if (idade <= 40)
            {
                return input + 2;
            }
            else if (idade <= 50)
            {
                return input + 3;
            }
            else if (idade > 50)
            {
                return input + 4;
            }
            return 0;
        }

        public int CalculadoraIdade()
        {
            if (Nascimento.Month > DateTime.Now.Month)
            {
                return (DateTime.Now.Year - Nascimento.Year) - 1;
            }
            else if (Nascimento.Month < DateTime.Now.Month)
            {
                return (DateTime.Now.Year - Nascimento.Year);
            }
            else
            {
                if (Nascimento.Day < DateTime.Now.Day)
                {
                    return (DateTime.Now.Year - Nascimento.Year);
                }
                else
                {
                    return (DateTime.Now.Year - Nascimento.Year) - 1;
                }
            }
        }

        public override void ExibirInfo() 
        {
            Console.Clear();
            Console.WriteLine("Informações do Contrato\n");
            Console.WriteLine(idContrato);
            Console.WriteLine(Contratante);
            Console.WriteLine(Cpf);
            Console.WriteLine(idade);
            Console.WriteLine(Valor);
            Console.WriteLine(Prazo);
            Console.WriteLine(Parcela);

        }
    }
}
