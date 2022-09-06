using EscolaParanoa.Alunos;
using EscolaParanoa.Interfacces;

namespace EscolaParanoa.Funcionarios
{
    public class Diretor : Funcionario, IChecarNotaAluno
    {
        public Diretor(string nome, int re, string escola) : base(nome, re, escola)
        {
        }

        public double getNotaEstudante(Estudante estudante)
        {
            return estudante.Media;
        }
    }
}
