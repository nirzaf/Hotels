using System.ComponentModel.DataAnnotations;
using Hotels.Data;

namespace Hotels.Model
{
    public class HotelDto : CreateHotelDto
    {
        [Key]
        public int Id { get; set; }
        public Country Country { get; set; }
    }
}