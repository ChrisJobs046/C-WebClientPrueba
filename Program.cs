using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace C_WebClientPrueba
{
    class Program
    {
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Console.Write("Bienvenido a obtener datos de la URL");

            Program program = new Program();
            await program.GetTodo();
            
        }
        

        private async Task GetTodo(){
            //string URL = Console.ReadLine();
            string response = await client.GetStringAsync("https://localhost:44319/api/productos");
            Console.WriteLine(response);
        }
    }
}

