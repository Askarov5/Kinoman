using AutoMapper;
using Kinoman.DTOS;
using Kinoman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kinoman.Controllers.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET api/movies
        public IHttpActionResult GetMovies()
        {
            return Ok(_context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>));
        }

        //GET api/movies/1
        public IHttpActionResult GetMovie(int Id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == Id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        //POST api/movies
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri+ "/" + movie.Id), movieDto);
        }

        //PUT api/movies/1
        [HttpPut]
        public void UpdateMovie(int Id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == Id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(movieDto, movieInDb);

            _context.SaveChanges();
        }

        //DELETE 
        [HttpDelete]
        public void DeleteMovie(int Id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == Id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();
        }
    }
}
