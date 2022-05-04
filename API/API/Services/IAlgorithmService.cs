using API.Data.Models;
using API.Data.Requests;
using API.Data.Responses;

namespace API.Services
{
    public interface IAlgorithmService
    {

        public Task<ActorResponse> AddNewActor(ActorRequest newActor);

        public Task<MovieResponse> AddNewMovie(MovieRequest newActor);

        public Task<CinemaResponse> AddNewCinema(CinemaRequest newActor);

        public Task<ProducerResponse> AddNewProducer(ProducerRequest newActor);

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

        //PUT

        public Task<Actor> PutActor(int id, Actor actor);

        //DELETE
        public Task<IEnumerable<Actor>> DeleteActor(int id);
    }
    
}
