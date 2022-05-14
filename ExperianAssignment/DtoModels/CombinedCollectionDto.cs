using System.Collections.Generic;

namespace ExperianAssignment.Models
{
    public class CombinedCollectionDto
    {
        public int AlbumId { get; set; } 
        public int UserId { get; set; }
        public string Title { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
    }
}
