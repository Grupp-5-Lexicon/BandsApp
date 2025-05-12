using BandsApp.Web.Models;

namespace BandsApp.Web.Services
{
    public class BandService
    {
        List<Band> bands =
    [
        new Band { Id = 1, Name = "Queen", Description = "Queen is a band." },
        new Band { Id = 2, Name = "Beatles", Description = "Beatles is a band." },
        new Band { Id = 3, Name = "Aerosmith", Description = "Aerosmith is a band." }
    ];

        public Band[] GetAllBands() => [.. bands.OrderBy(o => o.Name)];


        public Band? GetBandById(int id) => bands
           .SingleOrDefault(o => o.Id == id);
    }
}
