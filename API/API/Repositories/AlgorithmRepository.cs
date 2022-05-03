using API.Data;
using API.Data.Models;
using API.Exceptions;
using API.Utils;

namespace API.Repositories
{
    public class AlgorithmRepository : IAlgorithmRepository
    {

        private readonly AppDbContext _context;

        public AlgorithmRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Algorithm> AddNewAlgorithm(Algorithm newAlgorithm)
        {
            try
            {
                var addResponse =  _context.Algorithms.Add(newAlgorithm);
                await _context.SaveChangesAsync();
                
                return addResponse.Entity;
            }
            catch (Exception ex)
            {
                throw new AddRequestException(ex.Message);
            }
        }
    }
}
