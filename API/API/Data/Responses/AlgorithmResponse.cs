using API.Data.Models;

namespace API.Data.Responses
{
    public class AlgorithmResponse
    {
        public Algorithm? Algorithm { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
    }
}
