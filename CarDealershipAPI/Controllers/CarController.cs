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
            new Car("Cadillac", "El Dorado", 1985, "black"),
            new Car("Lincoln", "Continental", 1985, "red"),
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
        [HttpGet("GetCarColor/{color}")]
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
        [HttpGet("GetCarMake/{make}")]
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
