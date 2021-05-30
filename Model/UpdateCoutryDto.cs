using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Model
{
    public class UpdateCoutryDto : CreateCountryDto
    {
        public IList<CreateHotelDto> Hotels { get; set; }
    }
}
