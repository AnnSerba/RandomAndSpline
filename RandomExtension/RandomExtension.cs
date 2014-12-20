using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExtensionNS
{
   public static class RandomExtension//нормальное распределение
    {
        private static bool haveNextNextGaussian;
        private static double nextNextGaussian;

        public static double NextGaussian(this Random rand)
        {
            if (haveNextNextGaussian)
            {
                haveNextNextGaussian = false;
                return nextNextGaussian;
            }
            else
            {
                double v1, v2, s;
                do
                {
                    v1 = 2 * rand.NextDouble() - 1;   // between -1.0 and 1.0
                    v2 = 2 * rand.NextDouble() - 1;   // between -1.0 and 1.0
                    s = v1 * v1 + v2 * v2;
                } while (s >= 1 || s == 0);
                double multiplier = Math.Sqrt(-2 * Math.Log(s) / s);
                nextNextGaussian = v2 * multiplier;
                haveNextNextGaussian = true;
                return v1 * multiplier;
            }
        }
    }
   public static class RandomExtensionBetta
   {
       public static double NextBetta( this Random rand,double Alfa, double Betta)
       {
         
           return ((double)1 / BetaFunc(Alfa, Betta)) * Math.Pow(rand.NextDouble(), Alfa - 1) * Math.Pow((1 - rand.NextDouble()), Betta - 1);
       }

       private static double BetaFunc(double Alfa, double Betta)
       {
           double sum = 0;
           for (double i = 0; i < 1; i += 0.01)
           {
               sum += (double)Math.Pow(i, Alfa - 1) * Math.Pow((1 - i), (Betta - 1));
           }
           return sum;
       }
   }
}
