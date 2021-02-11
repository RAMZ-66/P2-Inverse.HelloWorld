using System;

namespace P2_Inverse.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letras = new string[9] {"H","e","l","o","W","r","l","d","!"};

            string WorldInverso = letras[8] + letras[7] + letras[6] + letras[5] + letras[3] + letras[4] ;

            string HelloInverso = letras[3] + letras[2] + letras[2] + letras[1] + letras[0] ;

            Console.WriteLine (WorldInverso + " " + HelloInverso);
        }
    }
}
