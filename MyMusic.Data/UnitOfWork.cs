using Mhr.Core;
using Mhr.Core.Repositories;
using Mhr.Data.Repositories;
using System.Threading.Tasks;

namespace Mhr.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MhrDbContext _context;
        private MusicRepository _musicRepository;
        private ArtistRepository _artistRepository;

        public UnitOfWork(MhrDbContext context)
        {
            this._context = context;
        }

        public IArtistRepository Artists => _artistRepository = _artistRepository ?? new ArtistRepository(_context);

        public IMusicRepository Musics => _musicRepository = _musicRepository ?? new MusicRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}