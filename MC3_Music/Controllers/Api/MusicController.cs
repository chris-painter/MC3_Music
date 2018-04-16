using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using MC3_Music.Models;
using MC3_Music.Context;
using MC3_Music.Dtos;
using AutoMapper;

namespace MC3_Music.Controllers.Api
{
    public class MusicController : ApiController
    {
        private ApplicationDataContext _context;
        public MusicController()
        {
            _context = new ApplicationDataContext();
        }
        //GET /api/music
        public IEnumerable<AlbumDto> GetAlbums()
        {
            return _context.Albums.ToList().Select(Mapper.Map<Album, AlbumDto>);
        }

        // GET /api/music/1
        public AlbumDto GetAlbum(int id)
        {
            var album = _context.Albums.SingleOrDefault(a => a.Id == id);

            if(album == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return Mapper.Map<Album, AlbumDto>(album);
        }

        // POST /api/msuic
        [HttpPost]
        public AlbumDto CreateAlbum(AlbumDto albumDto)
        {
            if(!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var album = Mapper.Map<AlbumDto, Album>(albumDto);
            _context.Albums.Add(album);
            _context.SaveChanges();

            albumDto.Id = album.Id;
            return albumDto;
        }

        //PUT /api/music/1
        [HttpPut]
        public void UpdateCustomer(int id, AlbumDto albumDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var albumInDb = _context.Albums.SingleOrDefault(a => a.Id == id);

            if(albumInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map<AlbumDto, Album>(albumDto, albumInDb);
            albumInDb.Title = albumDto.Title;
            albumInDb.Price = albumDto.Price;
            albumInDb.ImageURL = albumDto.ImageURL;
            albumInDb.Artist = albumDto.Artist;
            albumInDb.Stock = albumDto.Stock;
            albumInDb.Genre = albumDto.Genre;
            albumInDb.Rating = albumDto.Rating;

            _context.SaveChanges();
        }

        // DELETE /api/album/1
        [HttpDelete]
        public void DeleteAlbum(int id)
        {
            var albumInDb = _context.Albums.SingleOrDefault(a => a.Id == id);

            if (albumInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Albums.Remove(albumInDb);
            _context.SaveChanges();
        }
    }
}
