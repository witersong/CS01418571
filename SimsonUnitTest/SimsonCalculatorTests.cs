using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumSimpSonApp5.Simson.DataEntity;
using NumSimpSonApp5.Simson.Model;
using System;
using System.Collections.Generic;

namespace NumSimpSonApp5.Simson.Business
{
    [TestClass]
    public class SimsonCalculatorTests
    {
        private SimsonEntityIList ListSimsonEntity = new SimsonEntityIList();
        private SimsonBusiness simsonBu = new SimsonBusiness();
        private SimsonCalculator simSonCalc = new SimsonCalculator();
        private List<SimsonEntityIList> lstSimsonEntity = new List<SimsonEntityIList>();
        private SimsonEntitySumList simsonentitysumlist = new SimsonEntitySumList();
        [TestInitialize]
        public void TestInitialize()
        {
            ListSimsonEntity.NumSeg = 10;
            ListSimsonEntity.ResultBias = 0.00001;
            ListSimsonEntity.NumDof = 9;
            ListSimsonEntity.NumDivOfNonInFac = 2;
            ListSimsonEntity.NumOfAvgSegConstant = 1;
            ListSimsonEntity.NumfactorailOfInteger = 4;
            ListSimsonEntity.NumX = 1.1;

            //End Assign Value to ListSimSonEntity


        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void getNumOfAvgDofPowDofTest()
        {
            
            double[] outputTest = new double[11] { 1.0, 1.001344444, 1.005377778, 1.0121, 1.021511111, 1.033611111, 1.0484, 1.065877778, 1.086044444, 1.1089, 1.134444444 };
            SimsonCalculator simsonCalculator = this.CreateSimsonCalculator();
            SimsonModelClass modelClass = new SimsonModelClass();

            ListSimsonEntity.LstOfNonIntegerGamma = modelClass.getTupleOfNonIntegerGammaCalc(ListSimsonEntity.NumDof, ListSimsonEntity.NumDivOfNonInFac);
            ListSimsonEntity.NumfactorailOfInteger = modelClass.simsonfactorial.FactorialInteger(ListSimsonEntity.NumfactorailOfInteger);
            ListSimsonEntity.NumDofOfPI = modelClass.FuncDofPi(ListSimsonEntity.NumDof);
            ListSimsonEntity.NumfactorailOfNonInteger = modelClass.setFactorialNonInteger(ListSimsonEntity.LstOfNonIntegerGamma, ListSimsonEntity.NumDof);
            ListSimsonEntity.LstclsListDataEntity = simsonBu.getNumOfAvgSeg(ListSimsonEntity.NumSeg, ListSimsonEntity.NumDof, ListSimsonEntity.NumX);
            ListSimsonEntity.LstclsListDataEntity = simsonBu.getMultipleBu(ListSimsonEntity.LstclsListDataEntity);
            ListSimsonEntity.LstclsListDataEntity = simSonCalc.getNumOfAvgDofPowDof(ListSimsonEntity, ListSimsonEntity.LstclsListDataEntity);

            int index = 0;
            foreach (SimsonEntity simsonentity in ListSimsonEntity.LstclsListDataEntity)
            {
                Assert.AreEqual(Math.Round(simsonentity.NumOfAvgDofPowDof,6), Math.Round(outputTest[index],6));
                index++;
            }
        }

        public void getMultipleBuTest()
        {

            int[] outputTest = new int[11] { 1,2,4, 2, 4, 2, 4, 2, 4, 2, 1 };

            SimsonCalculator simsonCalculator = this.CreateSimsonCalculator();
            SimsonModelClass modelClass = new SimsonModelClass();

            ListSimsonEntity.LstOfNonIntegerGamma = modelClass.getTupleOfNonIntegerGammaCalc(ListSimsonEntity.NumDof, ListSimsonEntity.NumDivOfNonInFac);
            ListSimsonEntity.NumfactorailOfInteger = modelClass.simsonfactorial.FactorialInteger(ListSimsonEntity.NumfactorailOfInteger);
            ListSimsonEntity.NumDofOfPI = modelClass.FuncDofPi(ListSimsonEntity.NumDof);
            ListSimsonEntity.NumfactorailOfNonInteger = modelClass.setFactorialNonInteger(ListSimsonEntity.LstOfNonIntegerGamma, ListSimsonEntity.NumDof);
            ListSimsonEntity.LstclsListDataEntity = simsonBu.getNumOfAvgSeg(ListSimsonEntity.NumSeg, ListSimsonEntity.NumDof, ListSimsonEntity.NumX);
            ListSimsonEntity.LstclsListDataEntity = simsonBu.getMultipleBu(ListSimsonEntity.LstclsListDataEntity);

            int index = 0;
            foreach (SimsonEntity simsonentity in ListSimsonEntity.LstclsListDataEntity)
            {
                Assert.AreEqual(simsonentity.NumOfmutiplier, outputTest[index]);
                index++;
            }
        }


         

        



        private SimsonCalculator CreateSimsonCalculator()
        {
            return new SimsonCalculator();
        }
        
    }
}