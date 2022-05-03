using API.Data.Models;

namespace API.Data.Responses
{
    public class ActorResponse
    {
        public Actor? Algorithm { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
    }
}
