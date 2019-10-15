using System;
using System.Collections.Generic;
using System.Net.Http;
namespace Demonstracao3.Client
{
    public class Pessoa
    {
        public Pessoa(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage message = client.GetAsync("http://localhost:5000/api/pessoa").Result;
                var listaPessoas = message.Content.ReadAsAsync<List<Pessoa>>().Result;
                foreach (var item in listaPessoas)
                {
                    Console.WriteLine(item.Nome);
                }
                Console.WriteLine("Respone data as string");
                string resultAsString = message.Content.ReadAsStringAsync().Result;
                Console.WriteLine(resultAsString);
            }
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
