using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCars
{
    class UsedCars:Cars
    {
        public double Mileage;
        public UsedCars(string Make, string Model, int Year, decimal Price,double Mileage) : base(Make,Model,Year,Price) 
        { 
        this.Mileage = Mileage;
        }

        public override string ToString()
        {
            return (string.Format("{0,-10}(usedcar){1}miles", base.ToString(),Mileage));
        }

    }
}
