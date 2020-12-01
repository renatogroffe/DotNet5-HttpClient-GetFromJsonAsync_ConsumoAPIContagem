using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ConsumoAPIContagem
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string urlApiContagem = "http://localhost:6001/contador";
            var client = new HttpClient();

            while (true)
            {
                ResultadoContador resultado =
                    await client.GetFromJsonAsync<ResultadoContador>(urlApiContagem);
                Console.WriteLine($"Valor Atual do Contador: {resultado.ValorAtual} | " +
                    $"Local: {resultado.Local} | " +
                    $"Kernel: {resultado.Kernel} | " +
                    $"Target Framework: {resultado.TargetFramework} | " +
                    $"Mensagem Fixa: {resultado.MensagemFixa} | " +
                    $"Mensagem Variável: {resultado.MensagemVariavel}");

                Console.WriteLine("Pressione CTRL + C para encerrar ou " +
                    "qualquer outra tecla para continuar...\n");
                Console.ReadKey();
            }
        }
    }
}