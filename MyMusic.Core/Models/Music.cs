namespace Mhr.Core.Models
{
    public class Music : BaseEntity
    {
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}