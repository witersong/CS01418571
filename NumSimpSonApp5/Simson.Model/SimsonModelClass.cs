using NumSimpSonApp5.Simson.Business;
using NumSimpSonApp5.Simson.DataEntity;
using NumSimpSonApp5.Simson.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSimpSonApp5.Simson.Model
{

    public class SimsonModelClass
    {
        public SimsonFactorial simsonfactorial = new SimsonFactorial();
        private String Path = System.AppDomain.CurrentDomain.BaseDirectory;
        private String FILENAME =  "Simpson.xls";
        private String FILENAME2 = "Simpson2.xls";


        public void setParameter()
        {
            StringBuilder Output = new StringBuilder();
            Output.Append(String.Format(String.Concat(Path,FILENAME)));

            //Start Create Object 
            SimsonEntityIList ListSimsonEntity = new SimsonEntityIList();
            SimsonBusiness simsonBu = new SimsonBusiness();
            SimsonCalculator simSonCalc = new SimsonCalculator();
            List<SimsonEntityIList> lstSimsonEntity = new List<SimsonEntityIList>();
            SimsonEntitySumList simsonentitysumlist = new SimsonEntitySumList();
            //End  Create Object 
            
            //Start Assign Value to ListSimSonEntity
            ListSimsonEntity.NumSeg = 10;
            ListSimsonEntity.ResultBias = 0.00001;
            ListSimsonEntity.NumDof = 9;
            ListSimsonEntity.NumDivOfNonInFac = 2;
            ListSimsonEntity.NumOfAvgSegConstant = 1;
            ListSimsonEntity.NumfactorailOfInteger = 4;
            ListSimsonEntity.NumX = 1.1;
            //End Assign Value to ListSimSonEntity

            ListSimsonEntity.LstOfNonIntegerGamma = getTupleOfNonIntegerGammaCalc(ListSimsonEntity.NumDof, ListSimsonEntity.NumDivOfNonInFac);
            ListSimsonEntity.NumfactorailOfInteger = simsonfactorial.FactorialInteger(ListSimsonEntity.NumfactorailOfInteger);
            ListSimsonEntity.NumDofOfPI = FuncDofPi(ListSimsonEntity.NumDof);
            ListSimsonEntity.NumfactorailOfNonInteger = setFactorialNonInteger(ListSimsonEntity.LstOfNonIntegerGamma, ListSimsonEntity.NumDof);
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

            simsonentitysumlist.SimsonEntityDataIList = lstSimsonEntity;


            SimsonExcel excel = new SimsonExcel();
            excel.GenerateExcel(Output.ToString(), ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            
            
            ListSimsonEntity.NumSeg = 20;
            ListSimsonEntity.ResultBias = 0.00001;
            ListSimsonEntity.NumDof = 9;
            ListSimsonEntity.NumDivOfNonInFac = 2;
            ListSimsonEntity.NumOfAvgSegConstant = 1;
            ListSimsonEntity.NumfactorailOfInteger = 4;
            
            ListSimsonEntity.LstOfNonIntegerGamma = getTupleOfNonIntegerGammaCalc(ListSimsonEntity.NumDof, ListSimsonEntity.NumDivOfNonInFac);
            ListSimsonEntity.NumfactorailOfInteger = simsonfactorial.FactorialInteger(ListSimsonEntity.NumfactorailOfInteger);
            ListSimsonEntity.NumDofOfPI = FuncDofPi(ListSimsonEntity.NumDof);
            ListSimsonEntity.NumfactorailOfNonInteger = setFactorialNonInteger(ListSimsonEntity.LstOfNonIntegerGamma, ListSimsonEntity.NumDof);
            
            ListSimsonEntity.LstclsListDataEntity = simsonBu.getNumOfAvgSeg(ListSimsonEntity.NumSeg, ListSimsonEntity.NumDof,ListSimsonEntity.NumX);
            ListSimsonEntity.LstclsListDataEntity = simsonBu.getMultipleBu(ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getNumOfAvgDofPowDof(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getNumOfAvgDofPowDofByDividSecond(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity = simSonCalc.diffNumOfAvgSeg(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);

            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getRDofMultiDofPi_radius(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getSimsonFX(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getNumOfTerm(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity = simSonCalc.getResultBias(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);
            lstSimsonEntity.Add(ListSimsonEntity);

            Output.Clear();
            Output.Append(String.Format(String.Concat(Path,FILENAME2)));
            excel.GenerateExcel(Output.ToString(), ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);

            


            return;
        }
        /// <summary>
        /// Function Dof
        /// </summary>
        /// <param name="NumDof"></param>
        /// <returns></returns>
        public double FuncDofPi(int NumDof)
        {
            double numConstant = 0.5;
            double numPI = Math.PI;
            double NumDofOfPI = Math.Pow(NumDof * numPI, numConstant);
            return NumDofOfPI;
        }
        /// <summary>
        /// Calculation Factorial Non Intger
        /// </summary>
        /// <param name="LstOfNonIntegerGamma"></param>
        /// <param name="NumDof"></param>
        /// <returns></returns>
        public double setFactorialNonInteger(List<Tuple<double, double>> LstOfNonIntegerGamma,int NumDof)
        {
            double facOfNonInteger = 0;
            if (NumDof % 2 == 1)
            {
                facOfNonInteger = simsonfactorial.FactorialNonInteger(LstOfNonIntegerGamma);
            }
            else
            {
                facOfNonInteger = 42.53889242;
            }
            return facOfNonInteger;
        }
        /// <summary>
        /// get Tuple Of NonIntegerGammaCalc
        /// </summary>
        /// <param name="NumDof"></param>
        /// <param name="NumDivOfNonInFac"></param>
        /// <returns></returns>
        public List<Tuple<double, double>> getTupleOfNonIntegerGammaCalc(int NumDof, int NumDivOfNonInFac)
        {
            List<Tuple<double, double>> lsTupNonIntegerGammaCalc = new List<Tuple<double, double>>();

            for (int i = 1; i <= NumDof; NumDof = NumDof - NumDivOfNonInFac)
            {
                lsTupNonIntegerGammaCalc.Add(new Tuple<double, double>(NumDof, NumDivOfNonInFac));
            }
            lsTupNonIntegerGammaCalc.Add(new Tuple<double, double>(Math.Sqrt(Math.PI), 1.00));
            return lsTupNonIntegerGammaCalc;
        }
    }
}
