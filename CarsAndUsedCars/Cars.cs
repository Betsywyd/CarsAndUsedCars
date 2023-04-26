using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCars
{
    class Cars
    {
        public static List<Cars> CarsList=new List<Cars>();
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Cars(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }
        public Cars() 
        {
        }
        public override string ToString()
        {

            return (string.Format("{0,-10}{1,-10}{2,-10}{3,-10}", Make, Model, Year, Price));
        }

        public static void ListCars(List<Cars> list)
        {
            for(int i=0; i < list.Count; i++)
            {
                Console.WriteLine((i+1)+". " + list[i]);
            }
        }
     
        public static void Remove(int x)
        {
            CarsList.RemoveAt(x);
            for(int i=0;i<CarsList.Count;i++)
            {
                Console.WriteLine((i + 1) + ". " + CarsList[i]);
            }
            
        }

    }
}
