using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljøfestivalen.Shared
{
    public class Frivillig : Bruger
    {
        public int FrivilligId { get; set; }
        public bool ErAktiv { get; set; }
        public bool ErBlacklistet { get; set; }
    }
}
