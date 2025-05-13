using BandsApp.Web.Models;

namespace BandsApp.Web.Services
{
    public class BandService
    {
        List<Band> bands =
    [
        new Band { Id = 1, Name = "Queen", Description = "Queen is a band.", VideoAddress = "https://www.youtube.com/embed/fJ9rUzIMcZQ?si=hFNKb_FsrMLoIxE1" },
        new Band { Id = 2, Name = "Beatles", Description = "Beatles is a band.", VideoAddress = "https://www.youtube.com/embed/CGj85pVzRJs?si=6ltuaQgdZMgYmHRF" },
        new Band { Id = 3, Name = "Aerosmith", Description = "Aerosmith is a band.", VideoAddress = "https://www.youtube.com/embed/NMNgbISmF4I?si=_NNpviQ3pudL7PgY" }
    ];

        public Band[] GetAllBands() => [.. bands.OrderBy(o => o.Name)];


        public Band? GetBandById(int id) => bands
           .SingleOrDefault(o => o.Id == id);
    }
}
