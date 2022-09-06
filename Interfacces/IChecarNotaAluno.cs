using EscolaParanoa.Alunos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaParanoa.Interfacces
{
    public interface IChecarNotaAluno
    {
        double getNotaEstudante(Estudante estudante);
    }
}
