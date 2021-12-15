    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static void DisplayInformation(object o) {
                if(o.GetType() == typeof(string)){
                     Console.WriteLine("C'est une string.");
                } else if(o.GetType() == typeof(int)){
                    Console.WriteLine("C'est un int.");
                } else {
                    Console.WriteLine("Je ne connais pas ce type");
                }
            }
        }
    }