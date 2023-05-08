using Newtonsoft.Json;

namespace RickAndMorty.Service.RickAndMorty.Models
{
    public class CharactersRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
