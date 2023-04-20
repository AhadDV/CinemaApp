
using CinemaApp.App.Services.Interfaces;
using CinemaApp.Core.Models;
using CinemaApp.Data.Repositories;

namespace CinemaApp.App.Services.Implementations
{
    internal class HallService:IHallService
    {
        private readonly HallRepository _HallRepository = new HallRepository();
        public void Create()
        {
            Hall hall = new Hall();
            Console.WriteLine("Add name");
            hall.Name = Console.ReadLine();
            Console.WriteLine("Add limit");
            hall.Limit = int.Parse(Console.ReadLine());
            _HallRepository.Create(hall);
        }

        public void Delete()
        {
            Console.WriteLine("enter id");
            int.TryParse(Console.ReadLine(), out int id);

            Hall Hall = _HallRepository.Get(x=>x.Id==id);

            if (Hall == null)
            {
                Console.WriteLine("Hall not found");
            }
            else
            {
                _HallRepository.Delete(Hall);
                Console.WriteLine("Hall deleted");
            }

        }

        public void Get()
        {
            Console.WriteLine("enter id");
            int.TryParse(Console.ReadLine(), out int id);

            Hall Hall = _HallRepository.Get(x=>x.Id==id);

            if (Hall == null)
            {
                Console.WriteLine("Hall not found");
            }
            else
            {
                Console.WriteLine(Hall);
            }
        }

        public void GetAll()
        {
            List<Hall> Halls = _HallRepository.GetALl();

            foreach (var item in Halls)
            {
                Console.WriteLine(item);
            }
        }

        public void Update()
        {
            Console.WriteLine("enter id");
            int.TryParse(Console.ReadLine(), out int id);

            Hall Hall = _HallRepository.Get(x=>x.Id==id);

            if (Hall == null)
            {
                Console.WriteLine("Hall not found");
            }
            else
            {
                Console.WriteLine("Add Name");
                Hall.Name = Console.ReadLine();
                Console.WriteLine("Add Price");
                Hall.Limit = int.Parse(Console.ReadLine());
            }
        }
    }
}
