using API.Data.Requests;
using API.Data.Responses;

namespace API.Services
{
    public interface IAlgorithmService
    {
        public Task<AlgorithmResponse> AddNewAlgorithm(AlgorithmRequest newAlgorithm);

    }
}
