using AspCRUD.Models;

namespace AspCRUD.Interfaces
{
    public interface IDataProvider
    {
        public List<Song> GetAll();

        public Song GetById(int id);

        public bool Post(Song song);

        public Song Update(int id);

        public bool Delete(int id);
    }
}
