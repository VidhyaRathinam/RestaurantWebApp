using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Data.Models;
using WebApplication2.Data.Services;

namespace WebApplication2.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name="Tasty Pizza", Cuisine=CuisineType.Italian},
                new Restaurant {Id = 2, Name="Lassi Belly", Cuisine=CuisineType.Indian},
                new Restaurant {Id = 3, Name="Mexcican Pasta", Cuisine=CuisineType.Mexican}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
