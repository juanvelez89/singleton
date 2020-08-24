using System;
using System.Collections.Generic;
using System.Text;

namespace singleton
{
    public class GodSingleton
    {
        private static GodSingleton godSingleton;
        public string CreateWorld() {
            return "Hágase la luz";
        } 

        public static GodSingleton CreateGod()
        {
            if(godSingleton == null)
            {
                godSingleton = new GodSingleton();
            }
            return godSingleton;
        }
    }
}
