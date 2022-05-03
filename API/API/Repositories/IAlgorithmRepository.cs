using API.Data.Models;

namespace API.Repositories
{
    public interface IAlgorithmRepository
    {
        public Task<Actor> AddNewActor(Actor newActor);
        public Task<Producer> AddNewProducer(Producer newProducer);
        public Task<Movie> AddNewMovie(Movie newMovie);
        public Task<Cinema> AddNewCinema(Cinema newCinema);
    }
}
