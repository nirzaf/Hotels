using System.ComponentModel.DataAnnotations;

namespace Hotels.Model
{
    public class CountryDto : CreateCountryDto
    {
        [Key] public int Id { get; set; }
    }
}