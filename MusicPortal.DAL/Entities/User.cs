namespace MusicPortal.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Login { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public int? AccessLevel { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
        public User()
        {
            this.Songs = new HashSet<Song>();
        }

    }
}
