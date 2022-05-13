using ExperianAssignment.Models;
using ExperianAssignment.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExperianAssignment.Repository.Implementation
{
    public class CombinedCollectionRepository : ICombinedCollectionRepository
    {
        private readonly IDataContextService _dataContextService;

        public CombinedCollectionRepository(IDataContextService dataContextService)
        {
            _dataContextService = dataContextService;
        }


        public async Task<IEnumerable<CombinedCollectionDto>> GetCombinedCollectionAsync()
        {
            var photos = await _dataContextService.GetPhotos("/photos");
            var albums = await _dataContextService.GetAlbums("/albums");

            var combinedCollection =
              from album in albums

              select new CombinedCollectionDto()
              {
                  Id = album.Id,
                  UserId = album.UserId,
                  Title = album.Title,
                  Photos = photos.Where(p => p.AlbumId == album.Id)
             };

            return combinedCollection;
        }

        public async Task<IEnumerable<CombinedCollectionDto>> GetCombinedCollectionAsyncByUserId(int userId)
        {
            var photos = await _dataContextService.GetPhotos("/photos");
            var albums = await _dataContextService.GetAlbums("/albums");

            IEnumerable<CombinedCollectionDto> combinedCollection =
              from album in albums where userId == album.UserId

              select new CombinedCollectionDto()
              {
                  Id = album.Id,
                  UserId = album.UserId,
                  Title = album.Title,
                  Photos = photos.Where(p => p.AlbumId == album.Id)
              };

            return  combinedCollection;
        }

    }
}
