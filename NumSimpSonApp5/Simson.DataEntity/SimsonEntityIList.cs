using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSimpSonApp5.Simson.DataEntity
{
    public class SimsonEntityIList
    {
        private int _numDof;
        private double _numX;
        private int _numSeg;
        private int _numDivOfNonInFac;
        private int _numfactorailOfInteger;
        private double _numfactorailOfNonInteger;
        private double _numDofOfPI;
        private int _numOfAvgSegConstant;
        private List<SimsonEntity> lstclsListDataEntity;
        private List<Tuple<double, double>> _lstOfNonIntegerGamma;
        private double sumTermOfMutiple;
        private double resultBias;
        private double diffNumOfAvgSeg;
        private double maxAvgOfSegment;
        private double valX;
        public int NumDof
        {
            get
            {
                return _numDof;
            }

            set
            {
                _numDof = value;
            }
        }

        public int NumSeg
        {
            get
            {
                return _numSeg;
            }

            set
            {
                _numSeg = value;
            }
        }

        public int NumDivOfNonInFac
        {
            get
            {
                return _numDivOfNonInFac;
            }

            set
            {
                _numDivOfNonInFac = value;
            }
        }

        public int NumfactorailOfInteger
        {
            get
            {
                return _numfactorailOfInteger;
            }

            set
            {
                _numfactorailOfInteger = value;
            }
        }

        public double NumfactorailOfNonInteger
        {
            get
            {
                return _numfactorailOfNonInteger;
            }

            set
            {
                _numfactorailOfNonInteger = value;
            }
        }

        public double NumDofOfPI
        {
            get
            {
                return _numDofOfPI;
            }

            set
            {
                _numDofOfPI = value;
            }
        }

        public int NumOfAvgSegConstant
        {
            get
            {
                return _numOfAvgSegConstant;
            }

            set
            {
                _numOfAvgSegConstant = value;
            }
        }

        public List<SimsonEntity> LstclsListDataEntity
        {
            get
            {
                return lstclsListDataEntity;
            }

            set
            {
                lstclsListDataEntity = value;
            }
        }

        public List<Tuple<double, double>> LstOfNonIntegerGamma
        {
            get
            {
                return _lstOfNonIntegerGamma;
            }

            set
            {
                _lstOfNonIntegerGamma = value;
            }
        }

        public double ResultBias
        {
            get
            {
                return resultBias;
            }

            set
            {
                resultBias = value;
            }
        }

        public double SumTermOfMutiple
        {
            get
            {
                return sumTermOfMutiple;
            }

            set
            {
                sumTermOfMutiple = value;
            }
        }

        public double DiffNumOfAvgSeg
        {
            get
            {
                return diffNumOfAvgSeg;
            }

            set
            {
                diffNumOfAvgSeg = value;
            }
        }

        public double MaxAvgOfSegment
        {
            get
            {
                return maxAvgOfSegment;
            }

            set
            {
                maxAvgOfSegment = value;
            }
        }

        public double ValX
        {
            get
            {
                return valX;
            }

            set
            {
                valX = value;
            }
        }

        public double NumX
        {
            get
            {
                return _numX;
            }

            set
            {
                _numX = value;
            }
        }
    }
}
