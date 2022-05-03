using API.Data.Models;
using API.Data.Requests;
using API.Data.Responses;
using API.Exceptions;
using API.Repositories;
using API.Utils;
using System.ComponentModel;

namespace API.Services
{
    public class AlgorithmService : IAlgorithmService
    {
        private readonly IAlgorithmRepository _algorithmRepository;

        public AlgorithmService(IAlgorithmRepository algorithmRepository)
        {
            _algorithmRepository = algorithmRepository;
        }

        public async Task<ActorResponse> AddNewActor(ActorRequest newActor)
        {
            Actor actor = new Actor()
            {
                Id = newActor.Id,
                ProfilePictureURL = newActor.ProfilePictureURL,
                FullName = newActor.FullName,
                Bio = newActor.FullName
            };

            ActorResponse response = new ActorResponse();

            try
            {
                response.Actor = await _algorithmRepository.AddNewActor(actor);
                if (response.Actor != null)
                {
                    response.Code = 200;
                    response.Message = APISuccessCodes.ADD_ALGORITHM_SUCCESS;
                }
                return response;
            }
            catch (AddRequestException ex)
            {
                throw new AddException(ex.Message);
            }

        }

        public Task<MovieResponse> AddNewMovie(MovieRequest newActor)
        {

        }

        public Task<CinemaResponse> AddNewCinema(CinemaRequest newActor)
        {

        }

        public Task<ProducerResponse> AddNewProducer(ProducerRequest newActor)
        {

        }


    }
}
