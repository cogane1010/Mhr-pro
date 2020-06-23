using Mhr.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mhr.Core.Repositories
{
    public interface IArtistRepository : IRepository<Artist>
    {
        Task<IEnumerable<Artist>> GetAllWithMusicsAsync();
        Task<Artist> GetWithMusicsByIdAsync(int id);
    }
}