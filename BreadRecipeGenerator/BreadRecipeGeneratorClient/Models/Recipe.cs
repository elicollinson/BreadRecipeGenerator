using System;
using System.Collections.Generic;
using System.Text;

namespace BreadRecipeGeneratorClient.Models
{
    public class Recipe
    {
        public int BulkRiseTimeHours
        {
            get; set;
        }
        public int ProofTimeMinutes
        {
            get; set;
        }
        public int NumberOfFolds
        {
            get; set;
        }
        public decimal WhiteFlourPercentage
        {
            get; set;
        }
        public decimal WheatFlourPercentage
        {
            get; set;
        }
        public decimal WaterPercentage
        {
            get; set;
        }
        public decimal SaltPercentage
        {
            get; set;
        }
        public decimal YeastPercentage
        {
            get; set;
        }

        public decimal GramsOfWhiteFlour
        {
            get; set;
        }

        public decimal GramsOfWheatFlour
        {
            get; set;
        }

        public decimal GramsOfWater
        {
            get; set;
        }

        public decimal GramsOfSalt
        {
            get; set;
        }

        public decimal GramsOfYeast
        {
            get; set;
        }

        //Method to Calculate Gram amounts

        //Method to Print Gram Amounts
    }
}
