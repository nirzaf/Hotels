using System.ComponentModel.DataAnnotations;

namespace Hotels.Model
{
    public class CreateCountryDto
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Country Short Name is too long")]
        public string ShortName { get; set; }
    }
}