using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Coffee
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int Cost { get; set; }


        public List<Coffee> GetAllCoffees()
        {
            var myList = new List<Coffee>
            {
                new Coffee{ Name="Latte" , Cost=2, Size="M"},
                new Coffee{ Name="Americano" , Cost=3, Size="L"},
                new Coffee{ Name="Expresso" , Cost=1, Size="S"},
                new Coffee{ Name="Mocha" , Cost=4, Size="XL"},

            };

            return myList;
        }
    }
    
}
