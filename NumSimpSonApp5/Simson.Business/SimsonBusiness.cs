using NumSimpSonApp5.Simson.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSimpSonApp5.Simson.Business
{
    public class SimsonBusiness
    {
        public List<SimsonEntity> getNumOfAvgSeg(int numSeg, int dof,double numX)
        {
            List<SimsonEntity> lstSimsonEntity = new List<SimsonEntity>();
            for (int counterOfNumSeg = 0; counterOfNumSeg <= numSeg ; counterOfNumSeg++)
                {
                    SimsonEntity simsonEntity = new SimsonEntity();
                    simsonEntity.NumOfSegment = counterOfNumSeg;
                    simsonEntity.NumOfAvgSeg = ((Convert.ToDouble(counterOfNumSeg) *numX ) / numSeg );
                    lstSimsonEntity.Add(simsonEntity);
                }
            
            return lstSimsonEntity;
        }
     
        public List<SimsonEntity> getMultipleBu(List<SimsonEntity> lstSimsonEntity)
        {
            int sCounter = 0;
            foreach (SimsonEntity itemListSimsonEntity in lstSimsonEntity)
            {
                SimsonEntity simsonEntity = new SimsonEntity();
                if (itemListSimsonEntity.NumOfSegment == 0 || (lstSimsonEntity.Count -1)  == itemListSimsonEntity.NumOfSegment)
                {
                    simsonEntity.NumOfmutiplier = 1;
                }
                else if (itemListSimsonEntity.NumOfSegment % 2 == 0)
                {
                    simsonEntity.NumOfmutiplier = 2;
                }
                else
                {
                    simsonEntity.NumOfmutiplier = 4;
                }
                lstSimsonEntity[sCounter].NumOfmutiplier = simsonEntity.NumOfmutiplier;
                sCounter++;
            }
            return lstSimsonEntity;
        }
    }
}
