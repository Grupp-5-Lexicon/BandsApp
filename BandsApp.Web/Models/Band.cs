﻿namespace BandsApp.Web.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VideoAddress { get; set; }
        public string ImageUrl { get; set; }

        public List<string> Albums { get; set; } = new List<string>();
    }
}
