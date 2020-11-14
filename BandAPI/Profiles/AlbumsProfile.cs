using AutoMapper;
using BandAPI.Entities;
using BandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Profiles
{
    public class AlbumsProfile : Profile
    {
        public AlbumsProfile()
        {
            CreateMap<Album, AlbumDto>().ReverseMap();
            CreateMap<AlbumForCreatingDto, Album>();
            CreateMap<AlbumForUpdatingDto, Album>().ReverseMap();
        }
    }
}
