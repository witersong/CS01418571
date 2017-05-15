using NumSimpSonApp5.Simson.Model;

namespace NumSimpSonApp5
{
    public class Program
    {

        /// <summary>
        ///        Program Assignment: Lab5 Apply Software Number Of Simpson
        ///        @Author :THANAWAT PHORNPHOMSRI
        ///        @STUDENT ID : 5814450118
        ///        @DESCRIPTION : Program Size calculation Software Appy Lab5
        ///             @Business     =Business
        ///             @DataEntity   =Data Entity 
        ///             @Excel        =Generate Excel 
        ///             @Model        = Connect Data
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SimsonModelClass model = new SimsonModelClass();
            model.setParameter();

            SimsonModelClassExample2 model2 = new SimsonModelClassExample2();
            model2.setParameterExample2();
        }
    }
}
