using System;
using RestSharp;
using RestSharp.Authenticators;

namespace MyGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/");
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            if(response.StatusCode == System.Net.HttpStatusCode.OK) {
                Console.WriteLine(response.Content);
            } else {
                Console.WriteLine("Error:" + response.ErrorMessage);
            }
        }
    }
}

