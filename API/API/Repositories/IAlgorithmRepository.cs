using API.Data.Models;

namespace API.Repositories
{
    public interface IAlgorithmRepository
    {
        public Task<Actor> AddNewActor(Actor newActor);
        public Task<Producer> AddNewProducer(Producer newProducer);
        public Task<Movie> AddNewMovie(Movie newMovie);
        public Task<Cinema> AddNewCinema(Cinema newCinema);

        //GET all
        public Task<IEnumerable<Actor>> GetActors();

        public Task<IEnumerable<Cinema>> GetCinemas();

        public Task<IEnumerable<Movie>> GetMovies();

        public Task<IEnumerable<Producer>> GetProducers();

        //GET by id

        public Task<IEnumerable<Actor>> GetActor(int id);

        public Task<IEnumerable<Cinema>> GetCinema(int id);

        public Task<IEnumerable<Movie>> GetMovie(int id);

        public Task<IEnumerable<Producer>> GetProducer(int id);

        //PUT/UPDATE

        public Task<Actor> PutActor(int id, Actor actor);

        
    }
}
