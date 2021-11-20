﻿using System;

namespace Fitness.BL.Model
{
    public class Food
    {
        public string FoodName { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Carbohydrates { get; set; }
        /// <summary>
        /// Calories in 100g
        /// </summary>
        public double Calories { get; set; }
        public Food(){ }
        public Food(string foodName, double calories, double proteins, double fats, double carbohydrates)
        {
            FoodName = foodName;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
        }
        public override string ToString()
        {
            return FoodName+" "+ Calories+"cal.";
        }
    }
}
