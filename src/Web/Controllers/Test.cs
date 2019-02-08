using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public static class Test
    {
        public static int FindLineCoverage(int totalLines, int numOfLinesCoverd)
        {
            if (totalLines < 0 || numOfLinesCoverd < 0 || totalLines<numOfLinesCoverd){
                return -1;
            }
            else if(numOfLinesCoverd == 0)
            {
                return 0;
            }
            else
            {
                double ratio = Convert.ToDouble(numOfLinesCoverd) / Convert.ToDouble(totalLines);
                int percentage = Convert.ToInt32(ratio * 100);
                return percentage;
            }
        }
    }
}
