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

    }
}
