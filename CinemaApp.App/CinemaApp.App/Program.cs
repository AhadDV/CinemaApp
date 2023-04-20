
using CinemaApp.App.Services.Implementations;
using CinemaApp.App.Services.Interfaces;

IHallService hallService=new HallService();
IMovieService movieService=new MovieService();

Console.WriteLine("0.Close");
Console.WriteLine("1.Hall Create");
Console.WriteLine("2.Hall Update");
Console.WriteLine("3.Hall Delete");
Console.WriteLine("4.Hall ShowAll");
Console.WriteLine("5.Hall ShowById");
Console.WriteLine("6.Movie Create");
Console.WriteLine("7.Movie Update");
Console.WriteLine("8.Movie Delete");
Console.WriteLine("9.Movie ShowAll");
Console.WriteLine("10.Movie ShowById");

string Request=Console.ReadLine();

while (Request != "0")
{
    switch (Request)
    {
        case "1":
            Console.Clear();
            hallService.Create();
            break;
        case "2":
            Console.Clear();

            hallService.Update();
            break;
        case "3":
            Console.Clear();

            hallService.Delete();

            break;
        case "4":
            Console.Clear();

            hallService.GetAll();

            break;
        case "5":
            Console.Clear();

            hallService.Get();
            break;
        case "6":
            movieService.Create();
            break;
        case "7":
            Console.Clear();

            movieService.Update();

            break;
        case "8":
            Console.Clear();

            movieService.Delete();

            break;
        case "9":
            movieService.GetAll();

            break;
        case "10":
            Console.Clear();

            movieService.Get();

            break;
        default :
            Console.Clear();

            Console.WriteLine("select valid option");
            break;
    }

    Console.WriteLine("0.Close");
    Console.WriteLine("1.Hall Create");
    Console.WriteLine("2.Hall Update");
    Console.WriteLine("3.Hall Delete");
    Console.WriteLine("4.Hall ShowAll");
    Console.WriteLine("5.Hall ShowById");
    Console.WriteLine("6.Movie Create");
    Console.WriteLine("7.Movie Update");
    Console.WriteLine("8.Movie Delete");
    Console.WriteLine("9.Movie ShowAll");
    Console.WriteLine("10.Movie ShowById");

     Request = Console.ReadLine();
}