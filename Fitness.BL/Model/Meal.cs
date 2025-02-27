﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Current meal keeper. Shows current meal of current user. Not keeps every meal.
    /// </summary>
    public sealed class Meal
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        /// <summary>
        /// Time of meal taking
        /// </summary>
        public DateTime MealTime { get; set; }
        /// <summary>
        /// Keeps products and its weight from current meal
        /// </summary>
        [NotMapped]
        public Dictionary<string, double> Foods { get; set; }
        /// <summary>
        /// Set Date and Time of the meal
        /// </summary>
        public Meal() { }
        public Meal(string userName)
        {
            UserName = ExceptionHelper.NullOrWhiteSpaceCheck(userName);
            MealTime = DateTime.Now;
            Foods = new();
        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (var item in Foods)
            {
                result += $"\n\t{item.Key} - {item.Value}g.";
            }
            return result;
        }
    }
}
