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

        public async Task<MovieResponse> AddNewMovie(MovieRequest newMovie)
        {
            Movie movie = new Movie()
            {
                Id = newMovie.Id,
                Name = newMovie.Name,
                Description = newMovie.Description,
                Price = newMovie.Price,
                ImageURL = newMovie.ImageURL,
                StartDate = newMovie.StartDate,
                EndDate = newMovie.EndDate,
                MovieCategory = newMovie.MovieCategory,
            };
            MovieResponse response = new MovieResponse();

            try
            {
                response.Movie = await _algorithmRepository.AddNewMovie(movie);
                if (response.Movie != null)
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

        public async Task<CinemaResponse> AddNewCinema(CinemaRequest newCinema)
        {
            Cinema cinema = new Cinema()
            {
                Id = newCinema.Id,
                Logo = newCinema.Logo,
                Name = newCinema.Name,
                Description = newCinema.Description,
            };
            CinemaResponse response = new CinemaResponse();

            try
            {
                response.Cinema = await _algorithmRepository.AddNewCinema(cinema);
                if (response.Cinema != null)
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


        public async Task<ProducerResponse> AddNewProducer(ProducerRequest newProducer)
        {
            Producer producer = new Producer()
            {
                Id = newProducer.Id,
                ProfilePictureURL = newProducer.ProfilePictureURL,
                FullName = newProducer.FullName,
                Bio = newProducer.Bio,
            };
            ProducerResponse response = new ProducerResponse();

            try
            {
                response.Producer = await _algorithmRepository.AddNewProducer(producer);
                if (response.Producer != null)
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

        public async Task<IEnumerable<Actor>> GetActors()
        {
            return await _algorithmRepository.GetActors();

        }

        public async Task<IEnumerable<Cinema>> GetCinemas()
        {
            return await _algorithmRepository.GetCinemas();

        }


    }
}

