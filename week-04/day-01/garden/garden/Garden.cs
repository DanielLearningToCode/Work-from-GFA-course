using System;
using System.Collections.Generic;
using System.Text;

namespace garden
{
    class Garden
    {
        List<Plant> plants;
        public Garden()
        {
            plants = new List<Plant>
            {
                new Flower("yellow"),
                new Flower("blue"),
                new Tree("purple"),
                new Tree("orange")
            };
        }
        public int FlowersNeedingWater()
        {
            int count = 0;
            foreach (var plant in plants)
            {
                if (plant.NeedsWater())
                {
                    count++;
                }
            }
            return count;
        }
        public void WaterTheGarden(int amount)
        {
            int waterPerPlant = amount / FlowersNeedingWater();
            foreach (var plant in plants)
            {
                if (plant.NeedsWater())
                {
                    plant.Water(waterPerPlant);
                }
            }
        }
        public void Info()
        {
            string needs = "";
            foreach (var plant in plants)
            {
                needs = plant.NeedsWater() ? "needs water" : "does not need water";
                Console.WriteLine($"The {plant.Color} {plant.Name} {needs}.");
            }
        }
    }
}
