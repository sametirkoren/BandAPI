using BandAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Models
{
    public class AlbumDto
    {
        
        public Guid Id { get; set; }


        
        public string Title { get; set; }


       
        public string Description { get; set; }


        

        public Guid BandId { get; set; }
    }
}
