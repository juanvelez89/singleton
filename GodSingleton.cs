using System;
using System.Collections.Generic;
using System.Text;

namespace singleton
{
    public class GodSingleton
    {
        private static GodSingleton godSingletonInstance;
        private static readonly object padlock = new object();
        public static GodSingleton GodSingletonInstance
        {
            get
            {
                lock (padlock)
                {
                    if (godSingletonInstance == null)
                    {
                        godSingletonInstance = new GodSingleton();
                    }
                    return godSingletonInstance;
                }
            }
        }
        public string CreateWorld() {
            return "let there be light";
        } 

        public static GodSingleton CreateGod()
        {
            return GodSingletonInstance;
        }
    }
}
