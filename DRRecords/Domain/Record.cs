namespace DRRecords.Domain
{
    public class Record
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        public void Validate()
        {
            {
                if (Title == null)
                    throw new ArgumentNullException(nameof(Title), "Title is null");
                if (Title.Length < 1)
                    throw new ArgumentException("Title must be at least 2 characters: " + Title);
                if (Artist.Length < 1)
                    throw new ArgumentOutOfRangeException(nameof(Artist), "Artist must be at least 2 characters: " + Artist);
                if(Artist == null)
                    throw new ArgumentNullException(nameof(Artist), "Artist is null");
            }
        }
    }
}
