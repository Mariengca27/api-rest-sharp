using System;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using RestSharpPokemon;




public class program
{

    public static void Main(string[] args)
    {

        var pokemonEspecies = new RestClient($"https://pokeapi.co/api/v2/pokemon-species/");
        var requisicaoPegarEspecies = new RestRequest("", Method.Get);
        var respostaPegarEspecies = pokemonEspecies.Execute(requisicaoPegarEspecies);


        var pokemonResposta = JsonConvert.DeserializeObject<PokemonNaTela>(respostaPegarEspecies.Content);

        Console.WriteLine("BOAS VINDAS CAÇADOR DE POKEMON");
        Console.WriteLine("Escolha uma das opções abaixo para continuar na caçada ao seu Pokemon =):");



        foreach (var pokemon in pokemonResposta.Results)
        {
            Console.WriteLine(pokemon.Name);
        }

    }
}


