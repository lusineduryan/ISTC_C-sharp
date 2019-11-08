using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    interface ITime
    {
        DateTime GetCurrentTime();
        int GetAge(DateTime birthday);
    }
}
