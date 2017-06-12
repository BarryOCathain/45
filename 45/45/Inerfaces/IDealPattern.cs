using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.Inerfaces
{
    interface IDealPattern
    {
        void Deal(IPlayer[] players, IDeck deck);
    }
}
