﻿using Fitness.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Controller
{
    /// <summary>
    /// 
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Application user
        /// </summary>
        public User User { get; }
        /// <summary>
        /// Create new Controller
        /// </summary>
        /// <param name="user"></param>
        public UserController(User user)
        {
            User = user ?? throw new ArgumentNullException(nameof(user), "User cannot be NULL.");
        }
        /// <summary>
        /// Save user data
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, User);
            }
        }
        /// <summary>
        /// Get user data
        /// </summary>
        /// <returns>Application user</returns>
        public User Load()
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream("users.dat", FileMode.Open))
            {
                return formatter.Deserialize(fileStream) as User;
            }
        }

    }
}
