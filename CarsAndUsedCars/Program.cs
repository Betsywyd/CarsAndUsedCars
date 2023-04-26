using System.Reflection;

namespace CarsAndUsedCars
{
    class Program
    {
        static void Main()

        {
            Console.WriteLine("Welcome to Grant Chirpus’ Used Car Emporium!");
            Console.WriteLine();
            List<Cars> CarsList = new List<Cars>();
            Cars.CarsList.Add(new Cars("Nikolai", "Model S", 2017, 54999.90m));
            Cars.CarsList.Add(new Cars("Fourd", "Escapade", 2017, 31999.90m));
            Cars.CarsList.Add(new Cars("Chewie ", "Vette", 2017, 44989.95m));
            Cars.CarsList.Add(new UsedCars("Hyonda", "Prior", 2015, 31999.90m, 35987.6));
            Cars.CarsList.Add(new UsedCars("GC", "Chirpus", 2013, 8500.00m, 12345.0));
            Cars.CarsList.Add(new UsedCars("GC", "Witherell", 2016, 14450.00m, 3500.3));
            Cars.ListCars(Cars.CarsList);
            Console.WriteLine();
            Console.WriteLine("Which car would you like?");
            int index=int.Parse(Console.ReadLine());
            Console.WriteLine("This car detail: ");
            Console.WriteLine(Cars.CarsList[index-1]);
            Console.WriteLine();
            Console.WriteLine("Now cars list is:");
            Cars.Remove(index);

        }
    }
}