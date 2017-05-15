using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSimpSonApp5.Simson.DataEntity
{
    public class SimsonEntity
    {
        /// <summary>
        /// numOfSegment is Number Of Segment
        /// numOfAvfSeg  is xValue
        /// numOfAvgDofPowDof is 
        /// numOfAvgDofPowDofDividSecond
        /// numOfFuncNonIntegerGamma
        /// numOfrDofMultiDofPi_radius
        /// numOfFX
        /// numOfmutiplier
        
        /// </summary>

        private int numOfSegment;
        private double numOfAvgSeg;
        private double numOfAvgDofPowDof;
        private double numOfAvgDofPowDofDividSecond;
        private double numOfFuncNonIntegerGamma; //

        private double numOfrDofMultiDofPi_radius;
        private double numOfFX;
        private int numOfmutiplier;
        private double numOfTerm;
        private double resultBias;
        public int NumOfSegment
        {
            get
            {
                return numOfSegment;
            }

            set
            {
                numOfSegment = value;
            }
        }

        public double NumOfAvgSeg
        {
            get
            {
                return numOfAvgSeg;
            }

            set
            {
                numOfAvgSeg = value;
            }
        }

        public double NumOfAvgDofPowDof
        {
            get
            {
                return numOfAvgDofPowDof;
            }

            set
            {
                numOfAvgDofPowDof = value;
            }
        }

        public double NumOfFuncNonIntegerGamma
        {
            get
            {
                return numOfFuncNonIntegerGamma;
            }

            set
            {
                numOfFuncNonIntegerGamma = value;
            }
        }

        public double NumOfrDofMultiDofPi_radius
        {
            get
            {
                return numOfrDofMultiDofPi_radius;
            }

            set
            {
                numOfrDofMultiDofPi_radius = value;
            }
        }

        public double NumOfFX
        {
            get
            {
                return numOfFX;
            }

            set
            {
                numOfFX = value;
            }
        }

        public int NumOfmutiplier
        {
            get
            {
                return numOfmutiplier;
            }

            set
            {
                numOfmutiplier = value;
            }
        }

        public double NumOfTerm
        {
            get
            {
                return numOfTerm;
            }

            set
            {
                numOfTerm = value;
            }
        }

        public double NumOfAvgDofPowDofDividSecond
        {
            get
            {
                return numOfAvgDofPowDofDividSecond;
            }

            set
            {
                numOfAvgDofPowDofDividSecond = value;
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
    }
}
