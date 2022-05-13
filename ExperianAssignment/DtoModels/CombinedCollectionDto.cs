using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExperianAssignment.Models
{
    public class CombinedCollectionDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
    }
}
