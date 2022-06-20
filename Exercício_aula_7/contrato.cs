using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_aula_7
{
    public abstract class contrato
    {
        public Guid idContrato { get { return idContrato = new Guid(); } private set { } }
        public string? Contratante { get; set; }
        public decimal Valor { get; set; }
        public int Prazo { get; set; }
        public decimal Parcela { get; set; }

        public abstract decimal CalcularPrestacao(decimal input);
        public abstract void ExibirInfo();
    }


}
