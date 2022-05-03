﻿using static API.Data.Models.Enums;

namespace API.Data.Requests
{
    public class CinemaRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public AlgorithmType Type { get; set; }
        public string? Icon { get; set; }
        public string? Url { get; set; }
        public string? AlgorithmNickname { get; set; }
    }
}