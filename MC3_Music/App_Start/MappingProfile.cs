using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MC3_Music.Models;
using MC3_Music.Dtos;

namespace MC3_Music.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Album, AlbumDto>();
            Mapper.CreateMap<AlbumDto, Album>();

        }
    }
}