using System.ComponentModel.DataAnnotations;

namespace CafeteriaFacul_net7.Data
{
    public class Produto
    {
        [Key]
        public int? Id { get; set; } 

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; } 

        [Required]
        [MaxLength(200)]
        public string? Description { get; set; } 

        [Required]
        [MaxLength(100)]
        public string? ImageSource { get; set; } 
    }
}
