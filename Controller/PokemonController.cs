using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharpPokemon.View;

namespace RestSharpPokemon.Controller
{
    public class PokemonController
    {

        // Início das instâncias das classes
        private DriverApi pokemonApiDriver { get; set; }
        private MostrarOsPokemons mostrarOsPokemonsMenu { get; set; }
        private UsuarioMenuInicial usuarioMenuInicial { get; set; }

        private List<Model.PokemonMascotes> pokemons { get; set; }

        private List<Model.PokemonDetalhes> pokemonsEscolhidosDetalhes { get; set; }


        //Criando o construtor com as instâncias das classes para serem usadas nos métodos do controller
        public void visualizacaoDosPokemons()
        {
            pokemonApiDriver = new DriverApi();
            mostrarOsPokemonsMenu = new MostrarOsPokemons();
            usuarioMenuInicial = new UsuarioMenuInicial();
            pokemons = new List<Model.PokemonMascotes>();
            pokemonsEscolhidosDetalhes = new List<Model.PokemonDetalhes>();


        }


        //Chamadas dentro do método principal do controller. Onde toda a lógica vai prevalecer 

        public void JogarComOsPokemons()
        {
            mostrarOsPokemonsMenu.PokemonsMascotes(pokemons);


        }


    }
}
