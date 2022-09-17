namespace AspCRUD.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public DateTime RealezeDate { get; set; }

        public string Duration { get; set; }

        public bool IsFavorite{ get; set; }
    }
}
