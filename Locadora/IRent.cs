using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora
{
    public interface IRent
    {
        public TimeSpan CalcDate();
    }
}