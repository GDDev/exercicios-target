namespace ExerciciosTarget.Exercicios
{
    internal class Exercicio5
    {
        public string InverterCaracteres()
        {
            string texto = "Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;";
            string textoInvertido = "";
            List<char> caracteres = new();
            foreach (var caracter in texto)
            {
                caracteres.Add(caracter);
            }

            for (int i = caracteres.Count; i > 0; i--)
            {
                textoInvertido += caracteres[i - 1];
            }

            return $"Texto original: \n{texto}\n\nTexto invertido: \n{textoInvertido}";
        }
    }
}
