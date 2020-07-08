using System;
using System.Collections.Generic;
using System.Text;

namespace BreadRecipeGeneratorClient.Models
{
    class StepTiming
    {
        public StepTiming(DateTime startOrEndTime, bool startTime, int bulkRiseTimeHours, int proofTimeMinutes, int numberOfFolds)
        {
            NumberOfFolds = numberOfFolds;
            if (startTime)
            {
                MixFlourAndWater = startOrEndTime;
                MixYeastAndSalt = MixFlourAndWater.AddMinutes(30);
                FirstFold = MixYeastAndSalt.AddMinutes(15);
                Shape = MixYeastAndSalt.AddHours(bulkRiseTimeHours);
                BreadInOven = Shape.AddMinutes(proofTimeMinutes);
                if(proofTimeMinutes >= 60)
                {
                    PreHeat = Shape;
                }
                else
                {
                    int bulkRiseMinutes = bulkRiseTimeHours * 60;
                    PreHeat = MixYeastAndSalt.AddMinutes(bulkRiseMinutes - (60 - proofTimeMinutes));
                }
                RemoveLid = BreadInOven.AddMinutes(30);
                RemoveFromOven = RemoveLid.AddMinutes(15);
                ReadyToEat = RemoveFromOven.AddMinutes(20);
            }
            else
            {
                ReadyToEat = startOrEndTime;
                RemoveFromOven = ReadyToEat.AddMinutes(-20);
                RemoveLid = RemoveFromOven.AddMinutes(-15);
                BreadInOven = RemoveLid.AddMinutes(-30);
                Shape = BreadInOven.AddMinutes(0 - proofTimeMinutes);
                PreHeat = BreadInOven.AddMinutes(-60);
                MixYeastAndSalt = Shape.AddHours(0 - bulkRiseTimeHours);
                MixFlourAndWater = MixYeastAndSalt.AddMinutes(-30);
                FirstFold = MixYeastAndSalt.AddMinutes(15);
            }
        }


        public int NumberOfFolds
        {
            get; set;
        }
        public bool PreFerment
        {
            get; set;
        }
        public DateTime MixFlourAndWater
        {
            get; set;
        }
        public DateTime MixYeastAndSalt
        {
            get; set;
        }
        public DateTime FirstFold
        {
            get; set;
        }
        public DateTime Shape
        {
            get; set;
        }
        public DateTime PreHeat
        {
            get; set;
        }
        public DateTime BreadInOven
        {
            get; set;
        }
        public DateTime RemoveLid
        {
            get; set;
        }
        public DateTime RemoveFromOven
        {
            get; set;
        }
        public DateTime ReadyToEat
        {
            get; set;
        }

        //Method To Print Recipe Timing
        public string RecipeTimingToString()
        {
            string result = "Recipe Timing:";
            result += "\nMix Flour and Water at: " + MixFlourAndWater.ToString("h:mm tt");
            result += "\nMix in Salt and Yeast at: " + MixYeastAndSalt.ToString("h:mm tt");
            for (int i = 1; i <= NumberOfFolds; i++)
            {
                result += "\nPerform Fold " + i + " At: " + MixYeastAndSalt.AddMinutes(15*i).ToString("h:mm tt");//For loop for folds
            }

            if (PreHeat.Equals(Shape))
            {
                result += "\nPreheat the oven to 475 degrees and shape the loaf at: " + PreHeat.ToString("h:mm tt");//Preheat/shape ifelse
            }
            else
            {
                result += "\nPreheat the oven to 475 degrees at: " + PreHeat.ToString("h:mm tt");
                result += "\nShape the loaf at: " + Shape.ToString("h:mm tt");
            }

            result += "\nPut Bread in the oven at: " + BreadInOven.ToString("h:mm tt");
            result += "\nRemove Dutch Oven lid at: " + RemoveLid.ToString("h:mm tt");
            result += "\nRemove bread from oven at: " + RemoveFromOven.ToString("h:mm tt");
            result += "\nBread will be ready to eat at: " + ReadyToEat.ToString("h:mm tt");
            return result;
        }

    }
}
