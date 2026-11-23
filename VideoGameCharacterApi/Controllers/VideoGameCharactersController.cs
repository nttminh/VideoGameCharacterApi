using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterApi.Models;
using VideoGameCharacterApi.Services;

namespace VideoGameCharacterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharactersController(IVideoGameCharacterService service) : ControllerBase
    {


        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetCharacters() => Ok(await service.GetAllCharacterAsync());
    }
}
