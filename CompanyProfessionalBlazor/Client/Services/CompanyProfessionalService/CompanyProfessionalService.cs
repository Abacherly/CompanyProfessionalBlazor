using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;

namespace CompanyProfessionalBlazor.Client.Services.CompanyProfessionalService
{
    public class CompanyProfessionalService : ICompanyProfessionalService // implementar no program(builder), no _imports e injetar no @page, após fazer lista no Iservice
    {
        private readonly HttpClient _http;

        public CompanyProfessionalService(HttpClient http) //Fazer depois de implementar
        {
            _http = http;
        }
        public List<CompanyProfessional> Professionals { get ; set ; }
        public List<Place> Places { get ; set ; }

        public async Task GetCompanyProfessionals() //primeiro a ser feito após _http, vai pro 1º.razor
        {
            var result = await _http.GetFromJsonAsync<List<CompanyProfessional>>("api/companyprofessional");
            if (result != null)
            {
                Professionals = result;
            }
        }

        public async Task GetPlaces() // após vai em controller criar método Get("places")
        {
            var result = await _http.GetFromJsonAsync<List<Place>>("api/companyprofessional/places");
            if (result != null)
                Places = result;
        }

        public async Task<CompanyProfessional> GetSingleProfessional(int id) //após vai em 2°.razor e cria novo componente "CREATE A..."
        {
            var result = await _http.GetFromJsonAsync<CompanyProfessional>($"api/companyprofessional/{id}");
            if (result != null)
                return result;
            throw new Exception("Produto não encontrado!");
        }
    }
}
