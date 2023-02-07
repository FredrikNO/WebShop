using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class PUBG:Game,IPhysicalCopy,IDownLoadable
    {
        public PUBG():base("PUBG",100,4)
        {
            
        }
    }
}
