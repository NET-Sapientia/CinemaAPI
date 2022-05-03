using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static API.Data.Models.Enums;

namespace API.Data.Models
{
    public class Algorithm
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Algorithm name")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public AlgorithmType Type { get; set; }
        public string? Icon { get; set; }
        public string? Url { get; set; }
        public string? AlgorithmNickname { get; set; }
        public bool? IsPublished { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
