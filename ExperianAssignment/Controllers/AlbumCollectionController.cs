using ExperianAssignment.Models;
using ExperianAssignment.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
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
        public async Task<IActionResult> GetCollection() 
        {
            var combinedCollection = await _combinedCollectionRepository.GetCombinedCollectionAsync();
            return Ok(combinedCollection);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCollectionByUserId(int id)
        {
            var combinedCollectionByUser = await _combinedCollectionRepository.GetCombinedCollectionAsyncByUserId(id);
            return Ok(combinedCollectionByUser);
        }
    }
}