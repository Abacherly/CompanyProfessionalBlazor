using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProfessionalBlazor.Shared
{
    public class CompanyProfessional
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Age { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public Place? Place { get; set; }
        public int PlaceId { get; set; }
    }
}
