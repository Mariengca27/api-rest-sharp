using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace RestSharpPokemon
{
    public class DriverApi
    {

        public List<PokemonMascotes> PokemonsMascotesDisponiveis()
        {
            var requestpApi = new RestClient("https://pokeapi.co/api/v2/pokemon-species/");
            var requestMetodo = new RestRequest("", Method.Get);
            RestResponse responseApi = requestpApi.Execute(requestMetodo);       
           return JsonConvert.DeserializeObject<List<PokemonMascotes>>(responseApi.Content);
        }



        public PokemonDetalhes MetodoDetalhesPokemon(PokemonMascotes pokemonMascotes)
        {

            var requestpApi = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemonMascotes.Name}");
            var requestMetodo = new RestRequest("", Method.Get);
            RestResponse response = requestpApi.Execute(requestMetodo);



            return JsonConvert.DeserializeObject<PokemonDetalhes>(response.Content);

        }




    }
}

