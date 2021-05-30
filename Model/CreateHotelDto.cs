using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotels.Model
{
    public class CreateHotelDto
    {
        [Required]
        [StringLength(maximumLength:150,ErrorMessage = "Hotel Name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Address is too long")]
        public string Address { get; set; }
        [Required]
        [Range(1,5,ErrorMessage = "Rating Should be between 1 to 5")]
        public double Rating { get; set; }

        public int CountryId  { get; set; }
    }
}
