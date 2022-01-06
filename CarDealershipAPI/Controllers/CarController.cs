using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        public List<Car> cars = new List<Car>
        {
            new Car("Fiat", "500x", 2018, "black"),
            new Car("GMC", "Denali 2500", 2021, "black"),
            new Car("Pontiac", "G6 Coupe", 2006, "grey"),
            new Car("VolksWagen", "Beetle", 2007, "yellow"),
            new Car("Cadillac", "Escalade", 2022, "black"),
            new Car("Lincoln", "Navigator", 2022, "red"),
            new Car("Tesla", "Model S", 2022, "white"),
            new Car("Tesla", "Model X", 2020, "grey"),
            new Car("Lamborghini", "Urus", 2021, "yellow"),
            new Car("Mercedes-Benz", "G Class", 2022, "white"),
        };

        [HttpGet]
        public List<Car> GetAllCars()
        {
            return cars;
        }

        [HttpGet("GetCar/{index}")]
        public Car GetCarByIndex(int index)
        {
            try
            {
                return cars[index];
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }
        [HttpGet("CarColor/{color}")]
        public List<Car> GetCarByColor(string color)
        {          
            try
            {
                return cars.Where(x => x.Color.ToLower() == color.ToLower()).ToList();
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }
        [HttpGet("CarMake/{make}")]
        public List<Car> GetCarByMake(string make)
        {
            try
            {
                return cars.Where(x => x.Make.ToLower() == make.ToLower()).ToList();
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }







    }
}
