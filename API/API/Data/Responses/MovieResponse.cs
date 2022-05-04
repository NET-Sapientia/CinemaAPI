using API.Data.Models;

namespace API.Data.Responses
{
    public class MovieResponse
    {
        public Movie? Movie { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
    }
}
