using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var god = GodSingleton.CreateGod();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine( god.CreateWorld());
        }
    }
}
