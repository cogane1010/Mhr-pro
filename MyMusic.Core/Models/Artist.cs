using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mhr.Core.Models
{
    public class Artist : BaseEntity
    {
        public Artist()
        {
            Musics = new Collection<Music>();
        }

        public string Name { get; set; }
        public ICollection<Music> Musics { get; set; }
    }
}