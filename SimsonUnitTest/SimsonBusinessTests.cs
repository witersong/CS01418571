using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumSimpSonApp5.Simson.DataEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NumSimpSonApp5.Simson.Business
{
    [TestClass]
    public class SimsonBusinessTests
    {



        [TestInitialize]
        public void TestInitialize()
        {


        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void getNumOfAvgSegTest()
        {
            SimsonBusiness simsonBusiness = this.CreateSimsonBusiness();
            double[] outputTest = new double[11] { 0, 0.11, 0.22, 0.33, 0.44, 0.55, 0.66, 0.77, 0.88, 0.99, 1.1 };

            List<SimsonEntity> lstSimSon = simsonBusiness.getNumOfAvgSeg(10, 9, 1.1);
            int index = 0;
            foreach (SimsonEntity simsonentity in lstSimSon)
            {
                Assert.AreEqual(Math.Round(simsonentity.NumOfAvgSeg,6),outputTest[index]);
                index++;
            }
        }


        public void getMultipleBuTest()
        {

            SimsonBusiness simsonBusiness = this.CreateSimsonBusiness();
           
            
        }

        private SimsonBusiness CreateSimsonBusiness()
        {
            return new SimsonBusiness();
        }

      
    }
}