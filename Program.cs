using EscolaParanoa;
using EscolaParanoa.Alunos;
using EscolaParanoa.Externos;
using EscolaParanoaSemana02;

Console.WriteLine("Bem-Vindos a Escola Paranoá!!!");
Console.WriteLine("------------------------------------------------------------------------");

try
{
    //EstudanteEnsinoMedio estudante1 = new EstudanteEnsinoMedio("Pedro", -20);
    //estudante1.Notas[0] = 5;
    //estudante1.Notas[1] = 5;
    //estudante1.Notas[2] = 5;
    //estudante1.Notas[3] = 5;

    //estudante1.CalcularMedia();
    //var passouDeAno = estudante1.PassouDeAno();
    //Console.WriteLine($"O {estudante1.Nome} passou de ano? - {passouDeAno}");
    //Console.WriteLine($"A média é: {estudante1.Media}");

    Console.WriteLine("------------------------------------------------------------------------");
    var mensalidade = 500;
    ResponsavelAluno maria = new ResponsavelAluno("Maria", 2000);
    Console.WriteLine($"Saldo antes {maria.Saldo}");
    maria.PagarMensalidade(mensalidade);
    Console.WriteLine($"Saldo depois {maria.Saldo}");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception)
{
    Console.WriteLine("Ocorreu um erro inesperado!");
    
}
finally
{
    Console.WriteLine("execução finalizada");
}


Console.WriteLine("------------------------------------------------------------------------");
Console.WriteLine("Pressione uma Tecla para Terminar o sistema!");
Console.ReadKey();