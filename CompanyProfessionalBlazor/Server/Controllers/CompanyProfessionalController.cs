using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyProfessionalBlazor.Server.Controllers // 1 ºfazer as static List< e os httpget e getsingle, testar api/..., depois fazer @page
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyProfessionalController : ControllerBase
    {
        public static List<Place> places = new List<Place> 
        {    
            new Place { Id = 1, Name = "Home Office"},
            new Place { Id = 2, Name = "Company"}
        };

        public static List<CompanyProfessional> professionals = new List<CompanyProfessional>
        {
            new CompanyProfessional
            {
                Id = 1,
                Name = "James",
                Age = "28",
                Position = "Trainee",
                Place = places[0],
                PlaceId = 1
            },

            new CompanyProfessional
            {
                Id = 2,
                Name = "Anne",
                Age = "36",
                Position = "Senior",
                Place = places[1],
                PlaceId = 2
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<CompanyProfessional>>> GetCompanyProfessionals()
        {
            return Ok(professionals);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyProfessional>> GetSingleProfessional(int id)
        {
            var professional = professionals.FirstOrDefault(h => h. Id == id);
            if (professional == null)
            {
                return NotFound("No Professional Here. :/");
            }
            return Ok(professional);
        }

        [HttpGet("places")] //ápós acrescentar o Id=1/Id=2 e TESTAR, após instalar nugets, depois fazer pasta Data com DataContext em .server e fazer um ctor dentro dele
        public async Task<ActionResult<CompanyProfessional>> GetPlaces()
        { 
            return Ok(places);
        }
    }
}
