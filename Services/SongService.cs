using AspCRUD.Interfaces;
using AspCRUD.Models;

namespace AspCRUD.Services
{
    public class SongService : ISongService
    {
        private readonly IDataProvider _provider;

        public SongService(IDataProvider dataProvider)
        {
            _provider = dataProvider;
        }

        public List<Song> GetAll()
        {
            return _provider.GetAll();
        }

        public Song GetById(int id)
        {
            return _provider.GetById(id);
        }

        public bool Post(Song song)
        {
            if(song.Id > 0)
            {
                _provider.Post(song);
                return true;
            }
            return false;
        }

        public Song Update(int id)
        {
            _provider.Update(id);
            return _provider.GetById(id);
        }

        public bool Delete(int id)
        {
            if( id > 0)
            {
                _provider.Delete(id);
                return true;
            }
            return false;
        }
    }
}
