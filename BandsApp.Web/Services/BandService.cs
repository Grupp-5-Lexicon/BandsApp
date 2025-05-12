namespace BandsApp.Web.Services
{
    public class BandService
    {
        List<Band> Bands =
    [
        new Company { Id = 1, Name = "Company A", Description = "awdadw" },
        new Company { Id = 2, Name = "Company B" Description = "nawdaw" },
        new Company { Id = 3, Name = "Company C" Description = "efsef" }
    ];

        public Band[] GetAll() => [.. bands.OrderBy(o => o.Name)];


        public Band? GetById(int id) => bands
           .SingleOrDefault(o => o.Id == id);
    }
}
