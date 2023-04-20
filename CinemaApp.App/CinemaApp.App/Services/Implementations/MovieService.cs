

using CinemaApp.App.Services.Interfaces;
using CinemaApp.Core.Models;
using CinemaApp.Data.Repositories;

namespace CinemaApp.App.Services.Implementations
{
    internal class MovieService : IMovieService
    {
        private readonly MovieRepository _movieRepository = new MovieRepository();
        public void Create()
        {
            Movie movie = new Movie();
            Console.WriteLine("Add name");
            movie.Name = Console.ReadLine();
            Console.WriteLine("Add price");
            movie.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Add Review");
            movie.Review = double.Parse(Console.ReadLine());
            _movieRepository.Create(movie);
        }

        public void Delete()
        {
            Console.WriteLine("enter id");
            int.TryParse(Console.ReadLine(), out int id);

            Movie movie = _movieRepository.Get(x=>x.Id==id);

            if (movie == null)
            {
                Console.WriteLine("movie not found");
            }
            else
            {
                _movieRepository.Delete(movie);
                Console.WriteLine("movie deleted");
            }

        }

        public void Get()
        {
            Console.WriteLine("enter id");
            int.TryParse(Console.ReadLine(), out int id);

            Movie movie = _movieRepository.Get(x=>x.Id==id);

            if (movie == null)
            {
                Console.WriteLine("movie not found");
            }
            else
            {
                Console.WriteLine(movie);
            }
        }

        public void GetAll()
        {
            List<Movie> movies = _movieRepository.GetALl();

            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }
        }

        public void Update()
        {
            Console.WriteLine("enter id");
            int.TryParse(Console.ReadLine(), out int id);

            Movie movie = _movieRepository.Get(x=>x.Id==id);

            if (movie == null)
            {
                Console.WriteLine("movie not found");
            }
            else
            {
                Console.WriteLine("Add Name");
                movie.Name = Console.ReadLine();
                Console.WriteLine("Add Price");
                movie.Price=double.Parse(Console.ReadLine());
            }
        }
    }
}
