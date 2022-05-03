using API.Data.Models;

namespace API.Repositories
{
    public interface IAlgorithmRepository
    {
        public Task<Algorithm> AddNewAlgorithm(Algorithm newAlgorithm);
    }
}
