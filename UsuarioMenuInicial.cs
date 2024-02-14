using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpPokemon
{
    public class UsuarioMenuInicial
    {



        public void PrimeiraTelaInicial()
        {

            Console.WriteLine("BOAS VINDAS - CAÇADOR DE POKEMON");
            Console.WriteLine("Escolha uma das opções abaixo para continuar na caçada ao seu Pokemon =):");
            Console.WriteLine("1 - Listar Pokemons");
            Console.WriteLine("2 - Sair");
            Console.WriteLine("Digite a opção desejada: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Listar Pokemons");
                    break;
                case "2":
                    Console.WriteLine("Sair");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        }

        public void PokemonAdotar()
        {
            Console.WriteLine("Escolha um pokemon para adotar: ");
            Console.WriteLine("1. Ver Pokemons Disponíveis");
            Console.WriteLine("2. Ver Detalhes de um tipo de Pokemon");
            Console.WriteLine("3. Adotar Mascote");
            Console.WriteLine("4. Menu Principal");

        }



        public bool ConfirmarAdocaoDoPokemon()
        {
            Console.Write("Você gostaria de adotar este mascote ? CONFIRME SUA RESPOSTA E LEMBRE QUE NÃO DÁ PRA VOLTAR ATRÁS. ");
            string respAdocao = Console.ReadLine();
            return respAdocao.ToLower() == "s";
        }


        public int EscolhaUsuario()
        {

            int numeroEscolhido;
            while (!int.TryParse(Console.ReadLine(), out numeroEscolhido) || numeroEscolhido < 1 || numeroEscolhido < 0 || numeroEscolhido > 4)
            {
                Console.WriteLine("Digite um número VÁLIDO");
            }
            return numeroEscolhido;
        }


    }
}
