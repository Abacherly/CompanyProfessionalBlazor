
namespace CompanyProfessionalBlazor.Client.Services.CompanyProfessionalService
{
    public interface ICompanyProfessionalService //Depois da lista implementar a interface, fazer um ctor para _http
    {
        List<CompanyProfessional> Professionals { get; set; }
        List<Place> Places { get; set; }
        Task GetPlaces();
        Task GetCompanyProfessionals();
        Task<CompanyProfessional> GetSingleProfessional(int id);
    }
}
