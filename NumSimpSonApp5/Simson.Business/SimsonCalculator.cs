using NumSimpSonApp5.Simson.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSimpSonApp5.Simson.Business
{
    public class SimsonCalculator
    {
        private double FINAL = 52.342777784553500;
        public List<SimsonEntity> getNumOfAvgDofPowDof(SimsonEntityIList simsonentityilist, List<SimsonEntity> lstSimsonEntity)
        {

            int NumOfAvgSeg = simsonentityilist.NumSeg;

            int constantNumOfAvg = simsonentityilist.NumOfAvgSegConstant;
            int sCounter = 0;
            foreach (SimsonEntity simsonentity in lstSimsonEntity)
            {
                SimsonEntity simSonEntity = new SimsonEntity();
                simSonEntity.NumOfAvgDofPowDof = constantNumOfAvg + (Math.Pow(simsonentity.NumOfAvgSeg, 2) / simsonentityilist.NumDof);
                lstSimsonEntity[sCounter].NumOfAvgDofPowDof = simSonEntity.NumOfAvgDofPowDof;
                sCounter++;
            }
            return lstSimsonEntity;
        }

        public SimsonEntityIList diffNumOfAvgSeg(SimsonEntityIList simsonentityilist, List<SimsonEntity>  lstSimsonEntity)
        {
            double[] arrayNumOfAvgSeg = lstSimsonEntity.Select(row => row.NumOfAvgSeg).ToArray();
            double diffNumOfAvgSeg = Math.Abs(arrayNumOfAvgSeg[1] - arrayNumOfAvgSeg[0]);
            simsonentityilist.DiffNumOfAvgSeg = diffNumOfAvgSeg;
            return simsonentityilist;
        }
        public List<SimsonEntity> getNumOfAvgDofPowDofByDividSecond (SimsonEntityIList simsonentityilist, List<SimsonEntity> lstSimsonEntity)
        {
            int sCounter = 0;
            foreach (SimsonEntity simsonentity in lstSimsonEntity)
            {
                SimsonEntity simSonEntity = new SimsonEntity();
                
                double powerAvg= (simsonentityilist.NumDof + simsonentityilist.NumOfAvgSegConstant) * 0.5 *-1;
                double numOfAvgDofPowDofDividSecond =  Math.Pow(simsonentity.NumOfAvgDofPowDof,powerAvg);
                simSonEntity.NumOfAvgDofPowDofDividSecond = numOfAvgDofPowDofDividSecond;
                lstSimsonEntity[sCounter].NumOfAvgDofPowDofDividSecond = simSonEntity.NumOfAvgDofPowDofDividSecond;
                sCounter++;
            }
            return lstSimsonEntity;
        }
        public List<SimsonEntity> getRDofMultiDofPi_radius(SimsonEntityIList simsonentityilist, List<SimsonEntity> lstSimsonEntity)
        {
            int sCounter = 0;

            if (simsonentityilist.NumDof % 2 == 1)
            {
                double vFacInteger = simsonentityilist.NumfactorailOfInteger;
                double vFuncDofPI = simsonentityilist.NumDofOfPI;
                double vFunNonInteger = simsonentityilist.NumfactorailOfNonInteger;
                double vFunDivied = vFuncDofPI * vFunNonInteger;
                foreach (SimsonEntity itemSimsonEntity in lstSimsonEntity)
                {
                    double resultNumOfrDofMultiDofPi_radius = (vFacInteger / vFunDivied);
                    lstSimsonEntity[sCounter].NumOfrDofMultiDofPi_radius = (resultNumOfrDofMultiDofPi_radius);
                    sCounter++;
                }
            }
            else
            {
                double vFacInteger = simsonentityilist.NumfactorailOfInteger;
                double vFuncDofPI = simsonentityilist.NumDofOfPI;
                double vFunNonInteger = FINAL;
                double vFunDivied = vFuncDofPI * vFunNonInteger;
                foreach (SimsonEntity itemSimsonEntity in lstSimsonEntity)
                {
                    double resultNumOfrDofMultiDofPi_radius = vFunNonInteger / (vFuncDofPI * vFacInteger);
                    lstSimsonEntity[sCounter].NumOfrDofMultiDofPi_radius = (resultNumOfrDofMultiDofPi_radius);
                    sCounter++;
                }
            }
            return lstSimsonEntity;
        }
        public List<SimsonEntity> getSimsonFX(SimsonEntityIList simsonEntityilist, List<SimsonEntity> lstSimsonEntity)
        {
            int sCounter = 0;
            
            foreach (SimsonEntity itemSimsonEntity in lstSimsonEntity)
            {
                double sumOfMultiDofPowerDof = 0;
                double numRDofMultiDofPi_radius = itemSimsonEntity.NumOfrDofMultiDofPi_radius;
                double numOfAvgPower = Math.Pow(itemSimsonEntity.NumOfAvgSeg, 2);
                double numOfBasePower = 1 + (numOfAvgPower / simsonEntityilist.NumDof);
                double numOfDofPowerDof = Math.Pow(numOfBasePower, Math.Abs((1+simsonEntityilist.NumDof)/2.0)*-1.0);
                sumOfMultiDofPowerDof = numRDofMultiDofPi_radius * numOfDofPowerDof;
                //double numSimsonFx = numRDofMultiDofPi_radius * 
                lstSimsonEntity[sCounter].NumOfFX = sumOfMultiDofPowerDof;
                sCounter++;

            }
            return lstSimsonEntity;
        }
   

        public List<SimsonEntity> getNumOfTerm(SimsonEntityIList simsonentityilist, List<SimsonEntity> lstSimsonEntity)
        {
            int sCounter = 0;
            double[] arrayNumOfAvgSeg = lstSimsonEntity.Select(row => row.NumOfAvgSeg).ToArray();
            double diffNumOfAvgSeg = arrayNumOfAvgSeg[2] - arrayNumOfAvgSeg[1];
            foreach (SimsonEntity itemSimsonEntity in lstSimsonEntity)
            {
                
                lstSimsonEntity[sCounter].NumOfTerm =  (diffNumOfAvgSeg / 3) * itemSimsonEntity.NumOfmutiplier * itemSimsonEntity.NumOfFX;
                sCounter++;
            }
            return lstSimsonEntity;
         }
        /// <summary>
        /// Get Result Bias
        /// </summary>
        /// <param name="simsonentityilist"></param>
        /// <param name="lstSimsonEntity"></param>
        /// <returns></returns>
        public SimsonEntityIList getResultBias(SimsonEntityIList simsonentityilist, List<SimsonEntity> lstSimsonEntity)
        {
            double sumResultTerm = lstSimsonEntity.Select(row => row.NumOfTerm).Sum();
            simsonentityilist.SumTermOfMutiple = Math.Abs(sumResultTerm);
            return simsonentityilist;
        }
    }
}
