// See https://aka.ms/new-console-template for more information

namespace Laba1
{
    class Program
    {
        static void Main( ) //объявление метода  
        {
            double A = 7, B = 13, C = 10, p, S; //переменные


            p = ( A + B + C ) / 2;
            S = Math. Sqrt( p * ( p - A ) * ( p - B ) * ( p - C) );
            // Math.Sqrt - математическая функция которая извлекает квадратный корень

            Console. WriteLine( "S = " + S );
            Console. ReadLine( );
        }
    }
}