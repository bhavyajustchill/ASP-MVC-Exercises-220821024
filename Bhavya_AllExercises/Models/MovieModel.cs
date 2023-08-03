using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bhavya_AllExercises.Models
{
    public class MovieModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int DurationMinutes { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public float Rating { get; set; }
        public string PlotSummary { get; set; }
        public decimal BoxOfficeCollection { get; set; }
        public string Awards { get; set; }
        public string Cast { get; set; }
        public string Producer { get; set; }
        public string ScreenplayWriter { get; set; }
        public string Cinematographer { get; set; }
        public string FilmEditor { get; set; }
        public string CostumeDesigner { get; set; }
        public string MusicComposer { get; set; }
        public string SpecialEffectsTeam { get; set; }
        public string ProductionCompany { get; set; }
        public string DistributorCompany { get; set; }
        public string FilmingLocations { get; set; }
        public DateTime FilmingStartDate { get; set; }
        public DateTime FilmingEndDate { get; set; }
        public decimal Budget { get; set; }
        public string OfficialWebsite { get; set; }
        public string TrailersLinks { get; set; }
        public int TotalNumberOfScenes { get; set; }
        public string ProductionStatus { get; set; }
        public bool IsColor { get; set; }
        public bool Is3D { get; set; }
        public string MPAARating { get; set; }
        public float IMDbRating { get; set; }
        public float RottenTomatoesRating { get; set; }
        public float MetacriticRating { get; set; }
        public string FilmFestivalsParticipated { get; set; }
        public bool IsAwardWinner { get; set; }
        public string ReleaseFormats { get; set; }
        public bool IsSequelOrPrequel { get; set; }
        public string OriginalBookAuthor { get; set; }
        public string FranchiseName { get; set; }
        public decimal MerchandisingSales { get; set; }
        public string MerchandisingPartners { get; set; }
        public string SoundtrackAlbumName { get; set; }
        public string SoundtrackComposer { get; set; }
        public string BehindTheScenesCrew { get; set; }
    }
}