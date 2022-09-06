namespace EscolaParanoa.Alunos
{
    public class EstudantePrimario : Estudante
    {
        public EstudantePrimario(string nome, int idade) : base(nome, idade)
        {
        }

        public override bool PassouDeAno()
        {
            return Media > 6;
        }
    }
}
