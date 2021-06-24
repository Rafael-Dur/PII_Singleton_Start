using System;
using System.Collections.Generic;

namespace Library
{
    public class Singleton<T> where T : new() 
    {
        private static T instance;

        public static T Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
    }
}