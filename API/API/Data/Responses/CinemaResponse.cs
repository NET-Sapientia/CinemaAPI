using API.Data.Models;

namespace API.Data.Responses
{
    public class CinemaResponse
    {
        public Cinema? Algorithm { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
    }
}
