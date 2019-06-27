using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RottenUI.Data
{
    public static class MockRepository
    {
        public static IList<Movie> Movies { get; set; }
        static MockRepository()
        {
            Movies = new ObservableCollection<Movie>
            {
                new Movie()
                {
                    Title = "Zootopia",
                    ReleaseDate = "2016",
                    AudienceScore = 96,
                    TomatometerScore = 96,
                    PosterUrl = "https://image.tmdb.org/t/p/w185/bHXf0mrnnRthdWI9MuAMlPftnZK.jpg",
                    BackdropUrl = "https://image.tmdb.org/t/p/w780/qCQSWM3fhPjSAZEgCQu68LQXna0.jpg",
                    Info = "Determined to prove herself, Officer Judy Hopps, the first bunny on Zootopia's police force, jumps at the chance to crack her first case - even if it means partnering with scam-artist fox Nick Wilde to solve the mystery.",
                    Cast = new List<CastMember>()
                {
                    new CastMember() { Name="Ginnifer Goodwin", Role="Judy Hopps (voice)", ImageUrl="https://image.tmdb.org/t/p/w185/zioPX1VMA26ucdpvF9STz7m3l4j.jpg"},
                    new CastMember() { Name="Jason Bateman", Role="Nick Wilde (voice)", ImageUrl="https://image.tmdb.org/t/p/w185/ttzLpjvcLkvXyyTBpjmZw11tjlr.jpg"},
                    new CastMember() { Name="Shakira", Role="Gazelle (voice)", ImageUrl="https://image.tmdb.org/t/p/w185/lvpKTDdWUv61sty299uC8DQzVTX.jpg"},
                    new CastMember() { Name="Idris Elba", Role="Chief Bogo (voice)", ImageUrl="https://image.tmdb.org/t/p/w185/be1bVF7qGX91a6c5WeRPs5pKXln.jpg"},
                }
                }
            };
        }
    }

    public class Movie
    {
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public int AudienceScore { get; set; }
        public int TomatometerScore { get; set; }
        public string Info { get; set; }
        public List<CastMember> Cast { get; set; }
        public string PosterUrl { get; set; }
        public string BackdropUrl { get; set; }
    }

    public class CastMember
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string ImageUrl { get; set; }
    }
}
