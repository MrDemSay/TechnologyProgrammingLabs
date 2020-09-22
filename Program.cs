using System;

//variant 8
namespace test
{
    class MainClass
    {
        public static double S(double t, double a, double v_0) {
            double s = v_0 * t + a * Math.Pow(t, 2) / 2;
            return s;
        }

        public static int Reverse(int q) {
            return q / 100;
        }



        public static void Main(string[] args)
        {
            Console.Write("Enter t: ");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter v_0: ");
            double v_0 = Convert.ToDouble(Console.ReadLine());
            double res = S(t, a, v_0);

            Console.WriteLine("S = " + res);
            //------------------------------------

            Console.WriteLine("Enter sm: ");
            int q = Convert.ToInt32(Console.ReadLine());
            int rev = Reverse(q);
            Console.WriteLine("Reverse sm to m = " + rev);



        }
    }
}
