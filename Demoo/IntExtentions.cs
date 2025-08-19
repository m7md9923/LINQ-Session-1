using System.Numerics;

namespace Demoo;

internal static class IntExtentions
{
    public static int ReverseNumber(this int num)
    {
        int rem = 0 , rev = 0;
        while (num != 0)
        {
            rem = num % 10;
            rev = rev * 10 + rem;
            num /= 10;
        }
        return rev;
    }
    
    // method overloading 
    public static long ReverseNumber(this long num)
    {
        long rem = 0 , rev = 0;
        while (num != 0)
        {
            rem = num % 10;
            rev = rev * 10 + rem;
            num /= 10;
        }
        return rev;
    }
    
    // .Net 7.0 Method Generic   
     
    // public static T ReverseNumber<T>(T num) where T : INumber<T> 
    // {
    //     T rem = T.Zero , rev = T.Zero , ten = T.CreateChecked(10);
    //     while (num != T.Zero)
    //     {
    //         rem = num % ten;
    //         rev = rev * ten + rem;
    //         num /= ten;
    //     }
    //     return rev;
    // }
}