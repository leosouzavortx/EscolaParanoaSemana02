namespace EscolaParanoa.Alunos
{
    public abstract class Estudante
    {
        public Estudante(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Notas = new int[4];
        }

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double Media { get; private set; }
        public int[] Notas { get; private set; }

        public abstract bool PassouDeAno();

        public void CalcularMedia()
        {
            var bimestres = 0;
            Media = (Notas[0] + Notas[1] + Notas[2] + Notas[3]) / bimestres;
        }

    }
}
