namespace SW.NotationService.Web.RequestModels
{
    using System;

    public class NotationGetRequestResult
    {
        public string Id { get; set; }

        public int Cursor { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string SongName { get; set; }

        public string ArtistName { get; set; }

        public int DeadTimeMs { get; set; }

        public int DurationMs { get; set; }

        public Boolean Private { get; set; }

        public string TranscriberId { get; set; }

        public string ThumbnailUrl { get; set; } = null;

        public string VideoUrl { get; set; } = null;

        public string MusicXmlUrl { get; set; } = null;
    }
}
