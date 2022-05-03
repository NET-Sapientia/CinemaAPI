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


        public async Task<AlgorithmResponse> AddNewActor(AlgorithmRequest newActor)
        {
            Algorithm algorithm = new Algorithm()
            {
                Name = newActor.Name,
                Description = newActor.Description,
                Type = newActor.Type,
                AlgorithmNickname = newActor.AlgorithmNickname,
                Icon = newActor.Icon,
                Url = newActor.Url,
                IsPublished = false,
                CreationDate = DateTime.Now
            };

            AlgorithmResponse response = new AlgorithmResponse();


            try
            {
                response.Algorithm = await _algorithmRepository.AddNewActor(newActor);
                if (response.Algorithm != null)
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
    }
}
