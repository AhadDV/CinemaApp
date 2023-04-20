using CinemaApp.Core.Models.Base;

namespace CinemaApp.Core.Models
{
    public class Hall:BaseModel
    {
        private static int _id;
        public string Name { get; set; }    
        public int Limit { get; set; }

        public Hall()
        {
            _id++;
            Id= _id;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Limit}";
        }
    }
}
