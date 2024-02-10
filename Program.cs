using RestSharp;

class program
{

    static void Main(string[] args)
    {

        InvocarApiPokemon();


    }

    private static void InvocarApiPokemon()
    {

        var pokemonApi = new RestClient($"https://pokeapi.co/api/v2/pokemon/");
        RestRequest requesteApi = new RestRequest("", Method.Get);
        var responseApi = pokemonApi.Execute(requesteApi);


        if (responseApi.StatusCode == System.Net.HttpStatusCode.OK)
        {
            Console.WriteLine(responseApi.Content);
        }
        else{
            Console.WriteLine(responseApi.ErrorMessage);
        }
        Console.ReadKey();

    }



}


