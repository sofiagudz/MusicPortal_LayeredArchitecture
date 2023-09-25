using System.ComponentModel.DataAnnotations;

namespace MusicPortal.DAL.Entities
{
    public class Song
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Album { get; set; }

        public int? ReleaseYear { get; set; }

        public string? Video { get; set; }

        public virtual User Publisher { get; set; }

        public int StyleId { get; set; }

        public virtual Style Style { get; set; }

        public int SingerId { get; set; }

        public virtual Singer Singer { get; set; }

    }
}
