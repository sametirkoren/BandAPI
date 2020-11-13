
using AutoMapper;
using BandAPI.Entities;
using BandAPI.Models;
using BandAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Controllers
{
    [ApiController]
    [Route("api/bandcollections")]
    public class BandCollectionsController : ControllerBase
    {
        private readonly IBandAlbumRepository _bandAlbumRepository;
        private readonly IMapper _mapper;
        public BandCollectionsController(IBandAlbumRepository bandAlbumRepository, IMapper mapper)
        {
            _bandAlbumRepository = bandAlbumRepository ?? throw new ArgumentNullException(nameof(bandAlbumRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost]

        public ActionResult<IEnumerable<BandDto>> CreateBandCollection([FromBody] IEnumerable<BandForCreatingDto> bandCollection)
        {
            var bandEntities = _mapper.Map<IEnumerable<Band>>(bandCollection);
            foreach(var bandEntity in bandEntities)
            {
                _bandAlbumRepository.AddBand(bandEntity);
            }

            _bandAlbumRepository.Save();

            return Ok();
        }
    }
}
