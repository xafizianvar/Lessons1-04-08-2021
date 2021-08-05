using System;

namespace Lessons1
{
    class Program
    {
        static void Main(string[] args)
        {
            //middle geometrically
            double a=16.80, b=12.40,s;
            s=Math.Sqrt(a*b);
            Console.WriteLine($"Result: {s}");

            //long segments
            double A=1.40, B=-5.50, C=0.60,AC,BC,S;
            AC=Math.Abs(C-A);
            BC=Math.Abs(C-B);
            S=AC+BC;
            System.Console.WriteLine("AC= "+AC+" BC= "+BC+" AC+BC= "+S);

            //Distance between two points
            double x1=-6.20, y1=5.20, x2=2.10, y2=9.80,J;
            J=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
            System.Console.WriteLine("Result between two points: "+J);

            //Permutation of numbers
            int a1,b1,c1=14,l;
            a1=c1/10;
            b1=c1%10;
            l=b1*10+a1;
            System.Console.WriteLine("Result permutation: "+l);

            //begining of the week
            int N=10985;
            System.Console.WriteLine("Result: "+N%60);

            //Days of the week
            int K=202;
            System.Console.WriteLine("Result: "+K%7);                                                                              
        }
    }
}
