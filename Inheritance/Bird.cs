using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird: Animal
    {
        public String FavoriteRoostingPlace { get; set; }
        public int BeakSize { get; set; }
        public String FavoriteWord { get; set; }
        public String FeatherColor { get; set; }

        public Bird(string favoriteRoostingPlace, int beakSize, string favoriteWord, string featherColor)
        {
            FavoriteRoostingPlace = favoriteRoostingPlace;
            BeakSize = beakSize;
            FavoriteWord = favoriteWord;
            FeatherColor = featherColor;
            NumberOfLegs = 2;
            Name = "Bird";
            Sound = "Tweet";
            FavoriteFood = "worms";
        }
    }
}
