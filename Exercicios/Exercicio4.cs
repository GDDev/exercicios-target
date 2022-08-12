namespace ExerciciosTarget.Exercicios
{
    internal class Exercicio4
    {
        public void PercentualPorEstado()
        {
            Dictionary<string, double> estados = new()
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            double soma = estados.Values.Sum(); // 100%

            Dictionary<string, double> estadosPercentual = new(estados);

            foreach (var estado in estados)
            {
                double percentual = (estado.Value * 100) / soma;
                estadosPercentual[estado.Key] = percentual;
            }
            Console.WriteLine("Percentual por estado:");
            foreach (var estado in estadosPercentual)
            {
                Console.WriteLine($"{estado.Key} = {Math.Round(estado.Value, 1)}%");
            }
        }
    }
}
