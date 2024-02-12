

namespace RestSharpPokemon
{
    internal class PokemonDetalhes
    {

        public List<habilidadesJson> habilidades { get; set; }
        public string Name { get; set; } 
        public int Order { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
            
    }

    //Criar a classe habilidades que vai conter os detalhes da lista

    public class habilidadesJson
    {
        public Habilidade Habilidade { get; set; }
    }
    
    public class Habilidade
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }


}
