using System;
using System.Collections.Generic;
    
//variant 9
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

        public static double Formula(double x, double y) {
            float pi = 3.14f;
            return (Math.Cos(x) / (pi - 2 * x)) + 16 * y * Math.Sin(Math.Pow(x, 1/3));
        }

        public static bool Triangle(double x, double y, double z) {
            if (x + y > z && x + z > y && y + z > x)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public static int EquationSolution(double x_0, double E) {
            double x = 0; 
            double x_prev = x_0;
            int count = 0;
            double q = 0;

           
            while(q < 3) {
                x = 0.6 * Math.Exp(-3 * Math.Pow(x_prev, 2)) + 0.5;
                q = x - x_prev;
                count++;
                x = x_prev;
            }

            return count;
        }



        public static void Main(string[] args) {
            Console.WriteLine("Enter number of function: \n" +
            	"[1] - S \n"  +
            	"[2] - sm \n" +
            	"[3] - Math formila \n" +
            	"[4] - Triangle \n" +
                "[5] - EquationSolution \n");
            byte m = Convert.ToByte(Console.ReadLine());

            if (m == 1) { //-----------------------------------№9 TAB№1

                Console.Write("Enter t: ");
                double t = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter v_0: ");
                double v_0 = Convert.ToDouble(Console.ReadLine());
                double res = S(t, a, v_0);
                Console.WriteLine("S = " + res);
            } 
            else if(m == 2) { //------------------------------------№14 TAB№1
               
                Console.WriteLine("Enter sm: ");
                int q = Convert.ToInt32(Console.ReadLine());
                int rev = Reverse(q);
                Console.WriteLine("Reverse sm to m = " + rev);
            }
            else if(m == 3) { //------------------------------------№9 TAB№2 

                Console.WriteLine("Enter x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter y: ");
                double y = Convert.ToDouble(Console.ReadLine());
                double formul = Formula(x, y);
                Console.WriteLine("Result formuls = " + formul);
            }
            else if(m == 4) { //------------------------------------№1 TAB3

                Console.Write("Enter x, y, z: ");
                double X = Convert.ToDouble(Console.ReadLine());
                double Y = Convert.ToDouble(Console.ReadLine());
                double Z = Convert.ToDouble(Console.ReadLine());

                bool w = Triangle(X, Y, Z);
                if (w == true) {
                    Console.Write("Triangle exists!");
                }
                else {
                    Console.Write("Triangle not exists!");
                }
            }
            else if(m == 5) { //-------------------------------------№3 TAB4

                Console.Write("Enter x_0 and E: ");
                double x_0 = Convert.ToDouble(Console.ReadLine());
                double E = Convert.ToDouble(Console.ReadLine());
                int p = EquationSolution(x_0, E);
                Console.WriteLine("Count = " + p);
            }
            else {
                Console.WriteLine("Error! Enter number of function");
            }

          
        }
    }
}
