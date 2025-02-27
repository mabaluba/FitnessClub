﻿using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fitness.BL.Serialization
{
    public class BFSerialization//:ISerialization
    {
        public List<T> GetData<T>()
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream("users.dat", FileMode.Open))
            {
                if (formatter.Deserialize(fileStream) is List<T> users)
                {
                    return users;
                }
                else
                {
                    return new List<T>();
                }
            }
        }
        public void SaveData<T>(List<T> users)
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, users);
            }
        }
    }
}
