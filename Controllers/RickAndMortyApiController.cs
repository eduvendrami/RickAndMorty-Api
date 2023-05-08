using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickAndMorty.Service.RickAndMorty.Models;
using RickAndMorty.Service.RickAndMorty.Provider;
using RickAndMorty.Service.RickAndMorty.Service;

namespace RickAndMorty.Controllers
{
    [Route("rickAndMorty")]
    public class RickAndMortyApiController : ControllerBase
    {
        private readonly IRickAndMortyService _rickAndMortyService;

        public RickAndMortyApiController(
            IRickAndMortyService rickAndMortyService) 
        {
            _rickAndMortyService = rickAndMortyService;
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetCharactersAsync(
            CharactersRequest request)
        {
            var result = await _rickAndMortyService.GetCharactersAsync(
                request);

            return Ok(result);
        }
    }
}
