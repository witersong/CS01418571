using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSimpSonApp5.Simson.Business
{
    public class SimsonFactorial
    {
        public int FactorialInteger(int numBaseOfSimson)
        {
            if (numBaseOfSimson <= 1)
                return 1;
            else
                return numBaseOfSimson * FactorialInteger(numBaseOfSimson - 1);
        }
        public double FactorialNonInteger(List<Tuple<double, double>> lsInput) //9/2 7/2 5/2
        {

            double[] dN1 = lsInput.Select((t) =>    t.Item1).ToArray();
            double[] dN2 = lsInput.Select((t) => t.Item2).ToArray();
            double resFacNonInt = 0, resFacByDivid=1 ;
            double resultNonInteger = 0;
            for (int i = 1; i < dN1.Length-2 ; i++)
            {
                if (resFacNonInt == 0)
                {
                    resFacNonInt = ((dN1[i]));
                }
                else
                {
                    resFacNonInt *= ((dN1[i]));
                }
                //resFacByDivid += 
            }
            for (int i=1; i< dN2.Length-1; i++)
            {
                resFacByDivid *= 2.0;
            }
            resultNonInteger = ((resFacNonInt / resFacByDivid) *Math.Sqrt(Math.PI));
            return Math.Abs(resultNonInteger);
        }
    }
}
