using static API.Data.Models.Enums;

namespace API.Data.Requests
{
    public class ActorRequest
    {
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
