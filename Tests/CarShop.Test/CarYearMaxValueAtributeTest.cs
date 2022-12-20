using CarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Test
{
    public class CarYearMaxValueAtributeTest
    {
        [Fact]
        public void YearCarTest()
        {
            var car = new Car();

            car.Year = 2023;

        }

    }
}
