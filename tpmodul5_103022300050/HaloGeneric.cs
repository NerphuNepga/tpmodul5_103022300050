using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300050
{
    class HaloGeneric<T>
    {
        public void SapaUser(T user)
        {
            Console.WriteLine("Halo user " + user + "!");
        }
    }
}
