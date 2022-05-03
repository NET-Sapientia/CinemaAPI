using API.Data;
using API.Data.Models;
using API.Exceptions;
using API.Utils;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class AlgorithmRepository : IAlgorithmRepository
    {

        private readonly AppDbContext _context;

        public AlgorithmRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Actor> AddNewActor(Actor newActor)
        {
            try
            {
                var addResponse =  _context.Actors.Add(newActor);
                await _context.SaveChangesAsync();
                
                return addResponse.Entity;
            }
            catch (Exception ex)
            {
                throw new AddRequestException(ex.Message);
            }
        }

        public async Task<Producer> AddNewProducer(Producer newProducer)
        {
            try
            {
                var addResponse = _context.Producers.Add(newProducer);
                await _context.SaveChangesAsync();

                return addResponse.Entity;
            }
            catch (Exception ex)
            {
                throw new AddRequestException(ex.Message);
            }
        }

        public async Task<Movie> AddNewMovie(Movie newMovie)
        {
            try
            {
                var addResponse = _context.Movies.Add(newMovie);
                await _context.SaveChangesAsync();

                return addResponse.Entity;
            }
            catch (Exception ex)
            {
                throw new AddRequestException(ex.Message);
            }
        }

        public async Task<Cinema> AddNewCinema(Cinema newCinema)
        {
            try
            {
                var addResponse = _context.Cinemas.Add(newCinema);
                await _context.SaveChangesAsync();

                return addResponse.Entity;
            }
            catch (Exception ex)
            {
                throw new AddRequestException(ex.Message);
            }
        }

        public async Task<IEnumerable<Actor>> GetActors()
        {
            return _context.Actors;

        }

        public async Task<IEnumerable<Actor>> GetActor(int id)
        {
            return _context.Actors.AsQueryable().Where(a => a.Id == id);

        }

        public async Task<IEnumerable<Cinema>> GetCinemas()
        {
            return _context.Cinemas;

        }

        public async Task<Actor> PutActor(int id, Actor actor)
        {

            int count = await _context.Actors.AsQueryable().Where(it => it.Id == id).CountAsync();
            if (count != 1)
            {
                throw new Exception("The Actor is not in the database");
            }
            var result = _context.Actors.Update(actor);
            _context.SaveChanges();
            return actor;

        }
    }
}
