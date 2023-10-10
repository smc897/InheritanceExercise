using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile: Animal
    {
        public String NumberOfScales { get; set; }
        public String FavoriteBug { get; set; }
        public String FavoriteSpot { get; set; }
        public int NumberOfEyes { get; set; }

        public Reptile(string numberOfScales, string favoriteBug, string favoriteSpot, int numberOfEyes)
        {
            NumberOfScales = numberOfScales;
            FavoriteBug = favoriteBug;
            FavoriteSpot = favoriteSpot;
            NumberOfEyes = numberOfEyes;
            NumberOfLegs = 4;
            Name = "Reptile";
            Sound = "Hiss";
            FavoriteFood = "mice";
        }
    }
}
