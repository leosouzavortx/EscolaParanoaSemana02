using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaParanoa.Externos
{
    public class ResponsavelAluno
    {
        public ResponsavelAluno(string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }

        public string Nome { get; set; }
        public double Saldo { get; set; }

        public void PagarMensalidade(double mensalidade)
        {
            Saldo -= mensalidade;
        }
    }
}
