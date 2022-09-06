using EscolaParanoa.Alunos;
using EscolaParanoa.Interfacces;

namespace EscolaParanoa.Externos
{
    public class MEC : IChecarNotaAluno
    {
        public double getNotaEstudante(Estudante estudante)
        {
            return estudante.Media;
        }
    }
}
