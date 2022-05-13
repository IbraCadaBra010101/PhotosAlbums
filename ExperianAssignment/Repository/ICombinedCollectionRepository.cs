using ExperianAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExperianAssignment.Repository
{
    public interface ICombinedCollectionRepository
    {
        Task<IEnumerable<CombinedCollectionDto>> GetCombinedCollectionAsync();
        Task<IEnumerable<CombinedCollectionDto>> GetCombinedCollectionAsyncByUserId(int userId);
    }
}
