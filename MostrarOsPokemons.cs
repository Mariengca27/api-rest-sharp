using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpPokemon
{
    public class MostrarOsPokemons
    {



        public void PokemonsMascotes(List<PokemonMascotes> pokemonMascotes)
        {

            //Imprimir os pokemons mascotes
            Console.WriteLine("ESSE SÃO OS POKEMONS EXISTENTES:");
            foreach (var pokemon in pokemonMascotes)
            {
                Console.WriteLine(pokemon);
            }

        }


        public void DetalhesEspecificosPokemons(PokemonDetalhes pokemonDados)
        {

            Console.WriteLine("Nome: " + pokemonDados.Name);
            Console.WriteLine("Altura: " + pokemonDados.Height);
            Console.WriteLine("Peso: " + pokemonDados.Weight);


            foreach (var habilidade in pokemonDados.habilidades)
            {
                Console.WriteLine("Habilidade: " + habilidade.Habilidade.Name);
            }
        }


        public void MostrarPokemonsAdotados(List<PokemonDetalhes> pokemonsAdotados)
        {
            Console.WriteLine("\n ──────────────");
            Console.WriteLine("Pokemons que foram adotados:");
            if (pokemonsAdotados.Count == 0)
            {
                Console.WriteLine("Você ainda não adotou nenhum Pokemon. VOCÊ PRECISA MELHORAR SUAS HABILIDADES COMO MESTRE POKEMON...");
            }
            else
            {
                for (int i = 0; i < pokemonsAdotados.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + pokemonsAdotados[i].Name);
                }
            }
        }






    }
}
