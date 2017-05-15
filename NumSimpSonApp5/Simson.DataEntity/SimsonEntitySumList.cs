using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSimpSonApp5.Simson.DataEntity
{
    public   class SimsonEntitySumList
    {
        private List<SimsonEntityIList> simsonEntityDataIList;

        public List<SimsonEntityIList> SimsonEntityDataIList
        {
            get
            {
                return simsonEntityDataIList;
            }

            set
            {
                simsonEntityDataIList = value;
            }
        }
    }
}
