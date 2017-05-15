using NumSimpSonApp5.Simson.Business;
using NumSimpSonApp5.Simson.DataEntity;
using NumSimpSonApp5.Simson.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSimpSonApp5.Simson.Model
{
    public class SimsonModelClassExample2
    {
        public SimsonFactorial simsonfactorial = new SimsonFactorial();
        public void setParameterExample2()
        {
            SimsonEntityIList ListSimsonEntity = new SimsonEntityIList();
            SimsonEntitySumList simsonentitysumlist = new SimsonEntitySumList();
            List<SimsonEntityIList> lstSimsonEntity = new List<SimsonEntityIList>();
            ListSimsonEntity.NumSeg = 10;
            ListSimsonEntity.ResultBias = 0.00001;
            ListSimsonEntity.NumDof = 10;

            ListSimsonEntity.NumDivOfNonInFac = 2;
            ListSimsonEntity.NumOfAvgSegConstant = 1;
            ListSimsonEntity.NumfactorailOfInteger = 4;
            ListSimsonEntity.NumX = 1.1812;

            SimsonModelClass modelClass = new SimsonModelClass();
            ListSimsonEntity.LstOfNonIntegerGamma = modelClass.getTupleOfNonIntegerGammaCalc(ListSimsonEntity.NumDof, ListSimsonEntity.NumDivOfNonInFac);
            ListSimsonEntity.NumfactorailOfInteger = simsonfactorial.FactorialInteger(ListSimsonEntity.NumfactorailOfInteger);
            ListSimsonEntity.NumDofOfPI = modelClass.FuncDofPi(ListSimsonEntity.NumDof);
            ListSimsonEntity.NumfactorailOfNonInteger = modelClass.setFactorialNonInteger(ListSimsonEntity.LstOfNonIntegerGamma, ListSimsonEntity.NumDof);

            SimsonBusiness simsonBu = new SimsonBusiness();
            SimsonCalculator simSonCalc = new SimsonCalculator();
            ListSimsonEntity.LstclsListDataEntity = simsonBu.getNumOfAvgSeg(ListSimsonEntity.NumSeg, ListSimsonEntity.NumDof, ListSimsonEntity.NumX);
            ListSimsonEntity.LstclsListDataEntity = simsonBu.getMultipleBu(ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getNumOfAvgDofPowDof(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getNumOfAvgDofPowDofByDividSecond(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity = simSonCalc.diffNumOfAvgSeg(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);

            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getRDofMultiDofPi_radius(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getSimsonFX(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getNumOfTerm(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity = simSonCalc.getResultBias(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            lstSimsonEntity.Add(ListSimsonEntity);
            SimsonExcel excel = new SimsonExcel();
            String Output =@"D:\Simpson_3.xls";
            excel.GenerateExcel(Output, ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);

            ListSimsonEntity.NumSeg = 20;
            ListSimsonEntity.ResultBias = 0.00001;
            ListSimsonEntity.NumDof = 10;

            ListSimsonEntity.NumDivOfNonInFac = 2;
            ListSimsonEntity.NumOfAvgSegConstant = 1;
            ListSimsonEntity.NumfactorailOfInteger = 4;
            ListSimsonEntity.NumX = 1.1812;

            ListSimsonEntity.LstOfNonIntegerGamma = modelClass.getTupleOfNonIntegerGammaCalc(ListSimsonEntity.NumDof, ListSimsonEntity.NumDivOfNonInFac);
            ListSimsonEntity.NumfactorailOfInteger = simsonfactorial.FactorialInteger(ListSimsonEntity.NumfactorailOfInteger);
            ListSimsonEntity.NumDofOfPI = modelClass.FuncDofPi(ListSimsonEntity.NumDof);
            ListSimsonEntity.NumfactorailOfNonInteger = modelClass.setFactorialNonInteger(ListSimsonEntity.LstOfNonIntegerGamma, ListSimsonEntity.NumDof);

            ListSimsonEntity.LstclsListDataEntity = simsonBu.getNumOfAvgSeg(ListSimsonEntity.NumSeg, ListSimsonEntity.NumDof, ListSimsonEntity.NumX);
            ListSimsonEntity.LstclsListDataEntity = simsonBu.getMultipleBu(ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getNumOfAvgDofPowDof(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getNumOfAvgDofPowDofByDividSecond(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity = simSonCalc.diffNumOfAvgSeg(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);

            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getRDofMultiDofPi_radius(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getSimsonFX(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getNumOfTerm(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity = simSonCalc.getResultBias(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            lstSimsonEntity.Add(ListSimsonEntity);
            Output = @"D:\Simpson_4.xls";
            excel.GenerateExcel(Output, ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);


        }
    }
}
