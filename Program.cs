using System;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using RestSharpPokemon;



public class program
{

    static readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        try
        {
            HttpResponseMessage responseRequest = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/");
            responseRequest.EnsureSuccessStatusCode();
            string responseBodyPokemon = await responseRequest.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<PokemonMascotes>(responseBodyPokemon);

            Console.WriteLine(data);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
        }
    }
}


