using AspCRUD.Interfaces;
using AspCRUD.Models;

namespace AspCRUD.Infrastructure
{
    public class DataProvider : IDataProvider
    {
        private readonly List<Song> _allsongs;
        private int _idforpost = 0;

        public List<Song> GetAll()
        {
            return _allsongs;
        }

        public Song GetById(int id)
        {
            return _allsongs[id];
        }

        public bool Post(Song song)
        {
            Song song1 = new Song() { Author = "i am", Duration = "100", Id = _idforpost, IsFavorite = true, Name = "The Search", RealezeDate = DateTime.UtcNow };
            _idforpost++;
            _allsongs.Add(song1);
            return true;
        }

        public Song Update(int id)
        {
            _allsongs[id].Name = "updated";
            return _allsongs[id];
        }

        public bool Delete(int id)
        {
            _allsongs.RemoveAt(id);
            return true;
        }
    }
}
