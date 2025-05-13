using BandsApp.Web.Models;

namespace BandsApp.Web.Services
{
    public class BandService
    {
        List<Band> bands =
    [
        new Band { Id = 1, Name = "Queen", Description = "A British rock band formed in 1970, known for their theatrical live performances and the legendary voice of Freddie Mercury. Their music spans genres, with hits like \"Bohemian Rhapsody\" and \"We Will Rock You,\" making them one of the most successful and beloved bands of all time.", ImageUrl = "/images/queen.jpg", VideoAddress = "https://www.youtube.com/embed/fJ9rUzIMcZQ?si=hFNKb_FsrMLoIxE1", Albums = { "A Night at the Opera", "The Game", "News of the World" } },
        new Band { Id = 2, Name = "Beatles", Description = "A British rock band formed in 1960, often regarded as the most influential band in history. Their innovative music and cultural impact reshaped pop and rock music, with iconic albums like \"Sgt. Pepper's Lonely Hearts Club Band\" and \"Abbey Road.\"", ImageUrl = "/images/beatles.jpg", VideoAddress = "https://www.youtube.com/embed/CGj85pVzRJs?si=6ltuaQgdZMgYmHRF", Albums = { "Please Please Me", "A Hard Day's Night", "Sgt. Pepper's Lonely Hearts Club Band" } },
        new Band { Id = 3, Name = "Aerosmith", Description = "An American rock band formed in 1970, known for their high-energy performances and hits like \"Dream On\" and \"Sweet Emotion.\" They're often called the \"Bad Boys from Boston\" and are famous for their blend of hard rock, blues, and ballads.", ImageUrl = "/images/aerosmith.jpg", VideoAddress = "https://www.youtube.com/embed/NMNgbISmF4I?si=_NNpviQ3pudL7PgY", Albums = { "Toys in the Attic", "Rocks", "Permanent Vacation" } }
    ];

        public Band[] GetAllBands() => [.. bands.OrderBy(o => o.Name)];


        public Band? GetBandById(int id) => bands
           .SingleOrDefault(o => o.Id == id);
    }
}