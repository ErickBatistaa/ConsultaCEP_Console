using Refit;
using System;
using System.Threading.Tasks;

namespace Api_Estagio
{
    class Program
    {
        static async Task Main(string[] args)
        {
			try
			{
				var ApiClient = RestService.For<ApiService>("http://jsonplaceholder.typicode.com");
				Console.Write("Informe o seu id = ");
				string idInformado = Console.ReadLine().ToString();
				Console.WriteLine("Consultando informacoes do id: " + idInformado);
				var info = await ApiClient.GetAddressAsync(idInformado);

				Console.WriteLine($"\nUserId:{info.UserId}\nid:{info.Id}\ntitle:{info.Title}\nbody:{info.Body}");
				Console.ReadKey();

			}
			catch (Exception e)
			{

				Console.WriteLine("Erro na consulta do id: " + e.Message);
			}
        }
    }
}
