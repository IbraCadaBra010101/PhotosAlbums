using ExperianAssignment.Models;
using ExperianAssignment.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ExperianAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumCollectionController : ControllerBase
    {
        private readonly ICombinedCollectionRepository _combinedCollectionRepository;

        public AlbumCollectionController(ICombinedCollectionRepository combinedCollectionRepository)
        {
            _combinedCollectionRepository = combinedCollectionRepository;
        }

        [HttpGet] 
        public async Task<ActionResult<CombinedCollectionDto>> GetCollection() 
        {
            var combinedCollection = await _combinedCollectionRepository.GetCombinedCollectionAsync();

            if (combinedCollection == null) return BadRequest();
            
            return Ok(combinedCollection);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<CombinedCollectionDto>> GetCollectionByUserId(int id)
        {
            var combinedCollectionByUser = await _combinedCollectionRepository.GetCombinedCollectionAsyncByUserId(id);

            if (combinedCollectionByUser == null) return BadRequest("Server error!");
            if (!combinedCollectionByUser.Any()) return BadRequest("This user does not exist");

            return Ok(combinedCollectionByUser);
        }
    }
}