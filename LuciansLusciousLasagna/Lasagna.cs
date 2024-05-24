using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuciansLusciousLasagna
{
    internal class Lasagna
    {
        // The expected time to bake a lasagna in the oven.
        private const int ExpectedOvenTime = 40;

        /// <summary>
        /// Returns the expected number of minutes the lasagna should be in the oven.
        /// </summary>
        /// <returns></returns>
        public int ExpectedMinutesInoven()
        {
            return ExpectedOvenTime;
        }

        /// <summary>
        /// Returns the remaining minutes the lasagna needs to be in the oven.
        /// </summary>
        /// <param name="timeInOven"></param>
        /// <returns></returns>
        public int RemainingMinutesInOven(int timeInOven)
        {
            return ExpectedOvenTime - timeInOven;
        }

        /// <summary>
        /// Returns the preparation time in minutes given the number of layers.
        /// </summary>
        /// <param name="numberOfLayers"></param>
        /// <returns></returns>
        public int PreparationTimeInMinutes(int numberOfLayers)
        {
            const int PreparationTimeInMinutes = 2;
            return numberOfLayers * PreparationTimeInMinutes;
        }

        // Returns the total elapsed time in minutes, including preparation and baking time.
        public int ElapsedTimeInMinutes(int numberOfLayers, int timeInOven)
        {
            return PreparationTimeInMinutes(numberOfLayers) + timeInOven;
        }


    }
}
