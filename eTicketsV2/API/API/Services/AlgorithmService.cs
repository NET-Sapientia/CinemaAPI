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


        public async Task<AlgorithmResponse> AddNewAlgorithm(AlgorithmRequest newAlgorithm)
        {
            Algorithm algorithm = new Algorithm()
            {
                Name = newAlgorithm.Name,
                Description = newAlgorithm.Description,
                Type = newAlgorithm.Type,
                AlgorithmNickname = newAlgorithm.AlgorithmNickname,
                Icon = newAlgorithm.Icon,
                Url = newAlgorithm.Url,
                IsPublished = false,
                CreationDate = DateTime.Now
            };

            AlgorithmResponse response = new AlgorithmResponse();


            try
            {
                response.Algorithm = await _algorithmRepository.AddNewAlgorithm(algorithm);
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
