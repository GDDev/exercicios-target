using Newtonsoft.Json;

namespace ExerciciosTarget.Exercicios
{
    internal class Exercicio3
    {
        private Faturamento[] InterpretarJson()
        {
            string arquivoJson = Path.GetFullPath("dados.json");
            arquivoJson = arquivoJson.Replace(@"\bin\Debug\net6.0", "");

            string jsonString = File.ReadAllText(arquivoJson);

            var faturamentos = JsonConvert.DeserializeObject<Faturamento[]>(jsonString);
            return faturamentos;
        }

        public double MenorFaturamento()
        {
            Faturamento[] faturamentos = InterpretarJson();

            double menorValor = 99999;
            foreach (var faturamento in faturamentos)
            {
                if(faturamento.Valor < menorValor) // Adicione "&& faturamento.Valor > 0" para o menor valor entre os dias nos quais houveram ganhos
                {
                    menorValor = faturamento.Valor;
                }
            }

            return menorValor;
        }

        public double MaiorFaturamento()
        {
            Faturamento[] faturamentos = InterpretarJson();

            double maiorValor = 0;
            foreach (var faturamento in faturamentos)
            {
                if (faturamento.Valor > maiorValor)
                {
                    maiorValor = faturamento.Valor;
                }
            }

            return maiorValor;
        }

        public int QtdDiasSuperioresMedia()
        {
            Faturamento[] faturamentos = InterpretarJson();

            double soma = 0;
            int diasProd = 0;

            foreach (var fat in faturamentos)
            {
                if(fat.Valor > 0)
                {
                    soma += fat.Valor;
                    diasProd++;
                }
            }
            int qtdDiasAcimaMedia = 0;
            foreach (var fat in faturamentos)
            {
                if (fat.Valor > (soma / diasProd)) qtdDiasAcimaMedia++;
            }

            return qtdDiasAcimaMedia;
        }
    }

    public class Faturamento
    {
        [JsonProperty("dia")]
        public int Dia { get; set; }

        [JsonProperty("valor")]
        public double Valor { get; set; }
    }
}
