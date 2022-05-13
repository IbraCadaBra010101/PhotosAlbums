using ExperianAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExperianAssignment.Services
{
    public interface IDataContextService
    {
        Task<IEnumerable<Photo>> GetPhotos(string photos);
        Task<IEnumerable<Album>> GetAlbums(string albums);
    }
}
