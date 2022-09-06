using EscolaParanoa.Alunos;

namespace EscolaParanoa.Funcionarios
{
    public class Professor : Funcionario
    {
        public Professor(string nome, int re, string escola) : base(nome, re, escola)
        {
        }

        public double CalcularMedia(Estudante estudante)
        {
           var bimestres = 4;
           return (estudante.Notas[0] + estudante.Notas[1] + estudante.Notas[2] + estudante.Notas[3]) / 4;
        }
    }
}
