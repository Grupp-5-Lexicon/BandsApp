using BandsApp.Web.Models;

namespace BandsApp.Web.Services
{
    public class BandService
    {
        List<Band> bands =
    [
        new Band { Id = 1, Name = "Company A", Description = "awdadw" },
        new Band { Id = 2, Name = "Company B", Description = "nawdaw" },
        new Band { Id = 3, Name = "Company C", Description = "efsef" }
    ];

        public Band[] GetAll() => [.. bands.OrderBy(o => o.Name)];


        public Band? GetById(int id) => bands
           .SingleOrDefault(o => o.Id == id);
    }
}
