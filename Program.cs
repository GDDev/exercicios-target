using ExerciciosTarget.Exercicios;

Exercicio2 exercicio2 = new();
// Console.WriteLine(exercicio2.VerificaNumeroEmFibonacci());

Exercicio3 exercicio3 = new();
Console.WriteLine($"Menor faturamento do mês: {exercicio3.MenorFaturamento():C}");
Console.WriteLine($"Maior faturamento do mês: {exercicio3.MaiorFaturamento():C}");
Console.WriteLine($"Quantidade de dias em que o faturamento superou a média mensal: {exercicio3.QtdDiasSuperioresMedia()}");

Exercicio4 exercicio4 = new();
// exercicio4.PercentualPorEstado();

Exercicio5 exercicio5 = new();
// Console.WriteLine(exercicio5.InverterCaracteres());

Console.ReadKey();
