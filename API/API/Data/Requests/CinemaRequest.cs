using static API.Data.Models.Enums;

namespace API.Data.Requests
{
    public class CinemaRequest
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
