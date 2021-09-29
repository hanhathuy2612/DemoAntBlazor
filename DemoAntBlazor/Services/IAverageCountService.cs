using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAntBlazor.Services
{
    public interface IAverageCountService
    {
        int GetAverage();
    }
    public class AverageCountService : IAverageCountService
    {
        public int GetAverage()
        {
            return 5;
        }
    }
}
