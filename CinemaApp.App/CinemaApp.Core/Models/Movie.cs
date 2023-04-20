
using CinemaApp.Core.Models.Base;

namespace CinemaApp.Core.Models
{
    public class Movie:BaseModel
    {
        private static int _id;
        public string Name { get; set; }
        public double Price { get; set; }
        public double Review { get; set; }

        public Movie()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Price} {Review}";
        }
    }
}
