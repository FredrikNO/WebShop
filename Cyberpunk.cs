using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class Cyberpunk:Game,IPhysicalCopy,IDownLoadable
    {
        public Cyberpunk():base("Cyberpunk",250,2)
        {
            
        }
    }
}
