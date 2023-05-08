using Microsoft.AspNetCore.Mvc;
using RickAndMorty.Service.RickAndMorty.Models;

namespace RickAndMorty.Service.RickAndMorty.Service
{
    public interface IRickAndMortyService
    {
        public Task<ActionResult<CharactersResponse.Root>> GetCharactersAsync(
            CharactersRequest charactersRequest);
    }
}
