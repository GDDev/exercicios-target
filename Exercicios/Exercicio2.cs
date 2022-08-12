namespace ExerciciosTarget.Exercicios
{
    internal class Exercicio2
    {
        public string VerificaNumeroEmFibonacci()
        {
            int anterior1 = 0, anterior2 = 1, fibonacci;
            bool existeNumero = false;
            Console.Write("Digite um número para procurar dentro da sequência de Fibonacci: ");
            int.TryParse(Console.ReadLine(), out int numero);

            if ((numero == 0) || (numero == 1)){
                return $"O valor {numero} é um dos valores iniciais";
            }

            for (int i = 0; i <= numero; i++)
            {
                fibonacci = anterior1 + anterior2;
                if (fibonacci == numero) existeNumero = true;
                anterior1 = anterior2;
                anterior2 = fibonacci;
            }
            return existeNumero ? $"O número informado {numero} pertence a sequência de Fibonacci!" : $"O número informado {numero} não pertence a sequência de Fibonacci!";
        }
    }
}
