using System.ComponentModel.DataAnnotations;

namespace MyAPI.Models
{
    public class Model
    {

        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }
        
    }
}