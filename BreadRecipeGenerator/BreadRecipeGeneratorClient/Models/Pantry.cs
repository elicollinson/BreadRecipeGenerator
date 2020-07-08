using System;
using System.Collections.Generic;
using System.Text;

namespace BreadRecipeGeneratorClient.Models
{
    class Pantry
    {
        public Pantry (int totalWhiteFlour, int totalWheatFlour, int totalWater, int totalSalt, int totalYeast)
        {
            TotalGramsWhiteFlour = totalWhiteFlour;
            TotalGramsWheatFlour = totalWheatFlour;
            TotalGramsWater = totalWater;
            TotalGramsSalt = totalSalt;
            TotalGramsYeast = totalYeast;
        }






        public int TotalGramsWhiteFlour
        {
            get; set;
        }

        public int TotalGramsWheatFlour
        {
            get; set;
        }

        public int TotalGramsWater
        {
            get; set;
        }

        public int TotalGramsSalt
        {
            get; set;
        }

        public int TotalGramsYeast
        {
            get; set;
        }



        //Method to update increase an amount of an individual product

        //Method that takes type recipe and decrements all pantry values

    }
}
