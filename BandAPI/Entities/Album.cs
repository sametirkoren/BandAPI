using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Entities
{
    public class Album
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public Band Band { get; set; }

        public Guid BandId { get; set; }
    }
}
